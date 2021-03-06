// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/prediction/proto/fnn_vehicle_model.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Prediction {

  /// <summary>Holder for reflection information generated from modules/prediction/proto/fnn_vehicle_model.proto</summary>
  public static partial class FnnVehicleModelReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/prediction/proto/fnn_vehicle_model.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FnnVehicleModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBtb2R1bGVzL3ByZWRpY3Rpb24vcHJvdG8vZm5uX3ZlaGljbGVfbW9kZWwu",
            "cHJvdG8SEWFwb2xsby5wcmVkaWN0aW9uGi1tb2R1bGVzL3ByZWRpY3Rpb24v",
            "cHJvdG8vZm5uX21vZGVsX2Jhc2UucHJvdG8i1QEKD0ZublZlaGljbGVNb2Rl",
            "bBIRCglkaW1faW5wdXQYASABKAUSLwoMc2FtcGxlc19tZWFuGAIgASgLMhku",
            "YXBvbGxvLnByZWRpY3Rpb24uVmVjdG9yEi4KC3NhbXBsZXNfc3RkGAMgASgL",
            "MhkuYXBvbGxvLnByZWRpY3Rpb24uVmVjdG9yEhEKCW51bV9sYXllchgEIAEo",
            "BRInCgVsYXllchgFIAMoCzIYLmFwb2xsby5wcmVkaWN0aW9uLkxheWVyEhIK",
            "CmRpbV9vdXRwdXQYBiABKAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Prediction.FnnModelBaseReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Prediction.FnnVehicleModel), global::Apollo.Prediction.FnnVehicleModel.Parser, new[]{ "DimInput", "SamplesMean", "SamplesStd", "NumLayer", "Layer", "DimOutput" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FnnVehicleModel : pb::IMessage<FnnVehicleModel> {
    private static readonly pb::MessageParser<FnnVehicleModel> _parser = new pb::MessageParser<FnnVehicleModel>(() => new FnnVehicleModel());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FnnVehicleModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Prediction.FnnVehicleModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FnnVehicleModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FnnVehicleModel(FnnVehicleModel other) : this() {
      dimInput_ = other.dimInput_;
      SamplesMean = other.samplesMean_ != null ? other.SamplesMean.Clone() : null;
      SamplesStd = other.samplesStd_ != null ? other.SamplesStd.Clone() : null;
      numLayer_ = other.numLayer_;
      layer_ = other.layer_.Clone();
      dimOutput_ = other.dimOutput_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FnnVehicleModel Clone() {
      return new FnnVehicleModel(this);
    }

    /// <summary>Field number for the "dim_input" field.</summary>
    public const int DimInputFieldNumber = 1;
    private int dimInput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DimInput {
      get { return dimInput_; }
      set {
        dimInput_ = value;
      }
    }

    /// <summary>Field number for the "samples_mean" field.</summary>
    public const int SamplesMeanFieldNumber = 2;
    private global::Apollo.Prediction.Vector samplesMean_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Prediction.Vector SamplesMean {
      get { return samplesMean_; }
      set {
        samplesMean_ = value;
      }
    }

    /// <summary>Field number for the "samples_std" field.</summary>
    public const int SamplesStdFieldNumber = 3;
    private global::Apollo.Prediction.Vector samplesStd_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Prediction.Vector SamplesStd {
      get { return samplesStd_; }
      set {
        samplesStd_ = value;
      }
    }

    /// <summary>Field number for the "num_layer" field.</summary>
    public const int NumLayerFieldNumber = 4;
    private int numLayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int NumLayer {
      get { return numLayer_; }
      set {
        numLayer_ = value;
      }
    }

    /// <summary>Field number for the "layer" field.</summary>
    public const int LayerFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Apollo.Prediction.Layer> _repeated_layer_codec
        = pb::FieldCodec.ForMessage(42, global::Apollo.Prediction.Layer.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Prediction.Layer> layer_ = new pbc::RepeatedField<global::Apollo.Prediction.Layer>();
    /// <summary>
    /// num_layer must equal to first layer layer_input_dim
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Prediction.Layer> Layer {
      get { return layer_; }
    }

    /// <summary>Field number for the "dim_output" field.</summary>
    public const int DimOutputFieldNumber = 6;
    private int dimOutput_;
    /// <summary>
    /// dim_ouput must equal to last layer layer_output_dim
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DimOutput {
      get { return dimOutput_; }
      set {
        dimOutput_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FnnVehicleModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FnnVehicleModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DimInput != other.DimInput) return false;
      if (!object.Equals(SamplesMean, other.SamplesMean)) return false;
      if (!object.Equals(SamplesStd, other.SamplesStd)) return false;
      if (NumLayer != other.NumLayer) return false;
      if(!layer_.Equals(other.layer_)) return false;
      if (DimOutput != other.DimOutput) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DimInput != 0) hash ^= DimInput.GetHashCode();
      if (samplesMean_ != null) hash ^= SamplesMean.GetHashCode();
      if (samplesStd_ != null) hash ^= SamplesStd.GetHashCode();
      if (NumLayer != 0) hash ^= NumLayer.GetHashCode();
      hash ^= layer_.GetHashCode();
      if (DimOutput != 0) hash ^= DimOutput.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (DimInput != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(DimInput);
      }
      if (samplesMean_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SamplesMean);
      }
      if (samplesStd_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SamplesStd);
      }
      if (NumLayer != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(NumLayer);
      }
      layer_.WriteTo(output, _repeated_layer_codec);
      if (DimOutput != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(DimOutput);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DimInput != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DimInput);
      }
      if (samplesMean_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SamplesMean);
      }
      if (samplesStd_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SamplesStd);
      }
      if (NumLayer != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumLayer);
      }
      size += layer_.CalculateSize(_repeated_layer_codec);
      if (DimOutput != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DimOutput);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FnnVehicleModel other) {
      if (other == null) {
        return;
      }
      if (other.DimInput != 0) {
        DimInput = other.DimInput;
      }
      if (other.samplesMean_ != null) {
        if (samplesMean_ == null) {
          samplesMean_ = new global::Apollo.Prediction.Vector();
        }
        SamplesMean.MergeFrom(other.SamplesMean);
      }
      if (other.samplesStd_ != null) {
        if (samplesStd_ == null) {
          samplesStd_ = new global::Apollo.Prediction.Vector();
        }
        SamplesStd.MergeFrom(other.SamplesStd);
      }
      if (other.NumLayer != 0) {
        NumLayer = other.NumLayer;
      }
      layer_.Add(other.layer_);
      if (other.DimOutput != 0) {
        DimOutput = other.DimOutput;
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
            DimInput = input.ReadInt32();
            break;
          }
          case 18: {
            if (samplesMean_ == null) {
              samplesMean_ = new global::Apollo.Prediction.Vector();
            }
            input.ReadMessage(samplesMean_);
            break;
          }
          case 26: {
            if (samplesStd_ == null) {
              samplesStd_ = new global::Apollo.Prediction.Vector();
            }
            input.ReadMessage(samplesStd_);
            break;
          }
          case 32: {
            NumLayer = input.ReadInt32();
            break;
          }
          case 42: {
            layer_.AddEntriesFrom(input, _repeated_layer_codec);
            break;
          }
          case 48: {
            DimOutput = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
