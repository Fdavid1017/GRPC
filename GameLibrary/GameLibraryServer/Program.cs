using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using GamesN;

namespace GameLibraryServer
{
    class Program
    {
        internal class GamesLibraryImplement : GamesN.GamesLibrary.GamesLibraryBase
        {
            readonly List<string> sessions = new List<string>();

            public Task<Result> AddGame(GameUID request, ServerCallContext context)
            {
                throw new NotImplementedException();
            }

            public Task<Result> DeleteGame(GameUID request, ServerCallContext context)
            {
                throw new NotImplementedException();
            }

            public async Task GetGames(Session_Id request, IServerStreamWriter<Game> responseStream, ServerCallContext context)
            {
                for (int i = 0; i < 5; i++)
                {
                    await responseStream.WriteAsync(new Game { Gid = i, Name = i + ". Game", Price = i * 1000 });
                }
            }

            override public Task<Session_Id> Login(User user, ServerCallContext context)
            {
                string id = "";
                if (user.Name == "u" && user.Passwd == "p")
                {
                    id = Guid.NewGuid().ToString();
                    sessions.Add(id);
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
                }
                else
                    result.Success = "You are not logged in!";
                return Task.FromResult(new Result { Success = result.Success });
            }

            public Task<Game> ModifyGame(GameID request, ServerCallContext context)
            {
                throw new NotImplementedException();
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
            Console.ReadLine();
            server.ShutdownAsync().Wait();
        }
    }
}
