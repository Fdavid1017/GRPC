using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using GamesN;

namespace GLServer
{
  class Program
  {
    static void Main(string[] args)
    {
      const int Port = 50052;
      Server server = new Server
      {
        Services = { GamesLibrary.BindService(new GamesLibraryImplement()) },
        Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
      };
      server.Start();
      Console.WriteLine("Fibos program indul, port " + Port);
      Console.WriteLine("Press any key to stop the server...");
      Console.ReadKey();
      server.ShutdownAsync().Wait();
    }
  }

  internal class GamesLibraryImplement : GamesLibrary.IGamesLibrary
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

    public Task GetGames(Session_Id request, IServerStreamWriter<Game> responseStream, ServerCallContext context)
    {
      throw new NotImplementedException();
    }

    public Task<Session_Id> Login(User user, ServerCallContext context)
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

    public Task<Result> Logout(Session_Id request, ServerCallContext context)
    {
      Result result = new Result();
      string idje = request.Id;
      if (sessions.Contains(idje))
      {
        result.Success = "Sikeres kijelentkezés!";
        sessions.Remove(idje);
      }
      else
        result.Success = "Nem volt bejelentkezve!";
      return Task.FromResult(new Result { Success = result.Success });
    }

    public Task<Game> ModifyGame(GameID request, ServerCallContext context)
    {
      throw new NotImplementedException();
    }
  }
}

