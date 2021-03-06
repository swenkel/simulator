// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/drivers/gnss/proto/heading.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Drivers.Gnss {

  /// <summary>Holder for reflection information generated from modules/drivers/gnss/proto/heading.proto</summary>
  public static partial class HeadingReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/drivers/gnss/proto/heading.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HeadingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihtb2R1bGVzL2RyaXZlcnMvZ25zcy9wcm90by9oZWFkaW5nLnByb3RvEhNh",
            "cG9sbG8uZHJpdmVycy5nbnNzGiFtb2R1bGVzL2NvbW1vbi9wcm90by9oZWFk",
            "ZXIucHJvdG8ihwQKB0hlYWRpbmcSJQoGaGVhZGVyGAEgASgLMhUuYXBvbGxv",
            "LmNvbW1vbi5IZWFkZXISGAoQbWVhc3VyZW1lbnRfdGltZRgCIAEoARIXCg9z",
            "b2x1dGlvbl9zdGF0dXMYAyABKA0SFQoNcG9zaXRpb25fdHlwZRgEIAEoDRIX",
            "Cg9iYXNlbGluZV9sZW5ndGgYBSABKAISDwoHaGVhZGluZxgGIAEoAhINCgVw",
            "aXRjaBgHIAEoAhIQCghyZXNlcnZlZBgIIAEoAhIXCg9oZWFkaW5nX3N0ZF9k",
            "ZXYYCSABKAISFQoNcGl0Y2hfc3RkX2RldhgKIAEoAhISCgpzdGF0aW9uX2lk",
            "GAsgASgMEiAKGHNhdGVsbGl0ZV90cmFja2VkX251bWJlchgMIAEoDRIiChpz",
            "YXRlbGxpdGVfc291bHV0aW9uX251bWJlchgNIAEoDRIcChRzYXRlbGxpdGVf",
            "bnVtYmVyX29icxgOIAEoDRIeChZzYXRlbGxpdGVfbnVtYmVyX211bHRpGA8g",
            "ASgNEhcKD3NvbHV0aW9uX3NvdXJjZRgQIAEoDRIgChhleHRlbmRlZF9zb2x1",
            "dGlvbl9zdGF0dXMYESABKA0SHwoXZ2FsaWxlb19iZWlkb3Vfc2lnX21hc2sY",
            "EiABKA0SHAoUZ3BzX2dsb25hc3Nfc2lnX21hc2sYEyABKA1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Common.HeaderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Drivers.Gnss.Heading), global::Apollo.Drivers.Gnss.Heading.Parser, new[]{ "Header", "MeasurementTime", "SolutionStatus", "PositionType", "BaselineLength", "Heading_", "Pitch", "Reserved", "HeadingStdDev", "PitchStdDev", "StationId", "SatelliteTrackedNumber", "SatelliteSoulutionNumber", "SatelliteNumberObs", "SatelliteNumberMulti", "SolutionSource", "ExtendedSolutionStatus", "GalileoBeidouSigMask", "GpsGlonassSigMask" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Heading : pb::IMessage<Heading> {
    private static readonly pb::MessageParser<Heading> _parser = new pb::MessageParser<Heading>(() => new Heading());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Heading> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Drivers.Gnss.HeadingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Heading() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Heading(Heading other) : this() {
      Header = other.header_ != null ? other.Header.Clone() : null;
      measurementTime_ = other.measurementTime_;
      solutionStatus_ = other.solutionStatus_;
      positionType_ = other.positionType_;
      baselineLength_ = other.baselineLength_;
      heading_ = other.heading_;
      pitch_ = other.pitch_;
      reserved_ = other.reserved_;
      headingStdDev_ = other.headingStdDev_;
      pitchStdDev_ = other.pitchStdDev_;
      stationId_ = other.stationId_;
      satelliteTrackedNumber_ = other.satelliteTrackedNumber_;
      satelliteSoulutionNumber_ = other.satelliteSoulutionNumber_;
      satelliteNumberObs_ = other.satelliteNumberObs_;
      satelliteNumberMulti_ = other.satelliteNumberMulti_;
      solutionSource_ = other.solutionSource_;
      extendedSolutionStatus_ = other.extendedSolutionStatus_;
      galileoBeidouSigMask_ = other.galileoBeidouSigMask_;
      gpsGlonassSigMask_ = other.gpsGlonassSigMask_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Heading Clone() {
      return new Heading(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Apollo.Common.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "measurement_time" field.</summary>
    public const int MeasurementTimeFieldNumber = 2;
    private double measurementTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MeasurementTime {
      get { return measurementTime_; }
      set {
        measurementTime_ = value;
      }
    }

    /// <summary>Field number for the "solution_status" field.</summary>
    public const int SolutionStatusFieldNumber = 3;
    private uint solutionStatus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SolutionStatus {
      get { return solutionStatus_; }
      set {
        solutionStatus_ = value;
      }
    }

    /// <summary>Field number for the "position_type" field.</summary>
    public const int PositionTypeFieldNumber = 4;
    private uint positionType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint PositionType {
      get { return positionType_; }
      set {
        positionType_ = value;
      }
    }

    /// <summary>Field number for the "baseline_length" field.</summary>
    public const int BaselineLengthFieldNumber = 5;
    private float baselineLength_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float BaselineLength {
      get { return baselineLength_; }
      set {
        baselineLength_ = value;
      }
    }

    /// <summary>Field number for the "heading" field.</summary>
    public const int Heading_FieldNumber = 6;
    private float heading_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Heading_ {
      get { return heading_; }
      set {
        heading_ = value;
      }
    }

    /// <summary>Field number for the "pitch" field.</summary>
    public const int PitchFieldNumber = 7;
    private float pitch_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Pitch {
      get { return pitch_; }
      set {
        pitch_ = value;
      }
    }

    /// <summary>Field number for the "reserved" field.</summary>
    public const int ReservedFieldNumber = 8;
    private float reserved_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Reserved {
      get { return reserved_; }
      set {
        reserved_ = value;
      }
    }

    /// <summary>Field number for the "heading_std_dev" field.</summary>
    public const int HeadingStdDevFieldNumber = 9;
    private float headingStdDev_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float HeadingStdDev {
      get { return headingStdDev_; }
      set {
        headingStdDev_ = value;
      }
    }

    /// <summary>Field number for the "pitch_std_dev" field.</summary>
    public const int PitchStdDevFieldNumber = 10;
    private float pitchStdDev_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float PitchStdDev {
      get { return pitchStdDev_; }
      set {
        pitchStdDev_ = value;
      }
    }

    /// <summary>Field number for the "station_id" field.</summary>
    public const int StationIdFieldNumber = 11;
    private pb::ByteString stationId_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString StationId {
      get { return stationId_; }
      set {
        stationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "satellite_tracked_number" field.</summary>
    public const int SatelliteTrackedNumberFieldNumber = 12;
    private uint satelliteTrackedNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SatelliteTrackedNumber {
      get { return satelliteTrackedNumber_; }
      set {
        satelliteTrackedNumber_ = value;
      }
    }

    /// <summary>Field number for the "satellite_soulution_number" field.</summary>
    public const int SatelliteSoulutionNumberFieldNumber = 13;
    private uint satelliteSoulutionNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SatelliteSoulutionNumber {
      get { return satelliteSoulutionNumber_; }
      set {
        satelliteSoulutionNumber_ = value;
      }
    }

    /// <summary>Field number for the "satellite_number_obs" field.</summary>
    public const int SatelliteNumberObsFieldNumber = 14;
    private uint satelliteNumberObs_;
    /// <summary>
    /// Number of satellites above the elevation mask angle
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SatelliteNumberObs {
      get { return satelliteNumberObs_; }
      set {
        satelliteNumberObs_ = value;
      }
    }

    /// <summary>Field number for the "satellite_number_multi" field.</summary>
    public const int SatelliteNumberMultiFieldNumber = 15;
    private uint satelliteNumberMulti_;
    /// <summary>
    /// Number of satellites above the mask angle with L2
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SatelliteNumberMulti {
      get { return satelliteNumberMulti_; }
      set {
        satelliteNumberMulti_ = value;
      }
    }

    /// <summary>Field number for the "solution_source" field.</summary>
    public const int SolutionSourceFieldNumber = 16;
    private uint solutionSource_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint SolutionSource {
      get { return solutionSource_; }
      set {
        solutionSource_ = value;
      }
    }

    /// <summary>Field number for the "extended_solution_status" field.</summary>
    public const int ExtendedSolutionStatusFieldNumber = 17;
    private uint extendedSolutionStatus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint ExtendedSolutionStatus {
      get { return extendedSolutionStatus_; }
      set {
        extendedSolutionStatus_ = value;
      }
    }

    /// <summary>Field number for the "galileo_beidou_sig_mask" field.</summary>
    public const int GalileoBeidouSigMaskFieldNumber = 18;
    private uint galileoBeidouSigMask_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint GalileoBeidouSigMask {
      get { return galileoBeidouSigMask_; }
      set {
        galileoBeidouSigMask_ = value;
      }
    }

    /// <summary>Field number for the "gps_glonass_sig_mask" field.</summary>
    public const int GpsGlonassSigMaskFieldNumber = 19;
    private uint gpsGlonassSigMask_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint GpsGlonassSigMask {
      get { return gpsGlonassSigMask_; }
      set {
        gpsGlonassSigMask_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Heading);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Heading other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (MeasurementTime != other.MeasurementTime) return false;
      if (SolutionStatus != other.SolutionStatus) return false;
      if (PositionType != other.PositionType) return false;
      if (BaselineLength != other.BaselineLength) return false;
      if (Heading_ != other.Heading_) return false;
      if (Pitch != other.Pitch) return false;
      if (Reserved != other.Reserved) return false;
      if (HeadingStdDev != other.HeadingStdDev) return false;
      if (PitchStdDev != other.PitchStdDev) return false;
      if (StationId != other.StationId) return false;
      if (SatelliteTrackedNumber != other.SatelliteTrackedNumber) return false;
      if (SatelliteSoulutionNumber != other.SatelliteSoulutionNumber) return false;
      if (SatelliteNumberObs != other.SatelliteNumberObs) return false;
      if (SatelliteNumberMulti != other.SatelliteNumberMulti) return false;
      if (SolutionSource != other.SolutionSource) return false;
      if (ExtendedSolutionStatus != other.ExtendedSolutionStatus) return false;
      if (GalileoBeidouSigMask != other.GalileoBeidouSigMask) return false;
      if (GpsGlonassSigMask != other.GpsGlonassSigMask) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (MeasurementTime != 0D) hash ^= MeasurementTime.GetHashCode();
      if (SolutionStatus != 0) hash ^= SolutionStatus.GetHashCode();
      if (PositionType != 0) hash ^= PositionType.GetHashCode();
      if (BaselineLength != 0F) hash ^= BaselineLength.GetHashCode();
      if (Heading_ != 0F) hash ^= Heading_.GetHashCode();
      if (Pitch != 0F) hash ^= Pitch.GetHashCode();
      if (Reserved != 0F) hash ^= Reserved.GetHashCode();
      if (HeadingStdDev != 0F) hash ^= HeadingStdDev.GetHashCode();
      if (PitchStdDev != 0F) hash ^= PitchStdDev.GetHashCode();
      if (StationId.Length != 0) hash ^= StationId.GetHashCode();
      if (SatelliteTrackedNumber != 0) hash ^= SatelliteTrackedNumber.GetHashCode();
      if (SatelliteSoulutionNumber != 0) hash ^= SatelliteSoulutionNumber.GetHashCode();
      if (SatelliteNumberObs != 0) hash ^= SatelliteNumberObs.GetHashCode();
      if (SatelliteNumberMulti != 0) hash ^= SatelliteNumberMulti.GetHashCode();
      if (SolutionSource != 0) hash ^= SolutionSource.GetHashCode();
      if (ExtendedSolutionStatus != 0) hash ^= ExtendedSolutionStatus.GetHashCode();
      if (GalileoBeidouSigMask != 0) hash ^= GalileoBeidouSigMask.GetHashCode();
      if (GpsGlonassSigMask != 0) hash ^= GpsGlonassSigMask.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (MeasurementTime != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(MeasurementTime);
      }
      if (SolutionStatus != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(SolutionStatus);
      }
      if (PositionType != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(PositionType);
      }
      if (BaselineLength != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(BaselineLength);
      }
      if (Heading_ != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(Heading_);
      }
      if (Pitch != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(Pitch);
      }
      if (Reserved != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(Reserved);
      }
      if (HeadingStdDev != 0F) {
        output.WriteRawTag(77);
        output.WriteFloat(HeadingStdDev);
      }
      if (PitchStdDev != 0F) {
        output.WriteRawTag(85);
        output.WriteFloat(PitchStdDev);
      }
      if (StationId.Length != 0) {
        output.WriteRawTag(90);
        output.WriteBytes(StationId);
      }
      if (SatelliteTrackedNumber != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(SatelliteTrackedNumber);
      }
      if (SatelliteSoulutionNumber != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(SatelliteSoulutionNumber);
      }
      if (SatelliteNumberObs != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(SatelliteNumberObs);
      }
      if (SatelliteNumberMulti != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(SatelliteNumberMulti);
      }
      if (SolutionSource != 0) {
        output.WriteRawTag(128, 1);
        output.WriteUInt32(SolutionSource);
      }
      if (ExtendedSolutionStatus != 0) {
        output.WriteRawTag(136, 1);
        output.WriteUInt32(ExtendedSolutionStatus);
      }
      if (GalileoBeidouSigMask != 0) {
        output.WriteRawTag(144, 1);
        output.WriteUInt32(GalileoBeidouSigMask);
      }
      if (GpsGlonassSigMask != 0) {
        output.WriteRawTag(152, 1);
        output.WriteUInt32(GpsGlonassSigMask);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (MeasurementTime != 0D) {
        size += 1 + 8;
      }
      if (SolutionStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SolutionStatus);
      }
      if (PositionType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PositionType);
      }
      if (BaselineLength != 0F) {
        size += 1 + 4;
      }
      if (Heading_ != 0F) {
        size += 1 + 4;
      }
      if (Pitch != 0F) {
        size += 1 + 4;
      }
      if (Reserved != 0F) {
        size += 1 + 4;
      }
      if (HeadingStdDev != 0F) {
        size += 1 + 4;
      }
      if (PitchStdDev != 0F) {
        size += 1 + 4;
      }
      if (StationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(StationId);
      }
      if (SatelliteTrackedNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SatelliteTrackedNumber);
      }
      if (SatelliteSoulutionNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SatelliteSoulutionNumber);
      }
      if (SatelliteNumberObs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SatelliteNumberObs);
      }
      if (SatelliteNumberMulti != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SatelliteNumberMulti);
      }
      if (SolutionSource != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(SolutionSource);
      }
      if (ExtendedSolutionStatus != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(ExtendedSolutionStatus);
      }
      if (GalileoBeidouSigMask != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(GalileoBeidouSigMask);
      }
      if (GpsGlonassSigMask != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(GpsGlonassSigMask);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Heading other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          header_ = new global::Apollo.Common.Header();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.MeasurementTime != 0D) {
        MeasurementTime = other.MeasurementTime;
      }
      if (other.SolutionStatus != 0) {
        SolutionStatus = other.SolutionStatus;
      }
      if (other.PositionType != 0) {
        PositionType = other.PositionType;
      }
      if (other.BaselineLength != 0F) {
        BaselineLength = other.BaselineLength;
      }
      if (other.Heading_ != 0F) {
        Heading_ = other.Heading_;
      }
      if (other.Pitch != 0F) {
        Pitch = other.Pitch;
      }
      if (other.Reserved != 0F) {
        Reserved = other.Reserved;
      }
      if (other.HeadingStdDev != 0F) {
        HeadingStdDev = other.HeadingStdDev;
      }
      if (other.PitchStdDev != 0F) {
        PitchStdDev = other.PitchStdDev;
      }
      if (other.StationId.Length != 0) {
        StationId = other.StationId;
      }
      if (other.SatelliteTrackedNumber != 0) {
        SatelliteTrackedNumber = other.SatelliteTrackedNumber;
      }
      if (other.SatelliteSoulutionNumber != 0) {
        SatelliteSoulutionNumber = other.SatelliteSoulutionNumber;
      }
      if (other.SatelliteNumberObs != 0) {
        SatelliteNumberObs = other.SatelliteNumberObs;
      }
      if (other.SatelliteNumberMulti != 0) {
        SatelliteNumberMulti = other.SatelliteNumberMulti;
      }
      if (other.SolutionSource != 0) {
        SolutionSource = other.SolutionSource;
      }
      if (other.ExtendedSolutionStatus != 0) {
        ExtendedSolutionStatus = other.ExtendedSolutionStatus;
      }
      if (other.GalileoBeidouSigMask != 0) {
        GalileoBeidouSigMask = other.GalileoBeidouSigMask;
      }
      if (other.GpsGlonassSigMask != 0) {
        GpsGlonassSigMask = other.GpsGlonassSigMask;
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
          case 10: {
            if (header_ == null) {
              header_ = new global::Apollo.Common.Header();
            }
            input.ReadMessage(header_);
            break;
          }
          case 17: {
            MeasurementTime = input.ReadDouble();
            break;
          }
          case 24: {
            SolutionStatus = input.ReadUInt32();
            break;
          }
          case 32: {
            PositionType = input.ReadUInt32();
            break;
          }
          case 45: {
            BaselineLength = input.ReadFloat();
            break;
          }
          case 53: {
            Heading_ = input.ReadFloat();
            break;
          }
          case 61: {
            Pitch = input.ReadFloat();
            break;
          }
          case 69: {
            Reserved = input.ReadFloat();
            break;
          }
          case 77: {
            HeadingStdDev = input.ReadFloat();
            break;
          }
          case 85: {
            PitchStdDev = input.ReadFloat();
            break;
          }
          case 90: {
            StationId = input.ReadBytes();
            break;
          }
          case 96: {
            SatelliteTrackedNumber = input.ReadUInt32();
            break;
          }
          case 104: {
            SatelliteSoulutionNumber = input.ReadUInt32();
            break;
          }
          case 112: {
            SatelliteNumberObs = input.ReadUInt32();
            break;
          }
          case 120: {
            SatelliteNumberMulti = input.ReadUInt32();
            break;
          }
          case 128: {
            SolutionSource = input.ReadUInt32();
            break;
          }
          case 136: {
            ExtendedSolutionStatus = input.ReadUInt32();
            break;
          }
          case 144: {
            GalileoBeidouSigMask = input.ReadUInt32();
            break;
          }
          case 152: {
            GpsGlonassSigMask = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
