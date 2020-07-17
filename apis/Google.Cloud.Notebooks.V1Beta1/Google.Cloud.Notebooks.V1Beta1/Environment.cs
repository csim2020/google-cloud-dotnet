// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/notebooks/v1beta1/environment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Notebooks.V1Beta1 {

  /// <summary>Holder for reflection information generated from google/cloud/notebooks/v1beta1/environment.proto</summary>
  public static partial class EnvironmentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/notebooks/v1beta1/environment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnvironmentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvY2xvdWQvbm90ZWJvb2tzL3YxYmV0YTEvZW52aXJvbm1lbnQu",
            "cHJvdG8SHmdvb2dsZS5jbG91ZC5ub3RlYm9va3MudjFiZXRhMRofZ29vZ2xl",
            "L2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJj",
            "ZS5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90bxocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKOAwoLRW52aXJvbm1lbnQSEQoE",
            "bmFtZRgBIAEoCUID4EEDEhQKDGRpc3BsYXlfbmFtZRgCIAEoCRITCgtkZXNj",
            "cmlwdGlvbhgDIAEoCRI7Cgh2bV9pbWFnZRgGIAEoCzInLmdvb2dsZS5jbG91",
            "ZC5ub3RlYm9va3MudjFiZXRhMS5WbUltYWdlSAASSQoPY29udGFpbmVyX2lt",
            "YWdlGAcgASgLMi4uZ29vZ2xlLmNsb3VkLm5vdGVib29rcy52MWJldGExLkNv",
            "bnRhaW5lckltYWdlSAASGwoTcG9zdF9zdGFydHVwX3NjcmlwdBgIIAEoCRI0",
            "CgtjcmVhdGVfdGltZRgJIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3Rh",
            "bXBCA+BBAzpY6kFVCiRub3RlYm9va3MuZ29vZ2xlYXBpcy5jb20vRW52aXJv",
            "bm1lbnQSLXByb2plY3RzL3twcm9qZWN0fS9lbnZpcm9ubWVudHMve2Vudmly",
            "b25tZW50fUIMCgppbWFnZV90eXBlIlYKB1ZtSW1hZ2USFAoHcHJvamVjdBgB",
            "IAEoCUID4EECEhQKCmltYWdlX25hbWUYAiABKAlIABIWCgxpbWFnZV9mYW1p",
            "bHkYAyABKAlIAEIHCgVpbWFnZSI2Cg5Db250YWluZXJJbWFnZRIXCgpyZXBv",
            "c2l0b3J5GAEgASgJQgPgQQISCwoDdGFnGAIgASgJQucBCiJjb20uZ29vZ2xl",
            "LmNsb3VkLm5vdGVib29rcy52MWJldGExQhBFbnZpcm9ubWVudFByb3RvUAFa",
            "R2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQv",
            "bm90ZWJvb2tzL3YxYmV0YTE7bm90ZWJvb2tzqgIeR29vZ2xlLkNsb3VkLk5v",
            "dGVib29rcy5WMUJldGExygIeR29vZ2xlXENsb3VkXE5vdGVib29rc1xWMUJl",
            "dGEx6gIhR29vZ2xlOjpDbG91ZDo6Tm90ZWJvb2tzOjpWMUJldGExYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Notebooks.V1Beta1.Environment), global::Google.Cloud.Notebooks.V1Beta1.Environment.Parser, new[]{ "Name", "DisplayName", "Description", "VmImage", "ContainerImage", "PostStartupScript", "CreateTime" }, new[]{ "ImageType" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Notebooks.V1Beta1.VmImage), global::Google.Cloud.Notebooks.V1Beta1.VmImage.Parser, new[]{ "Project", "ImageName", "ImageFamily" }, new[]{ "Image" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Notebooks.V1Beta1.ContainerImage), global::Google.Cloud.Notebooks.V1Beta1.ContainerImage.Parser, new[]{ "Repository", "Tag" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Definition of a software environment that is used to start a notebook
  /// instance.
  /// </summary>
  public sealed partial class Environment : pb::IMessage<Environment> {
    private static readonly pb::MessageParser<Environment> _parser = new pb::MessageParser<Environment>(() => new Environment());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Environment> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Notebooks.V1Beta1.EnvironmentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Environment() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Environment(Environment other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      postStartupScript_ = other.postStartupScript_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      switch (other.ImageTypeCase) {
        case ImageTypeOneofCase.VmImage:
          VmImage = other.VmImage.Clone();
          break;
        case ImageTypeOneofCase.ContainerImage:
          ContainerImage = other.ContainerImage.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Environment Clone() {
      return new Environment(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. Name of this environment.
    /// Format:
    /// `projects/{project_id}/locations/{location}/environments/{environment_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Display name of this environment for the UI.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 3;
    private string description_ = "";
    /// <summary>
    /// A brief description of this environment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "vm_image" field.</summary>
    public const int VmImageFieldNumber = 6;
    /// <summary>
    /// Use a Compute Engine VM image to start the notebook instance.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Notebooks.V1Beta1.VmImage VmImage {
      get { return imageTypeCase_ == ImageTypeOneofCase.VmImage ? (global::Google.Cloud.Notebooks.V1Beta1.VmImage) imageType_ : null; }
      set {
        imageType_ = value;
        imageTypeCase_ = value == null ? ImageTypeOneofCase.None : ImageTypeOneofCase.VmImage;
      }
    }

    /// <summary>Field number for the "container_image" field.</summary>
    public const int ContainerImageFieldNumber = 7;
    /// <summary>
    /// Use a container image to start the notebook instance.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Notebooks.V1Beta1.ContainerImage ContainerImage {
      get { return imageTypeCase_ == ImageTypeOneofCase.ContainerImage ? (global::Google.Cloud.Notebooks.V1Beta1.ContainerImage) imageType_ : null; }
      set {
        imageType_ = value;
        imageTypeCase_ = value == null ? ImageTypeOneofCase.None : ImageTypeOneofCase.ContainerImage;
      }
    }

    /// <summary>Field number for the "post_startup_script" field.</summary>
    public const int PostStartupScriptFieldNumber = 8;
    private string postStartupScript_ = "";
    /// <summary>
    /// Path to a Bash script that automatically runs after a notebook instance
    /// fully boots up. The path must be a URL or
    /// Cloud Storage path. Example: `"gs://path-to-file/file-name"`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PostStartupScript {
      get { return postStartupScript_; }
      set {
        postStartupScript_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 9;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. The time at which this environment was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    private object imageType_;
    /// <summary>Enum of possible cases for the "image_type" oneof.</summary>
    public enum ImageTypeOneofCase {
      None = 0,
      VmImage = 6,
      ContainerImage = 7,
    }
    private ImageTypeOneofCase imageTypeCase_ = ImageTypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageTypeOneofCase ImageTypeCase {
      get { return imageTypeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearImageType() {
      imageTypeCase_ = ImageTypeOneofCase.None;
      imageType_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Environment);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Environment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      if (!object.Equals(VmImage, other.VmImage)) return false;
      if (!object.Equals(ContainerImage, other.ContainerImage)) return false;
      if (PostStartupScript != other.PostStartupScript) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (ImageTypeCase != other.ImageTypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (imageTypeCase_ == ImageTypeOneofCase.VmImage) hash ^= VmImage.GetHashCode();
      if (imageTypeCase_ == ImageTypeOneofCase.ContainerImage) hash ^= ContainerImage.GetHashCode();
      if (PostStartupScript.Length != 0) hash ^= PostStartupScript.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      hash ^= (int) imageTypeCase_;
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Description);
      }
      if (imageTypeCase_ == ImageTypeOneofCase.VmImage) {
        output.WriteRawTag(50);
        output.WriteMessage(VmImage);
      }
      if (imageTypeCase_ == ImageTypeOneofCase.ContainerImage) {
        output.WriteRawTag(58);
        output.WriteMessage(ContainerImage);
      }
      if (PostStartupScript.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(PostStartupScript);
      }
      if (createTime_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(CreateTime);
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
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (imageTypeCase_ == ImageTypeOneofCase.VmImage) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VmImage);
      }
      if (imageTypeCase_ == ImageTypeOneofCase.ContainerImage) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContainerImage);
      }
      if (PostStartupScript.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PostStartupScript);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Environment other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.PostStartupScript.Length != 0) {
        PostStartupScript = other.PostStartupScript;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      switch (other.ImageTypeCase) {
        case ImageTypeOneofCase.VmImage:
          if (VmImage == null) {
            VmImage = new global::Google.Cloud.Notebooks.V1Beta1.VmImage();
          }
          VmImage.MergeFrom(other.VmImage);
          break;
        case ImageTypeOneofCase.ContainerImage:
          if (ContainerImage == null) {
            ContainerImage = new global::Google.Cloud.Notebooks.V1Beta1.ContainerImage();
          }
          ContainerImage.MergeFrom(other.ContainerImage);
          break;
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
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            Description = input.ReadString();
            break;
          }
          case 50: {
            global::Google.Cloud.Notebooks.V1Beta1.VmImage subBuilder = new global::Google.Cloud.Notebooks.V1Beta1.VmImage();
            if (imageTypeCase_ == ImageTypeOneofCase.VmImage) {
              subBuilder.MergeFrom(VmImage);
            }
            input.ReadMessage(subBuilder);
            VmImage = subBuilder;
            break;
          }
          case 58: {
            global::Google.Cloud.Notebooks.V1Beta1.ContainerImage subBuilder = new global::Google.Cloud.Notebooks.V1Beta1.ContainerImage();
            if (imageTypeCase_ == ImageTypeOneofCase.ContainerImage) {
              subBuilder.MergeFrom(ContainerImage);
            }
            input.ReadMessage(subBuilder);
            ContainerImage = subBuilder;
            break;
          }
          case 66: {
            PostStartupScript = input.ReadString();
            break;
          }
          case 74: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Definition of a custom Compute Engine virtual machine image for starting a
  /// notebook instance with the environment installed directly on the VM.
  /// </summary>
  public sealed partial class VmImage : pb::IMessage<VmImage> {
    private static readonly pb::MessageParser<VmImage> _parser = new pb::MessageParser<VmImage>(() => new VmImage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VmImage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Notebooks.V1Beta1.EnvironmentReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VmImage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VmImage(VmImage other) : this() {
      project_ = other.project_;
      switch (other.ImageCase) {
        case ImageOneofCase.ImageName:
          ImageName = other.ImageName;
          break;
        case ImageOneofCase.ImageFamily:
          ImageFamily = other.ImageFamily;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VmImage Clone() {
      return new VmImage(this);
    }

    /// <summary>Field number for the "project" field.</summary>
    public const int ProjectFieldNumber = 1;
    private string project_ = "";
    /// <summary>
    /// Required. The name of the Google Cloud project that this VM image belongs to.
    /// Format: `projects/{project_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Project {
      get { return project_; }
      set {
        project_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "image_name" field.</summary>
    public const int ImageNameFieldNumber = 2;
    /// <summary>
    /// Use VM image name to find the image.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageName {
      get { return imageCase_ == ImageOneofCase.ImageName ? (string) image_ : ""; }
      set {
        image_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        imageCase_ = ImageOneofCase.ImageName;
      }
    }

    /// <summary>Field number for the "image_family" field.</summary>
    public const int ImageFamilyFieldNumber = 3;
    /// <summary>
    /// Use this VM image family to find the image; the newest image in this
    /// family will be used.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageFamily {
      get { return imageCase_ == ImageOneofCase.ImageFamily ? (string) image_ : ""; }
      set {
        image_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        imageCase_ = ImageOneofCase.ImageFamily;
      }
    }

    private object image_;
    /// <summary>Enum of possible cases for the "image" oneof.</summary>
    public enum ImageOneofCase {
      None = 0,
      ImageName = 2,
      ImageFamily = 3,
    }
    private ImageOneofCase imageCase_ = ImageOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageOneofCase ImageCase {
      get { return imageCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearImage() {
      imageCase_ = ImageOneofCase.None;
      image_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VmImage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VmImage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Project != other.Project) return false;
      if (ImageName != other.ImageName) return false;
      if (ImageFamily != other.ImageFamily) return false;
      if (ImageCase != other.ImageCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Project.Length != 0) hash ^= Project.GetHashCode();
      if (imageCase_ == ImageOneofCase.ImageName) hash ^= ImageName.GetHashCode();
      if (imageCase_ == ImageOneofCase.ImageFamily) hash ^= ImageFamily.GetHashCode();
      hash ^= (int) imageCase_;
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
      if (Project.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Project);
      }
      if (imageCase_ == ImageOneofCase.ImageName) {
        output.WriteRawTag(18);
        output.WriteString(ImageName);
      }
      if (imageCase_ == ImageOneofCase.ImageFamily) {
        output.WriteRawTag(26);
        output.WriteString(ImageFamily);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Project.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Project);
      }
      if (imageCase_ == ImageOneofCase.ImageName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageName);
      }
      if (imageCase_ == ImageOneofCase.ImageFamily) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageFamily);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VmImage other) {
      if (other == null) {
        return;
      }
      if (other.Project.Length != 0) {
        Project = other.Project;
      }
      switch (other.ImageCase) {
        case ImageOneofCase.ImageName:
          ImageName = other.ImageName;
          break;
        case ImageOneofCase.ImageFamily:
          ImageFamily = other.ImageFamily;
          break;
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
            Project = input.ReadString();
            break;
          }
          case 18: {
            ImageName = input.ReadString();
            break;
          }
          case 26: {
            ImageFamily = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Definition of a container image for starting a notebook instance with the
  /// environment installed in a container.
  /// </summary>
  public sealed partial class ContainerImage : pb::IMessage<ContainerImage> {
    private static readonly pb::MessageParser<ContainerImage> _parser = new pb::MessageParser<ContainerImage>(() => new ContainerImage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContainerImage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Notebooks.V1Beta1.EnvironmentReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerImage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerImage(ContainerImage other) : this() {
      repository_ = other.repository_;
      tag_ = other.tag_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContainerImage Clone() {
      return new ContainerImage(this);
    }

    /// <summary>Field number for the "repository" field.</summary>
    public const int RepositoryFieldNumber = 1;
    private string repository_ = "";
    /// <summary>
    /// Required. The path to the container image repository. For example:
    /// `gcr.io/{project_id}/{image_name}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Repository {
      get { return repository_; }
      set {
        repository_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tag" field.</summary>
    public const int TagFieldNumber = 2;
    private string tag_ = "";
    /// <summary>
    /// The tag of the container image. If not specified, this defaults
    /// to the latest tag.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Tag {
      get { return tag_; }
      set {
        tag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContainerImage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContainerImage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Repository != other.Repository) return false;
      if (Tag != other.Tag) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Repository.Length != 0) hash ^= Repository.GetHashCode();
      if (Tag.Length != 0) hash ^= Tag.GetHashCode();
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
      if (Repository.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Repository);
      }
      if (Tag.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Tag);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Repository.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Repository);
      }
      if (Tag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Tag);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContainerImage other) {
      if (other == null) {
        return;
      }
      if (other.Repository.Length != 0) {
        Repository = other.Repository;
      }
      if (other.Tag.Length != 0) {
        Tag = other.Tag;
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
            Repository = input.ReadString();
            break;
          }
          case 18: {
            Tag = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
