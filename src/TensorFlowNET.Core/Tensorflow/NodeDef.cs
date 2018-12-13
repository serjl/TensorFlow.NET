// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: node_def.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from node_def.proto</summary>
  public static partial class NodeDefReflection {

    #region Descriptor
    /// <summary>File descriptor for node_def.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NodeDefReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg5ub2RlX2RlZi5wcm90bxIKdGVuc29yZmxvdxoQYXR0cl92YWx1ZS5wcm90",
            "byKzAQoHTm9kZURlZhIMCgRuYW1lGAEgASgJEgoKAm9wGAIgASgJEg0KBWlu",
            "cHV0GAMgAygJEg4KBmRldmljZRgEIAEoCRIrCgRhdHRyGAUgAygLMh0udGVu",
            "c29yZmxvdy5Ob2RlRGVmLkF0dHJFbnRyeRpCCglBdHRyRW50cnkSCwoDa2V5",
            "GAEgASgJEiQKBXZhbHVlGAIgASgLMhUudGVuc29yZmxvdy5BdHRyVmFsdWU6",
            "AjgBQmkKGG9yZy50ZW5zb3JmbG93LmZyYW1ld29ya0IJTm9kZVByb3RvUAFa",
            "PWdpdGh1Yi5jb20vdGVuc29yZmxvdy90ZW5zb3JmbG93L3RlbnNvcmZsb3cv",
            "Z28vY29yZS9mcmFtZXdvcmv4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.AttrValueReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.NodeDef), global::Tensorflow.NodeDef.Parser, new[]{ "Name", "Op", "Input", "Device", "Attr" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NodeDef : pb::IMessage<NodeDef> {
    private static readonly pb::MessageParser<NodeDef> _parser = new pb::MessageParser<NodeDef>(() => new NodeDef());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NodeDef> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.NodeDefReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NodeDef() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NodeDef(NodeDef other) : this() {
      name_ = other.name_;
      op_ = other.op_;
      input_ = other.input_.Clone();
      device_ = other.device_;
      attr_ = other.attr_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NodeDef Clone() {
      return new NodeDef(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name given to this operator. Used for naming inputs,
    /// logging, visualization, etc.  Unique within a single GraphDef.
    /// Must match the regexp "[A-Za-z0-9.][A-Za-z0-9_./]*".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "op" field.</summary>
    public const int OpFieldNumber = 2;
    private string op_ = "";
    /// <summary>
    /// The operation name.  There may be custom parameters in attrs.
    /// Op names starting with an underscore are reserved for internal use.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Op {
      get { return op_; }
      set {
        op_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "input" field.</summary>
    public const int InputFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_input_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> input_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Each input is "node:src_output" with "node" being a string name and
    /// "src_output" indicating which output tensor to use from "node". If
    /// "src_output" is 0 the ":0" suffix can be omitted.  Regular inputs
    /// may optionally be followed by control inputs that have the format
    /// "^node".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Input {
      get { return input_; }
    }

    /// <summary>Field number for the "device" field.</summary>
    public const int DeviceFieldNumber = 4;
    private string device_ = "";
    /// <summary>
    /// A (possibly partial) specification for the device on which this
    /// node should be placed.
    /// The expected syntax for this string is as follows:
    ///
    /// DEVICE_SPEC ::= PARTIAL_SPEC
    ///
    /// PARTIAL_SPEC ::= ("/" CONSTRAINT) *
    /// CONSTRAINT ::= ("job:" JOB_NAME)
    ///              | ("replica:" [1-9][0-9]*)
    ///              | ("task:" [1-9][0-9]*)
    ///              | ("device:" [A-Za-z]* ":" ([1-9][0-9]* | "*") )
    ///
    /// Valid values for this string include:
    /// * "/job:worker/replica:0/task:1/device:GPU:3"  (full specification)
    /// * "/job:worker/device:GPU:3"                   (partial specification)
    /// * ""                                    (no specification)
    ///
    /// If the constraints do not resolve to a single device (or if this
    /// field is empty or not present), the runtime will attempt to
    /// choose a device automatically.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Device {
      get { return device_; }
      set {
        device_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attr" field.</summary>
    public const int AttrFieldNumber = 5;
    private static readonly pbc::MapField<string, global::Tensorflow.AttrValue>.Codec _map_attr_codec
        = new pbc::MapField<string, global::Tensorflow.AttrValue>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::Tensorflow.AttrValue.Parser), 42);
    private readonly pbc::MapField<string, global::Tensorflow.AttrValue> attr_ = new pbc::MapField<string, global::Tensorflow.AttrValue>();
    /// <summary>
    /// Operation-specific graph-construction-time configuration.
    /// Note that this should include all attrs defined in the
    /// corresponding OpDef, including those with a value matching
    /// the default -- this allows the default to change and makes
    /// NodeDefs easier to interpret on their own.  However, if
    /// an attr with a default is not specified in this list, the
    /// default will be used.
    /// The "names" (keys) must match the regexp "[a-z][a-z0-9_]+" (and
    /// one of the names from the corresponding OpDef's attr field).
    /// The values must have a type matching the corresponding OpDef
    /// attr's type field.
    /// TODO(josh11b): Add some examples here showing best practices.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Tensorflow.AttrValue> Attr {
      get { return attr_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NodeDef);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NodeDef other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Op != other.Op) return false;
      if(!input_.Equals(other.input_)) return false;
      if (Device != other.Device) return false;
      if (!Attr.Equals(other.Attr)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Op.Length != 0) hash ^= Op.GetHashCode();
      hash ^= input_.GetHashCode();
      if (Device.Length != 0) hash ^= Device.GetHashCode();
      hash ^= Attr.GetHashCode();
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
      if (Op.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Op);
      }
      input_.WriteTo(output, _repeated_input_codec);
      if (Device.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Device);
      }
      attr_.WriteTo(output, _map_attr_codec);
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
      if (Op.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Op);
      }
      size += input_.CalculateSize(_repeated_input_codec);
      if (Device.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Device);
      }
      size += attr_.CalculateSize(_map_attr_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NodeDef other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Op.Length != 0) {
        Op = other.Op;
      }
      input_.Add(other.input_);
      if (other.Device.Length != 0) {
        Device = other.Device;
      }
      attr_.Add(other.attr_);
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
            Op = input.ReadString();
            break;
          }
          case 26: {
            input_.AddEntriesFrom(input, _repeated_input_codec);
            break;
          }
          case 34: {
            Device = input.ReadString();
            break;
          }
          case 42: {
            attr_.AddEntriesFrom(input, _map_attr_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
