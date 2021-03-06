// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/v2x/proto/v2x_service_obu_to_car.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.V2X {

  /// <summary>Holder for reflection information generated from modules/v2x/proto/v2x_service_obu_to_car.proto</summary>
  public static partial class V2XServiceObuToCarReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/v2x/proto/v2x_service_obu_to_car.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static V2XServiceObuToCarReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5tb2R1bGVzL3YyeC9wcm90by92Mnhfc2VydmljZV9vYnVfdG9fY2FyLnBy",
            "b3RvEgphcG9sbG8udjJ4GjJtb2R1bGVzL3BlcmNlcHRpb24vcHJvdG8vcGVy",
            "Y2VwdGlvbl9vYnN0YWNsZS5wcm90bxopbW9kdWxlcy92MngvcHJvdG8vdjJ4",
            "X3RyYWZmaWNfbGlnaHQucHJvdG8iQgoOU3RhdHVzUmVzcG9uc2USDgoGc3Rh",
            "dHVzGAEgASgIEgwKBGluZm8YAiABKAkSEgoKZXJyb3JfY29kZRgDIAEoAzLK",
            "AQoIT2J1VG9DYXISXwoXU2VuZFBlcmNlcHRpb25PYnN0YWNsZXMSJi5hcG9s",
            "bG8ucGVyY2VwdGlvbi5QZXJjZXB0aW9uT2JzdGFjbGVzGhouYXBvbGxvLnYy",
            "eC5TdGF0dXNSZXNwb25zZSIAEl0KE1NlbmRWMnhUcmFmZmljTGlnaHQSKC5h",
            "cG9sbG8udjJ4LkludGVyc2VjdGlvblRyYWZmaWNMaWdodERhdGEaGi5hcG9s",
            "bG8udjJ4LlN0YXR1c1Jlc3BvbnNlIgBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Perception.PerceptionObstacleReflection.Descriptor, global::Apollo.V2X.V2XTrafficLightReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.V2X.StatusResponse), global::Apollo.V2X.StatusResponse.Parser, new[]{ "Status", "Info", "ErrorCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The response message containing the status.
  /// </summary>
  public sealed partial class StatusResponse : pb::IMessage<StatusResponse> {
    private static readonly pb::MessageParser<StatusResponse> _parser = new pb::MessageParser<StatusResponse>(() => new StatusResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StatusResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.V2X.V2XServiceObuToCarReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatusResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatusResponse(StatusResponse other) : this() {
      status_ = other.status_;
      info_ = other.info_;
      errorCode_ = other.errorCode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatusResponse Clone() {
      return new StatusResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private bool status_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 2;
    private string info_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Info {
      get { return info_; }
      set {
        info_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "error_code" field.</summary>
    public const int ErrorCodeFieldNumber = 3;
    private long errorCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ErrorCode {
      get { return errorCode_; }
      set {
        errorCode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StatusResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StatusResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (Info != other.Info) return false;
      if (ErrorCode != other.ErrorCode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != false) hash ^= Status.GetHashCode();
      if (Info.Length != 0) hash ^= Info.GetHashCode();
      if (ErrorCode != 0L) hash ^= ErrorCode.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Status != false) {
        output.WriteRawTag(8);
        output.WriteBool(Status);
      }
      if (Info.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Info);
      }
      if (ErrorCode != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ErrorCode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != false) {
        size += 1 + 1;
      }
      if (Info.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Info);
      }
      if (ErrorCode != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ErrorCode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StatusResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != false) {
        Status = other.Status;
      }
      if (other.Info.Length != 0) {
        Info = other.Info;
      }
      if (other.ErrorCode != 0L) {
        ErrorCode = other.ErrorCode;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Status = input.ReadBool();
            break;
          }
          case 18: {
            Info = input.ReadString();
            break;
          }
          case 24: {
            ErrorCode = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
