using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using GamesN;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace GameLibraryServer
{
    class Program
    {
        internal class GamesLibraryImplement : GamesN.GamesLibrary.GamesLibraryBase
        {
            const string DATABASENAME = "gamesdatabase";
            DBConnection dbCon = DBConnection.Instance();
            readonly List<string> sessions = new List<string>();

            override public Task<Result> AddGame(GameUID request, ServerCallContext context)
            {
                if (sessions.Contains(request.Uid))
                {
                    if (dbCon.IsConnect())
                    {
                        string query = string.Format("INSERT INTO games (name,price) VALUES (\"{0}\",{1})", request.Name, request.Price);

                        if (dbCon.Connection.State == System.Data.ConnectionState.Closed)
                        {
                            dbCon.OpenConnection();
                        }

                        MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection);
                        int reader = cmd.ExecuteNonQuery();
                        if (reader <= 0)
                        {
                            Console.WriteLine(DateTime.Now.ToString() + ": " + "Error occured while inserting into the database!");
                            return Task.FromResult(new Result { Success = "Error occured while inserting into the database!" });
                        }

                        dbCon.Close();
                        Console.WriteLine(DateTime.Now.ToString() + ": " + request.Name + " inserted into the database by: " + request.Uid);
                        return Task.FromResult(new Result { Success = request.Name + " succesfully inserted into the database!" });
                    }
                    Console.WriteLine(DateTime.Now.ToString() + ": " + "Coudn't insert to database!");
                    return Task.FromResult(new Result { Success = "Coudn't insert to database!" });
                }
                return Task.FromResult(new Result { Success = "You are not logged in!" });
            }

            override public Task<Result> DeleteGame(GameID request, ServerCallContext context)
            {
                if (sessions.Contains(request.Id))
                {
                    if (dbCon.IsConnect())
                    {
                        string query = string.Format("DELETE FROM games WHERE id=" + request.Gid);

                        if (dbCon.Connection.State == System.Data.ConnectionState.Closed)
                        {
                            dbCon.OpenConnection();
                        }

                        MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection);
                        int reader = cmd.ExecuteNonQuery();
                        if (reader <= 0)
                        {
                            return Task.FromResult(new Result { Success = string.Format("Nothing found with this id ({0})!", request.Gid) });
                        }

                        dbCon.Close();
                        Console.WriteLine(DateTime.Now.ToString() + ": " + request.Gid + " deleted from the database by: " + request.Id);
                        return Task.FromResult(new Result { Success = request.Gid + "  deleted from the database!" });
                    }
                    Console.WriteLine(DateTime.Now.ToString() + ": " + "Coudn't delete from database!");
                    return Task.FromResult(new Result { Success = "Coudn't delete from database!" });
                }
                return Task.FromResult(new Result { Success = "You are not logged in!" });
            }

            override public async Task GetGames(Session_Id request, IServerStreamWriter<Game> responseStream, ServerCallContext context)
            {
                try
                {
                    if (sessions.Contains(request.Id))
                    {
                        var dbCon = DBConnection.Instance();
                        dbCon.DatabaseName = DATABASENAME;
                        if (dbCon.IsConnect())
                        {
                            string query = "SELECT * FROM games ORDER BY id";
                            if (dbCon.Connection.State == System.Data.ConnectionState.Closed)
                            {
                                dbCon.OpenConnection();
                            }
                            var cmd = new MySqlCommand(query, dbCon.Connection);
                            var reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                Game game = new Game { Gid = reader.GetInt32(0), Name = reader.GetString(1), Price = reader.GetInt32(2) };
                                await responseStream.WriteAsync(game);
                            }
                            dbCon.Close();
                            Console.WriteLine(DateTime.Now.ToString() + ": " + "Games list asked by " + request.Id);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            override public Task<Session_Id> Login(User user, ServerCallContext context)
            {
                string id = "";
                if (user.Name == "u" && user.Passwd == "p")
                {
                    id = Guid.NewGuid().ToString();
                    sessions.Add(id);
                    dbCon.DatabaseName = DATABASENAME;
                    Console.WriteLine(DateTime.Now.ToString() + ": " + user.Name + " logged in");
                    return Task.FromResult(new Session_Id { Id = id });
                }
                else
                    return Task.FromResult(new Session_Id { Id = null });
            }

            override public Task<Result> Logout(Session_Id request, ServerCallContext context)
            {
                Result result = new Result();
                string idje = request.Id;
                if (sessions.Contains(idje))
                {
                    result.Success = "Succesfully logged out!";
                    sessions.Remove(idje);
                    Console.WriteLine(DateTime.Now.ToString() + ": " + idje + " logged out");
                }
                else
                    result.Success = "You are not logged in!";
                return Task.FromResult(new Result { Success = result.Success });
            }

            override public Task<Result> ModifyGame(GameIdUid request, ServerCallContext context)
            {
                if (sessions.Contains(request.Uid))
                {
                    if (dbCon.IsConnect())
                    {
                        string query = string.Format("UPDATE games SET name=\"{0}\",price={1} WHERE id={2}", request.Name, request.Price, request.Gid);

                        if (dbCon.Connection.State == System.Data.ConnectionState.Closed)
                        {
                            dbCon.OpenConnection();
                        }

                        MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection);
                        int reader = cmd.ExecuteNonQuery();
                        if (reader <= 0)
                        {
                            return Task.FromResult(new Result { Success = string.Format("Nothing found with this id ({0})!", request.Gid) });
                        }

                        dbCon.Close();
                        Console.WriteLine(DateTime.Now.ToString() + ": " + request.Gid + " modified by: " + request.Uid);
                        return Task.FromResult(new Result { Success = request.Gid + " modified!" });
                    }
                    Console.WriteLine(DateTime.Now.ToString() + ": " + "Coudn't modifie!");
                    return Task.FromResult(new Result { Success = "Coudn't modifie!" });
                }
                return Task.FromResult(new Result { Success = "You are not logged in!" });
            }
        }

        static void Main(string[] args)
        {
            const int PORT = 1234;
            Server server = new Server
            {
                Services = { GamesLibrary.BindService(new GamesLibraryImplement()) },
                Ports = { new ServerPort("localhost", PORT, ServerCredentials.Insecure) }
            };
            server.Start();
            Console.WriteLine("{0}: Server started, port: {1}", DateTime.Now.ToString(), PORT);
            Console.WriteLine("Press ENTER to stop the server...");
            Console.WriteLine();
            Console.ReadLine();
            server.ShutdownAsync().Wait();
        }
    }
}
