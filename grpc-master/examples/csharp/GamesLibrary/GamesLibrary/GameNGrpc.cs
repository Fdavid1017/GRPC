// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: gameN.proto
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace GamesN {
  public static class GamesLibrary
  {
    static readonly string __ServiceName = "gamesN.GamesLibrary";

    static readonly Marshaller<global::GamesN.Session_Id> __Marshaller_Session_Id = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.Session_Id.Parser.ParseFrom);
    static readonly Marshaller<global::GamesN.Game> __Marshaller_Game = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.Game.Parser.ParseFrom);
    static readonly Marshaller<global::GamesN.GameID> __Marshaller_GameID = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.GameID.Parser.ParseFrom);
    static readonly Marshaller<global::GamesN.GameUID> __Marshaller_GameUID = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.GameUID.Parser.ParseFrom);
    static readonly Marshaller<global::GamesN.Result> __Marshaller_Result = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.Result.Parser.ParseFrom);
    static readonly Marshaller<global::GamesN.User> __Marshaller_User = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.User.Parser.ParseFrom);

    static readonly Method<global::GamesN.Session_Id, global::GamesN.Game> __Method_GetGames = new Method<global::GamesN.Session_Id, global::GamesN.Game>(
        MethodType.ServerStreaming,
        __ServiceName,
        "GetGames",
        __Marshaller_Session_Id,
        __Marshaller_Game);

    static readonly Method<global::GamesN.GameID, global::GamesN.Game> __Method_ModifyGame = new Method<global::GamesN.GameID, global::GamesN.Game>(
        MethodType.Unary,
        __ServiceName,
        "ModifyGame",
        __Marshaller_GameID,
        __Marshaller_Game);

    static readonly Method<global::GamesN.GameUID, global::GamesN.Result> __Method_AddGame = new Method<global::GamesN.GameUID, global::GamesN.Result>(
        MethodType.Unary,
        __ServiceName,
        "AddGame",
        __Marshaller_GameUID,
        __Marshaller_Result);

    static readonly Method<global::GamesN.GameUID, global::GamesN.Result> __Method_DeleteGame = new Method<global::GamesN.GameUID, global::GamesN.Result>(
        MethodType.Unary,
        __ServiceName,
        "DeleteGame",
        __Marshaller_GameUID,
        __Marshaller_Result);

    static readonly Method<global::GamesN.User, global::GamesN.Session_Id> __Method_Login = new Method<global::GamesN.User, global::GamesN.Session_Id>(
        MethodType.Unary,
        __ServiceName,
        "Login",
        __Marshaller_User,
        __Marshaller_Session_Id);

    static readonly Method<global::GamesN.Session_Id, global::GamesN.Result> __Method_Logout = new Method<global::GamesN.Session_Id, global::GamesN.Result>(
        MethodType.Unary,
        __ServiceName,
        "Logout",
        __Marshaller_Session_Id,
        __Marshaller_Result);

    // service descriptor
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GamesN.GameN.Descriptor.Services[0]; }
    }

    // client interface
    public interface IGamesLibraryClient
    {
      AsyncServerStreamingCall<global::GamesN.Game> GetGames(global::GamesN.Session_Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncServerStreamingCall<global::GamesN.Game> GetGames(global::GamesN.Session_Id request, CallOptions options);
      global::GamesN.Game ModifyGame(global::GamesN.GameID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::GamesN.Game ModifyGame(global::GamesN.GameID request, CallOptions options);
      AsyncUnaryCall<global::GamesN.Game> ModifyGameAsync(global::GamesN.GameID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::GamesN.Game> ModifyGameAsync(global::GamesN.GameID request, CallOptions options);
      global::GamesN.Result AddGame(global::GamesN.GameUID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::GamesN.Result AddGame(global::GamesN.GameUID request, CallOptions options);
      AsyncUnaryCall<global::GamesN.Result> AddGameAsync(global::GamesN.GameUID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::GamesN.Result> AddGameAsync(global::GamesN.GameUID request, CallOptions options);
      global::GamesN.Result DeleteGame(global::GamesN.GameUID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::GamesN.Result DeleteGame(global::GamesN.GameUID request, CallOptions options);
      AsyncUnaryCall<global::GamesN.Result> DeleteGameAsync(global::GamesN.GameUID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::GamesN.Result> DeleteGameAsync(global::GamesN.GameUID request, CallOptions options);
      global::GamesN.Session_Id Login(global::GamesN.User request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::GamesN.Session_Id Login(global::GamesN.User request, CallOptions options);
      AsyncUnaryCall<global::GamesN.Session_Id> LoginAsync(global::GamesN.User request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::GamesN.Session_Id> LoginAsync(global::GamesN.User request, CallOptions options);
      global::GamesN.Result Logout(global::GamesN.Session_Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      global::GamesN.Result Logout(global::GamesN.Session_Id request, CallOptions options);
      AsyncUnaryCall<global::GamesN.Result> LogoutAsync(global::GamesN.Session_Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken));
      AsyncUnaryCall<global::GamesN.Result> LogoutAsync(global::GamesN.Session_Id request, CallOptions options);
    }

    // server-side interface
    public interface IGamesLibrary
    {
      Task GetGames(global::GamesN.Session_Id request, IServerStreamWriter<global::GamesN.Game> responseStream, ServerCallContext context);
      Task<global::GamesN.Game> ModifyGame(global::GamesN.GameID request, ServerCallContext context);
      Task<global::GamesN.Result> AddGame(global::GamesN.GameUID request, ServerCallContext context);
      Task<global::GamesN.Result> DeleteGame(global::GamesN.GameUID request, ServerCallContext context);
      Task<global::GamesN.Session_Id> Login(global::GamesN.User request, ServerCallContext context);
      Task<global::GamesN.Result> Logout(global::GamesN.Session_Id request, ServerCallContext context);
    }

    // client stub
    public class GamesLibraryClient : ClientBase, IGamesLibraryClient
    {
      public GamesLibraryClient(Channel channel) : base(channel)
      {
      }
      public AsyncServerStreamingCall<global::GamesN.Game> GetGames(global::GamesN.Session_Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_GetGames, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncServerStreamingCall(call, request);
      }
      public AsyncServerStreamingCall<global::GamesN.Game> GetGames(global::GamesN.Session_Id request, CallOptions options)
      {
        var call = CreateCall(__Method_GetGames, options);
        return Calls.AsyncServerStreamingCall(call, request);
      }
      public global::GamesN.Game ModifyGame(global::GamesN.GameID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_ModifyGame, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::GamesN.Game ModifyGame(global::GamesN.GameID request, CallOptions options)
      {
        var call = CreateCall(__Method_ModifyGame, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::GamesN.Game> ModifyGameAsync(global::GamesN.GameID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_ModifyGame, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::GamesN.Game> ModifyGameAsync(global::GamesN.GameID request, CallOptions options)
      {
        var call = CreateCall(__Method_ModifyGame, options);
        return Calls.AsyncUnaryCall(call, request);
      }
      public global::GamesN.Result AddGame(global::GamesN.GameUID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_AddGame, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::GamesN.Result AddGame(global::GamesN.GameUID request, CallOptions options)
      {
        var call = CreateCall(__Method_AddGame, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::GamesN.Result> AddGameAsync(global::GamesN.GameUID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_AddGame, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::GamesN.Result> AddGameAsync(global::GamesN.GameUID request, CallOptions options)
      {
        var call = CreateCall(__Method_AddGame, options);
        return Calls.AsyncUnaryCall(call, request);
      }
      public global::GamesN.Result DeleteGame(global::GamesN.GameUID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_DeleteGame, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::GamesN.Result DeleteGame(global::GamesN.GameUID request, CallOptions options)
      {
        var call = CreateCall(__Method_DeleteGame, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::GamesN.Result> DeleteGameAsync(global::GamesN.GameUID request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_DeleteGame, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::GamesN.Result> DeleteGameAsync(global::GamesN.GameUID request, CallOptions options)
      {
        var call = CreateCall(__Method_DeleteGame, options);
        return Calls.AsyncUnaryCall(call, request);
      }
      public global::GamesN.Session_Id Login(global::GamesN.User request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_Login, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::GamesN.Session_Id Login(global::GamesN.User request, CallOptions options)
      {
        var call = CreateCall(__Method_Login, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::GamesN.Session_Id> LoginAsync(global::GamesN.User request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_Login, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::GamesN.Session_Id> LoginAsync(global::GamesN.User request, CallOptions options)
      {
        var call = CreateCall(__Method_Login, options);
        return Calls.AsyncUnaryCall(call, request);
      }
      public global::GamesN.Result Logout(global::GamesN.Session_Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_Logout, new CallOptions(headers, deadline, cancellationToken));
        return Calls.BlockingUnaryCall(call, request);
      }
      public global::GamesN.Result Logout(global::GamesN.Session_Id request, CallOptions options)
      {
        var call = CreateCall(__Method_Logout, options);
        return Calls.BlockingUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::GamesN.Result> LogoutAsync(global::GamesN.Session_Id request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        var call = CreateCall(__Method_Logout, new CallOptions(headers, deadline, cancellationToken));
        return Calls.AsyncUnaryCall(call, request);
      }
      public AsyncUnaryCall<global::GamesN.Result> LogoutAsync(global::GamesN.Session_Id request, CallOptions options)
      {
        var call = CreateCall(__Method_Logout, options);
        return Calls.AsyncUnaryCall(call, request);
      }
    }

    // creates service definition that can be registered with a server
    public static ServerServiceDefinition BindService(IGamesLibrary serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder(__ServiceName)
          .AddMethod(__Method_GetGames, serviceImpl.GetGames)
          .AddMethod(__Method_ModifyGame, serviceImpl.ModifyGame)
          .AddMethod(__Method_AddGame, serviceImpl.AddGame)
          .AddMethod(__Method_DeleteGame, serviceImpl.DeleteGame)
          .AddMethod(__Method_Login, serviceImpl.Login)
          .AddMethod(__Method_Logout, serviceImpl.Logout).Build();
    }

    // creates a new client
    public static GamesLibraryClient NewClient(Channel channel)
    {
      return new GamesLibraryClient(channel);
    }

  }
}
#endregion
