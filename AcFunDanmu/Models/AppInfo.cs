// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AppInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from AppInfo.proto</summary>
  public static partial class AppInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AppInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AppInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1BcHBJbmZvLnByb3RvEgpBY0Z1bkRhbm11IssBCgdBcHBJbmZvEg8KB2Fw",
            "cE5hbWUYASABKAkSEgoKYXBwVmVyc2lvbhgCIAEoCRISCgphcHBDaGFubmVs",
            "GAMgASgJEhIKCnNka1ZlcnNpb24YBCABKAkSPQoNZXh0ZW5zaW9uSW5mbxgL",
            "IAMoCzImLkFjRnVuRGFubXUuQXBwSW5mby5FeHRlbnNpb25JbmZvRW50cnka",
            "NAoSRXh0ZW5zaW9uSW5mb0VudHJ5EgsKA2tleRgBIAEoCRINCgV2YWx1ZRgC",
            "IAEoCToCOAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.AppInfo), global::AcFunDanmu.AppInfo.Parser, new[]{ "AppName", "AppVersion", "AppChannel", "SdkVersion", "ExtensionInfo" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AppInfo : pb::IMessage<AppInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AppInfo> _parser = new pb::MessageParser<AppInfo>(() => new AppInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.AppInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppInfo(AppInfo other) : this() {
      appName_ = other.appName_;
      appVersion_ = other.appVersion_;
      appChannel_ = other.appChannel_;
      sdkVersion_ = other.sdkVersion_;
      extensionInfo_ = other.extensionInfo_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppInfo Clone() {
      return new AppInfo(this);
    }

    /// <summary>Field number for the "appName" field.</summary>
    public const int AppNameFieldNumber = 1;
    private string appName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppName {
      get { return appName_; }
      set {
        appName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "appVersion" field.</summary>
    public const int AppVersionFieldNumber = 2;
    private string appVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppVersion {
      get { return appVersion_; }
      set {
        appVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "appChannel" field.</summary>
    public const int AppChannelFieldNumber = 3;
    private string appChannel_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AppChannel {
      get { return appChannel_; }
      set {
        appChannel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sdkVersion" field.</summary>
    public const int SdkVersionFieldNumber = 4;
    private string sdkVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SdkVersion {
      get { return sdkVersion_; }
      set {
        sdkVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "extensionInfo" field.</summary>
    public const int ExtensionInfoFieldNumber = 11;
    private static readonly pbc::MapField<string, string>.Codec _map_extensionInfo_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 90);
    private readonly pbc::MapField<string, string> extensionInfo_ = new pbc::MapField<string, string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> ExtensionInfo {
      get { return extensionInfo_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AppName != other.AppName) return false;
      if (AppVersion != other.AppVersion) return false;
      if (AppChannel != other.AppChannel) return false;
      if (SdkVersion != other.SdkVersion) return false;
      if (!ExtensionInfo.Equals(other.ExtensionInfo)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AppName.Length != 0) hash ^= AppName.GetHashCode();
      if (AppVersion.Length != 0) hash ^= AppVersion.GetHashCode();
      if (AppChannel.Length != 0) hash ^= AppChannel.GetHashCode();
      if (SdkVersion.Length != 0) hash ^= SdkVersion.GetHashCode();
      hash ^= ExtensionInfo.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (AppName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AppName);
      }
      if (AppVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AppVersion);
      }
      if (AppChannel.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AppChannel);
      }
      if (SdkVersion.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(SdkVersion);
      }
      extensionInfo_.WriteTo(output, _map_extensionInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (AppName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AppName);
      }
      if (AppVersion.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AppVersion);
      }
      if (AppChannel.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AppChannel);
      }
      if (SdkVersion.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(SdkVersion);
      }
      extensionInfo_.WriteTo(ref output, _map_extensionInfo_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AppName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppName);
      }
      if (AppVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppVersion);
      }
      if (AppChannel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AppChannel);
      }
      if (SdkVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SdkVersion);
      }
      size += extensionInfo_.CalculateSize(_map_extensionInfo_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppInfo other) {
      if (other == null) {
        return;
      }
      if (other.AppName.Length != 0) {
        AppName = other.AppName;
      }
      if (other.AppVersion.Length != 0) {
        AppVersion = other.AppVersion;
      }
      if (other.AppChannel.Length != 0) {
        AppChannel = other.AppChannel;
      }
      if (other.SdkVersion.Length != 0) {
        SdkVersion = other.SdkVersion;
      }
      extensionInfo_.Add(other.extensionInfo_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            AppName = input.ReadString();
            break;
          }
          case 18: {
            AppVersion = input.ReadString();
            break;
          }
          case 26: {
            AppChannel = input.ReadString();
            break;
          }
          case 34: {
            SdkVersion = input.ReadString();
            break;
          }
          case 90: {
            extensionInfo_.AddEntriesFrom(input, _map_extensionInfo_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            AppName = input.ReadString();
            break;
          }
          case 18: {
            AppVersion = input.ReadString();
            break;
          }
          case 26: {
            AppChannel = input.ReadString();
            break;
          }
          case 34: {
            SdkVersion = input.ReadString();
            break;
          }
          case 90: {
            extensionInfo_.AddEntriesFrom(ref input, _map_extensionInfo_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
