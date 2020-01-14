// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gameN.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GamesN {

  /// <summary>Holder for reflection information generated from gameN.proto</summary>
  public static partial class GameNReflection {

    #region Descriptor
    /// <summary>File descriptor for gameN.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameNReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtnYW1lTi5wcm90bxIGZ2FtZXNOIiQKBFVzZXISDAoEbmFtZRgBIAEoCRIO",
            "CgZwYXNzd2QYAiABKAkiGAoKU2Vzc2lvbl9JZBIKCgJpZBgBIAEoCSIZCgZS",
            "ZXN1bHQSDwoHc3VjY2VzcxgBIAEoCSIwCgRHYW1lEgsKA2dpZBgBIAEoBRIM",
            "CgRuYW1lGAIgASgJEg0KBXByaWNlGAMgASgFIiEKBkdhbWVJRBIKCgJpZBgB",
            "IAEoBRILCgNnaWQYAiABKAUiQAoHR2FtZVVJRBILCgN1aWQYASABKAkSCwoD",
            "Z0lEGAIgASgFEgwKBG5hbWUYAyABKAkSDQoFcHJpY2UYBCABKAUyqgIKDEdh",
            "bWVzTGlicmFyeRIwCghHZXRHYW1lcxISLmdhbWVzTi5TZXNzaW9uX0lkGgwu",
            "Z2FtZXNOLkdhbWUiADABEiwKCk1vZGlmeUdhbWUSDi5nYW1lc04uR2FtZUlE",
            "GgwuZ2FtZXNOLkdhbWUiABIsCgdBZGRHYW1lEg8uZ2FtZXNOLkdhbWVVSUQa",
            "Di5nYW1lc04uUmVzdWx0IgASLwoKRGVsZXRlR2FtZRIPLmdhbWVzTi5HYW1l",
            "VUlEGg4uZ2FtZXNOLlJlc3VsdCIAEisKBUxvZ2luEgwuZ2FtZXNOLlVzZXIa",
            "Ei5nYW1lc04uU2Vzc2lvbl9JZCIAEi4KBkxvZ291dBISLmdhbWVzTi5TZXNz",
            "aW9uX0lkGg4uZ2FtZXNOLlJlc3VsdCIAQhgKEGlvLmdycGMuZXhhbXBsZXOi",
            "AgNITFdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GamesN.User), global::GamesN.User.Parser, new[]{ "Name", "Passwd" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GamesN.Session_Id), global::GamesN.Session_Id.Parser, new[]{ "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GamesN.Result), global::GamesN.Result.Parser, new[]{ "Success" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GamesN.Game), global::GamesN.Game.Parser, new[]{ "Gid", "Name", "Price" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GamesN.GameID), global::GamesN.GameID.Parser, new[]{ "Id", "Gid" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GamesN.GameUID), global::GamesN.GameUID.Parser, new[]{ "Uid", "GID", "Name", "Price" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class User : pb::IMessage<User> {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GamesN.GameNReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User(User other) : this() {
      name_ = other.name_;
      passwd_ = other.passwd_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "passwd" field.</summary>
    public const int PasswdFieldNumber = 2;
    private string passwd_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Passwd {
      get { return passwd_; }
      set {
        passwd_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Passwd != other.Passwd) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Passwd.Length != 0) hash ^= Passwd.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Passwd.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Passwd);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Passwd.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Passwd);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Passwd.Length != 0) {
        Passwd = other.Passwd;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Passwd = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Session_Id : pb::IMessage<Session_Id> {
    private static readonly pb::MessageParser<Session_Id> _parser = new pb::MessageParser<Session_Id>(() => new Session_Id());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Session_Id> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GamesN.GameNReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Session_Id() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Session_Id(Session_Id other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Session_Id Clone() {
      return new Session_Id(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Session_Id);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Session_Id other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Session_Id other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Result : pb::IMessage<Result> {
    private static readonly pb::MessageParser<Result> _parser = new pb::MessageParser<Result>(() => new Result());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Result> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GamesN.GameNReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Result() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Result(Result other) : this() {
      success_ = other.success_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Result Clone() {
      return new Result(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private string success_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Success {
      get { return success_; }
      set {
        success_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Result);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Result other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success.Length != 0) hash ^= Success.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Success.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Success);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Success);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Result other) {
      if (other == null) {
        return;
      }
      if (other.Success.Length != 0) {
        Success = other.Success;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Success = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Game : pb::IMessage<Game> {
    private static readonly pb::MessageParser<Game> _parser = new pb::MessageParser<Game>(() => new Game());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Game> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GamesN.GameNReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Game() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Game(Game other) : this() {
      gid_ = other.gid_;
      name_ = other.name_;
      price_ = other.price_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Game Clone() {
      return new Game(this);
    }

    /// <summary>Field number for the "gid" field.</summary>
    public const int GidFieldNumber = 1;
    private int gid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Gid {
      get { return gid_; }
      set {
        gid_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 3;
    private int price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Game);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Game other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Gid != other.Gid) return false;
      if (Name != other.Name) return false;
      if (Price != other.Price) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Gid != 0) hash ^= Gid.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Price != 0) hash ^= Price.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Gid != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Gid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Price != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Price);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Gid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Gid);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Price != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Price);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Game other) {
      if (other == null) {
        return;
      }
      if (other.Gid != 0) {
        Gid = other.Gid;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Price != 0) {
        Price = other.Price;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Gid = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Price = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GameID : pb::IMessage<GameID> {
    private static readonly pb::MessageParser<GameID> _parser = new pb::MessageParser<GameID>(() => new GameID());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameID> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GamesN.GameNReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameID() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameID(GameID other) : this() {
      id_ = other.id_;
      gid_ = other.gid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameID Clone() {
      return new GameID(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "gid" field.</summary>
    public const int GidFieldNumber = 2;
    private int gid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Gid {
      get { return gid_; }
      set {
        gid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameID);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameID other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Gid != other.Gid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Gid != 0) hash ^= Gid.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Gid != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Gid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Gid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Gid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameID other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Gid != 0) {
        Gid = other.Gid;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 16: {
            Gid = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GameUID : pb::IMessage<GameUID> {
    private static readonly pb::MessageParser<GameUID> _parser = new pb::MessageParser<GameUID>(() => new GameUID());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameUID> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GamesN.GameNReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameUID() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameUID(GameUID other) : this() {
      uid_ = other.uid_;
      gID_ = other.gID_;
      name_ = other.name_;
      price_ = other.price_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameUID Clone() {
      return new GameUID(this);
    }

    /// <summary>Field number for the "uid" field.</summary>
    public const int UidFieldNumber = 1;
    private string uid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uid {
      get { return uid_; }
      set {
        uid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "gID" field.</summary>
    public const int GIDFieldNumber = 2;
    private int gID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int GID {
      get { return gID_; }
      set {
        gID_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 4;
    private int price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameUID);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameUID other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uid != other.Uid) return false;
      if (GID != other.GID) return false;
      if (Name != other.Name) return false;
      if (Price != other.Price) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uid.Length != 0) hash ^= Uid.GetHashCode();
      if (GID != 0) hash ^= GID.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Price != 0) hash ^= Price.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Uid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uid);
      }
      if (GID != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(GID);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (Price != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Price);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uid);
      }
      if (GID != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(GID);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Price != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Price);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameUID other) {
      if (other == null) {
        return;
      }
      if (other.Uid.Length != 0) {
        Uid = other.Uid;
      }
      if (other.GID != 0) {
        GID = other.GID;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Price != 0) {
        Price = other.Price;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Uid = input.ReadString();
            break;
          }
          case 16: {
            GID = input.ReadInt32();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 32: {
            Price = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code