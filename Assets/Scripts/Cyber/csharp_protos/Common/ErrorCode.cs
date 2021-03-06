// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/common/proto/error_code.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Common {

  /// <summary>Holder for reflection information generated from modules/common/proto/error_code.proto</summary>
  public static partial class ErrorCodeReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/common/proto/error_code.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ErrorCodeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVtb2R1bGVzL2NvbW1vbi9wcm90by9lcnJvcl9jb2RlLnByb3RvEg1hcG9s",
            "bG8uY29tbW9uIkUKCFN0YXR1c1BiEiwKCmVycm9yX2NvZGUYASABKA4yGC5h",
            "cG9sbG8uY29tbW9uLkVycm9yQ29kZRILCgNtc2cYAiABKAkqygcKCUVycm9y",
            "Q29kZRIGCgJPSxAAEhIKDUNPTlRST0xfRVJST1IQ6AcSFwoSQ09OVFJPTF9J",
            "TklUX0VSUk9SEOkHEhoKFUNPTlRST0xfQ09NUFVURV9FUlJPUhDqBxIRCgxD",
            "QU5CVVNfRVJST1IQ0A8SGgoVQ0FOX0NMSUVOVF9FUlJPUl9CQVNFELQQEigK",
            "I0NBTl9DTElFTlRfRVJST1JfT1BFTl9ERVZJQ0VfRkFJTEVEELUQEh8KGkNB",
            "Tl9DTElFTlRfRVJST1JfRlJBTUVfTlVNELYQEiEKHENBTl9DTElFTlRfRVJS",
            "T1JfU0VORF9GQUlMRUQQtxASIQocQ0FOX0NMSUVOVF9FUlJPUl9SRUNWX0ZB",
            "SUxFRBC4EBIXChJMT0NBTElaQVRJT05fRVJST1IQuBcSGwoWTE9DQUxJWkFU",
            "SU9OX0VSUk9SX01TRxCcGBIdChhMT0NBTElaQVRJT05fRVJST1JfTElEQVIQ",
            "gBkSHQoYTE9DQUxJWkFUSU9OX0VSUk9SX0lOVEVHEOQZEhwKF0xPQ0FMSVpB",
            "VElPTl9FUlJPUl9HTlNTEMgaEhUKEFBFUkNFUFRJT05fRVJST1IQoB8SGAoT",
            "UEVSQ0VQVElPTl9FUlJPUl9URhChHxIdChhQRVJDRVBUSU9OX0VSUk9SX1BS",
            "T0NFU1MQoh8SFQoQUEVSQ0VQVElPTl9GQVRBTBCjHxIaChVQRVJDRVBUSU9O",
            "X0VSUk9SX05PTkUQpB8SHQoYUEVSQ0VQVElPTl9FUlJPUl9VTktOT1dOEKUf",
            "EhUKEFBSRURJQ1RJT05fRVJST1IQiCcSEwoOUExBTk5JTkdfRVJST1IQ8C4S",
            "HQoYUExBTk5JTkdfRVJST1JfTk9UX1JFQURZEPEuEhUKEEhETUFQX0RBVEFf",
            "RVJST1IQ2DYSEgoNUk9VVElOR19FUlJPUhDAPhIaChVST1VUSU5HX0VSUk9S",
            "X1JFUVVFU1QQwT4SGwoWUk9VVElOR19FUlJPUl9SRVNQT05TRRDCPhIcChdS",
            "T1VUSU5HX0VSUk9SX05PVF9SRUFEWRDDPhIRCgxFTkRfT0ZfSU5QVVQQqEYS",
            "FQoQSFRUUF9MT0dJQ19FUlJPUhCQThIXChJIVFRQX1JVTlRJTUVfRVJST1IQ",
            "kU4SFwoSUkVMQVRJVkVfTUFQX0VSUk9SEPhVEhsKFlJFTEFUSVZFX01BUF9O",
            "T1RfUkVBRFkQ+VUSFgoRRFJJVkVSX0VSUk9SX0dOU1MQ4F0SGgoVRFJJVkVS",
            "X0VSUk9SX1ZFTE9EWU5FEMhlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Apollo.Common.ErrorCode), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Common.StatusPb), global::Apollo.Common.StatusPb.Parser, new[]{ "ErrorCode", "Msg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Error codes enum for API's categorized by modules.
  /// </summary>
  public enum ErrorCode {
    /// <summary>
    /// No error, reutrns on success.
    /// </summary>
    [pbr::OriginalName("OK")] Ok = 0,
    /// <summary>
    /// Control module error codes start from here.
    /// </summary>
    [pbr::OriginalName("CONTROL_ERROR")] ControlError = 1000,
    [pbr::OriginalName("CONTROL_INIT_ERROR")] ControlInitError = 1001,
    [pbr::OriginalName("CONTROL_COMPUTE_ERROR")] ControlComputeError = 1002,
    /// <summary>
    /// Canbus module error codes start from here.
    /// </summary>
    [pbr::OriginalName("CANBUS_ERROR")] CanbusError = 2000,
    [pbr::OriginalName("CAN_CLIENT_ERROR_BASE")] CanClientErrorBase = 2100,
    [pbr::OriginalName("CAN_CLIENT_ERROR_OPEN_DEVICE_FAILED")] CanClientErrorOpenDeviceFailed = 2101,
    [pbr::OriginalName("CAN_CLIENT_ERROR_FRAME_NUM")] CanClientErrorFrameNum = 2102,
    [pbr::OriginalName("CAN_CLIENT_ERROR_SEND_FAILED")] CanClientErrorSendFailed = 2103,
    [pbr::OriginalName("CAN_CLIENT_ERROR_RECV_FAILED")] CanClientErrorRecvFailed = 2104,
    /// <summary>
    /// Localization module error codes start from here.
    /// </summary>
    [pbr::OriginalName("LOCALIZATION_ERROR")] LocalizationError = 3000,
    [pbr::OriginalName("LOCALIZATION_ERROR_MSG")] LocalizationErrorMsg = 3100,
    [pbr::OriginalName("LOCALIZATION_ERROR_LIDAR")] LocalizationErrorLidar = 3200,
    [pbr::OriginalName("LOCALIZATION_ERROR_INTEG")] LocalizationErrorInteg = 3300,
    [pbr::OriginalName("LOCALIZATION_ERROR_GNSS")] LocalizationErrorGnss = 3400,
    /// <summary>
    /// Perception module error codes start from here.
    /// </summary>
    [pbr::OriginalName("PERCEPTION_ERROR")] PerceptionError = 4000,
    [pbr::OriginalName("PERCEPTION_ERROR_TF")] PerceptionErrorTf = 4001,
    [pbr::OriginalName("PERCEPTION_ERROR_PROCESS")] PerceptionErrorProcess = 4002,
    [pbr::OriginalName("PERCEPTION_FATAL")] PerceptionFatal = 4003,
    [pbr::OriginalName("PERCEPTION_ERROR_NONE")] PerceptionErrorNone = 4004,
    [pbr::OriginalName("PERCEPTION_ERROR_UNKNOWN")] PerceptionErrorUnknown = 4005,
    /// <summary>
    /// Prediction module error codes start from here.
    /// </summary>
    [pbr::OriginalName("PREDICTION_ERROR")] PredictionError = 5000,
    /// <summary>
    /// Planning module error codes start from here
    /// </summary>
    [pbr::OriginalName("PLANNING_ERROR")] PlanningError = 6000,
    [pbr::OriginalName("PLANNING_ERROR_NOT_READY")] PlanningErrorNotReady = 6001,
    /// <summary>
    /// HDMap module error codes start from here
    /// </summary>
    [pbr::OriginalName("HDMAP_DATA_ERROR")] HdmapDataError = 7000,
    /// <summary>
    /// Routing module error codes
    /// </summary>
    [pbr::OriginalName("ROUTING_ERROR")] RoutingError = 8000,
    [pbr::OriginalName("ROUTING_ERROR_REQUEST")] RoutingErrorRequest = 8001,
    [pbr::OriginalName("ROUTING_ERROR_RESPONSE")] RoutingErrorResponse = 8002,
    [pbr::OriginalName("ROUTING_ERROR_NOT_READY")] RoutingErrorNotReady = 8003,
    /// <summary>
    /// Indicates an input has been exhausted.
    /// </summary>
    [pbr::OriginalName("END_OF_INPUT")] EndOfInput = 9000,
    /// <summary>
    /// HTTP request error codes.
    /// </summary>
    [pbr::OriginalName("HTTP_LOGIC_ERROR")] HttpLogicError = 10000,
    [pbr::OriginalName("HTTP_RUNTIME_ERROR")] HttpRuntimeError = 10001,
    /// <summary>
    /// Relative Map error codes.
    /// </summary>
    [pbr::OriginalName("RELATIVE_MAP_ERROR")] RelativeMapError = 11000,
    [pbr::OriginalName("RELATIVE_MAP_NOT_READY")] RelativeMapNotReady = 11001,
    /// <summary>
    /// Driver error codes.
    /// </summary>
    [pbr::OriginalName("DRIVER_ERROR_GNSS")] DriverErrorGnss = 12000,
    [pbr::OriginalName("DRIVER_ERROR_VELODYNE")] DriverErrorVelodyne = 13000,
  }

  #endregion

  #region Messages
  public sealed partial class StatusPb : pb::IMessage<StatusPb> {
    private static readonly pb::MessageParser<StatusPb> _parser = new pb::MessageParser<StatusPb>(() => new StatusPb());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StatusPb> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Common.ErrorCodeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatusPb() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatusPb(StatusPb other) : this() {
      errorCode_ = other.errorCode_;
      msg_ = other.msg_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatusPb Clone() {
      return new StatusPb(this);
    }

    /// <summary>Field number for the "error_code" field.</summary>
    public const int ErrorCodeFieldNumber = 1;
    private global::Apollo.Common.ErrorCode errorCode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.ErrorCode ErrorCode {
      get { return errorCode_; }
      set {
        errorCode_ = value;
      }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 2;
    private string msg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StatusPb);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StatusPb other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ErrorCode != other.ErrorCode) return false;
      if (Msg != other.Msg) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ErrorCode != 0) hash ^= ErrorCode.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ErrorCode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ErrorCode);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Msg);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ErrorCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ErrorCode);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StatusPb other) {
      if (other == null) {
        return;
      }
      if (other.ErrorCode != 0) {
        ErrorCode = other.ErrorCode;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
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
            errorCode_ = (global::Apollo.Common.ErrorCode) input.ReadEnum();
            break;
          }
          case 18: {
            Msg = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
