// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gameN.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GamesN {
  public static partial class GamesLibrary
  {
    static readonly string __ServiceName = "gamesN.GamesLibrary";

    static readonly grpc::Marshaller<global::GamesN.Session_Id> __Marshaller_gamesN_Session_Id = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.Session_Id.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GamesN.Game> __Marshaller_gamesN_Game = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.Game.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GamesN.GameID> __Marshaller_gamesN_GameID = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.GameID.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GamesN.GameUID> __Marshaller_gamesN_GameUID = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.GameUID.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GamesN.Result> __Marshaller_gamesN_Result = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.Result.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GamesN.User> __Marshaller_gamesN_User = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GamesN.User.Parser.ParseFrom);

    static readonly grpc::Method<global::GamesN.Session_Id, global::GamesN.Game> __Method_GetGames = new grpc::Method<global::GamesN.Session_Id, global::GamesN.Game>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetGames",
        __Marshaller_gamesN_Session_Id,
        __Marshaller_gamesN_Game);

    static readonly grpc::Method<global::GamesN.GameID, global::GamesN.Game> __Method_ModifyGame = new grpc::Method<global::GamesN.GameID, global::GamesN.Game>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ModifyGame",
        __Marshaller_gamesN_GameID,
        __Marshaller_gamesN_Game);

    static readonly grpc::Method<global::GamesN.GameUID, global::GamesN.Result> __Method_AddGame = new grpc::Method<global::GamesN.GameUID, global::GamesN.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddGame",
        __Marshaller_gamesN_GameUID,
        __Marshaller_gamesN_Result);

    static readonly grpc::Method<global::GamesN.GameUID, global::GamesN.Result> __Method_DeleteGame = new grpc::Method<global::GamesN.GameUID, global::GamesN.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteGame",
        __Marshaller_gamesN_GameUID,
        __Marshaller_gamesN_Result);

    static readonly grpc::Method<global::GamesN.User, global::GamesN.Session_Id> __Method_Login = new grpc::Method<global::GamesN.User, global::GamesN.Session_Id>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Login",
        __Marshaller_gamesN_User,
        __Marshaller_gamesN_Session_Id);

    static readonly grpc::Method<global::GamesN.Session_Id, global::GamesN.Result> __Method_Logout = new grpc::Method<global::GamesN.Session_Id, global::GamesN.Result>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Logout",
        __Marshaller_gamesN_Session_Id,
        __Marshaller_gamesN_Result);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GamesN.GameNReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GamesLibrary</summary>
    [grpc::BindServiceMethod(typeof(GamesLibrary), "BindService")]
    public abstract partial class GamesLibraryBase
    {
      public virtual global::System.Threading.Tasks.Task GetGames(global::GamesN.Session_Id request, grpc::IServerStreamWriter<global::GamesN.Game> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GamesN.Game> ModifyGame(global::GamesN.GameID request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GamesN.Result> AddGame(global::GamesN.GameUID request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GamesN.Result> DeleteGame(global::GamesN.GameUID request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GamesN.Session_Id> Login(global::GamesN.User request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GamesN.Result> Logout(global::GamesN.Session_Id request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GamesLibrary</summary>
    public partial class GamesLibraryClient : grpc::ClientBase<GamesLibraryClient>
    {
      /// <summary>Creates a new client for GamesLibrary</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GamesLibraryClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GamesLibrary that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GamesLibraryClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GamesLibraryClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GamesLibraryClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::GamesN.Game> GetGames(global::GamesN.Session_Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGames(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::GamesN.Game> GetGames(global::GamesN.Session_Id request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetGames, null, options, request);
      }
      public virtual global::GamesN.Game ModifyGame(global::GamesN.GameID request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ModifyGame(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GamesN.Game ModifyGame(global::GamesN.GameID request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ModifyGame, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GamesN.Game> ModifyGameAsync(global::GamesN.GameID request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ModifyGameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GamesN.Game> ModifyGameAsync(global::GamesN.GameID request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ModifyGame, null, options, request);
      }
      public virtual global::GamesN.Result AddGame(global::GamesN.GameUID request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddGame(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GamesN.Result AddGame(global::GamesN.GameUID request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddGame, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GamesN.Result> AddGameAsync(global::GamesN.GameUID request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddGameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GamesN.Result> AddGameAsync(global::GamesN.GameUID request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddGame, null, options, request);
      }
      public virtual global::GamesN.Result DeleteGame(global::GamesN.GameUID request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteGame(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GamesN.Result DeleteGame(global::GamesN.GameUID request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteGame, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GamesN.Result> DeleteGameAsync(global::GamesN.GameUID request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteGameAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GamesN.Result> DeleteGameAsync(global::GamesN.GameUID request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteGame, null, options, request);
      }
      public virtual global::GamesN.Session_Id Login(global::GamesN.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Login(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GamesN.Session_Id Login(global::GamesN.User request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Login, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GamesN.Session_Id> LoginAsync(global::GamesN.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LoginAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GamesN.Session_Id> LoginAsync(global::GamesN.User request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Login, null, options, request);
      }
      public virtual global::GamesN.Result Logout(global::GamesN.Session_Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Logout(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::GamesN.Result Logout(global::GamesN.Session_Id request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Logout, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::GamesN.Result> LogoutAsync(global::GamesN.Session_Id request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LogoutAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::GamesN.Result> LogoutAsync(global::GamesN.Session_Id request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Logout, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GamesLibraryClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GamesLibraryClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GamesLibraryBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetGames, serviceImpl.GetGames)
          .AddMethod(__Method_ModifyGame, serviceImpl.ModifyGame)
          .AddMethod(__Method_AddGame, serviceImpl.AddGame)
          .AddMethod(__Method_DeleteGame, serviceImpl.DeleteGame)
          .AddMethod(__Method_Login, serviceImpl.Login)
          .AddMethod(__Method_Logout, serviceImpl.Logout).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GamesLibraryBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetGames, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GamesN.Session_Id, global::GamesN.Game>(serviceImpl.GetGames));
      serviceBinder.AddMethod(__Method_ModifyGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GamesN.GameID, global::GamesN.Game>(serviceImpl.ModifyGame));
      serviceBinder.AddMethod(__Method_AddGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GamesN.GameUID, global::GamesN.Result>(serviceImpl.AddGame));
      serviceBinder.AddMethod(__Method_DeleteGame, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GamesN.GameUID, global::GamesN.Result>(serviceImpl.DeleteGame));
      serviceBinder.AddMethod(__Method_Login, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GamesN.User, global::GamesN.Session_Id>(serviceImpl.Login));
      serviceBinder.AddMethod(__Method_Logout, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GamesN.Session_Id, global::GamesN.Result>(serviceImpl.Logout));
    }

  }
}
#endregion
