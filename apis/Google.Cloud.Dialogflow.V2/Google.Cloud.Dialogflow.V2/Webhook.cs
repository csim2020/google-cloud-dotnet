// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dialogflow/v2/webhook.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Dialogflow.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/dialogflow/v2/webhook.proto</summary>
  public static partial class WebhookReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/dialogflow/v2/webhook.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WebhookReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvZGlhbG9nZmxvdy92Mi93ZWJob29rLnByb3RvEhpn",
            "b29nbGUuY2xvdWQuZGlhbG9nZmxvdy52MhooZ29vZ2xlL2Nsb3VkL2RpYWxv",
            "Z2Zsb3cvdjIvY29udGV4dC5wcm90bxonZ29vZ2xlL2Nsb3VkL2RpYWxvZ2Zs",
            "b3cvdjIvaW50ZW50LnByb3RvGihnb29nbGUvY2xvdWQvZGlhbG9nZmxvdy92",
            "Mi9zZXNzaW9uLnByb3RvGjRnb29nbGUvY2xvdWQvZGlhbG9nZmxvdy92Mi9z",
            "ZXNzaW9uX2VudGl0eV90eXBlLnByb3RvGhxnb29nbGUvcHJvdG9idWYvc3Ry",
            "dWN0LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvItYBCg5X",
            "ZWJob29rUmVxdWVzdBIPCgdzZXNzaW9uGAQgASgJEhMKC3Jlc3BvbnNlX2lk",
            "GAEgASgJEj0KDHF1ZXJ5X3Jlc3VsdBgCIAEoCzInLmdvb2dsZS5jbG91ZC5k",
            "aWFsb2dmbG93LnYyLlF1ZXJ5UmVzdWx0El8KHm9yaWdpbmFsX2RldGVjdF9p",
            "bnRlbnRfcmVxdWVzdBgDIAEoCzI3Lmdvb2dsZS5jbG91ZC5kaWFsb2dmbG93",
            "LnYyLk9yaWdpbmFsRGV0ZWN0SW50ZW50UmVxdWVzdCKAAwoPV2ViaG9va1Jl",
            "c3BvbnNlEhgKEGZ1bGZpbGxtZW50X3RleHQYASABKAkSSAoUZnVsZmlsbG1l",
            "bnRfbWVzc2FnZXMYAiADKAsyKi5nb29nbGUuY2xvdWQuZGlhbG9nZmxvdy52",
            "Mi5JbnRlbnQuTWVzc2FnZRIOCgZzb3VyY2UYAyABKAkSKAoHcGF5bG9hZBgE",
            "IAEoCzIXLmdvb2dsZS5wcm90b2J1Zi5TdHJ1Y3QSPAoPb3V0cHV0X2NvbnRl",
            "eHRzGAUgAygLMiMuZ29vZ2xlLmNsb3VkLmRpYWxvZ2Zsb3cudjIuQ29udGV4",
            "dBJEChRmb2xsb3d1cF9ldmVudF9pbnB1dBgGIAEoCzImLmdvb2dsZS5jbG91",
            "ZC5kaWFsb2dmbG93LnYyLkV2ZW50SW5wdXQSSwoUc2Vzc2lvbl9lbnRpdHlf",
            "dHlwZXMYCiADKAsyLS5nb29nbGUuY2xvdWQuZGlhbG9nZmxvdy52Mi5TZXNz",
            "aW9uRW50aXR5VHlwZSJoChtPcmlnaW5hbERldGVjdEludGVudFJlcXVlc3QS",
            "DgoGc291cmNlGAEgASgJEg8KB3ZlcnNpb24YAiABKAkSKAoHcGF5bG9hZBgD",
            "IAEoCzIXLmdvb2dsZS5wcm90b2J1Zi5TdHJ1Y3RCmwEKHmNvbS5nb29nbGUu",
            "Y2xvdWQuZGlhbG9nZmxvdy52MkIMV2ViaG9va1Byb3RvUAFaRGdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvZGlhbG9nZmxv",
            "dy92MjtkaWFsb2dmbG93+AEBogICREaqAhpHb29nbGUuQ2xvdWQuRGlhbG9n",
            "Zmxvdy5WMmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Dialogflow.V2.ContextReflection.Descriptor, global::Google.Cloud.Dialogflow.V2.IntentReflection.Descriptor, global::Google.Cloud.Dialogflow.V2.SessionReflection.Descriptor, global::Google.Cloud.Dialogflow.V2.SessionEntityTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.V2.WebhookRequest), global::Google.Cloud.Dialogflow.V2.WebhookRequest.Parser, new[]{ "Session", "ResponseId", "QueryResult", "OriginalDetectIntentRequest" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.V2.WebhookResponse), global::Google.Cloud.Dialogflow.V2.WebhookResponse.Parser, new[]{ "FulfillmentText", "FulfillmentMessages", "Source", "Payload", "OutputContexts", "FollowupEventInput", "SessionEntityTypes" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Dialogflow.V2.OriginalDetectIntentRequest), global::Google.Cloud.Dialogflow.V2.OriginalDetectIntentRequest.Parser, new[]{ "Source", "Version", "Payload" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message for a webhook call.
  /// </summary>
  public sealed partial class WebhookRequest : pb::IMessage<WebhookRequest> {
    private static readonly pb::MessageParser<WebhookRequest> _parser = new pb::MessageParser<WebhookRequest>(() => new WebhookRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WebhookRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.V2.WebhookReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebhookRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebhookRequest(WebhookRequest other) : this() {
      session_ = other.session_;
      responseId_ = other.responseId_;
      queryResult_ = other.queryResult_ != null ? other.queryResult_.Clone() : null;
      originalDetectIntentRequest_ = other.originalDetectIntentRequest_ != null ? other.originalDetectIntentRequest_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebhookRequest Clone() {
      return new WebhookRequest(this);
    }

    /// <summary>Field number for the "session" field.</summary>
    public const int SessionFieldNumber = 4;
    private string session_ = "";
    /// <summary>
    /// The unique identifier of detectIntent request session.
    /// Can be used to identify end-user inside webhook implementation.
    /// Format: `projects/&lt;Project ID>/agent/sessions/&lt;Session ID>`, or
    /// `projects/&lt;Project ID>/agent/environments/&lt;Environment ID>/users/&lt;User
    /// ID>/sessions/&lt;Session ID>`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Session {
      get { return session_; }
      set {
        session_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "response_id" field.</summary>
    public const int ResponseIdFieldNumber = 1;
    private string responseId_ = "";
    /// <summary>
    /// The unique identifier of the response. Contains the same value as
    /// `[Streaming]DetectIntentResponse.response_id`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResponseId {
      get { return responseId_; }
      set {
        responseId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "query_result" field.</summary>
    public const int QueryResultFieldNumber = 2;
    private global::Google.Cloud.Dialogflow.V2.QueryResult queryResult_;
    /// <summary>
    /// The result of the conversational query or event processing. Contains the
    /// same value as `[Streaming]DetectIntentResponse.query_result`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Dialogflow.V2.QueryResult QueryResult {
      get { return queryResult_; }
      set {
        queryResult_ = value;
      }
    }

    /// <summary>Field number for the "original_detect_intent_request" field.</summary>
    public const int OriginalDetectIntentRequestFieldNumber = 3;
    private global::Google.Cloud.Dialogflow.V2.OriginalDetectIntentRequest originalDetectIntentRequest_;
    /// <summary>
    /// Optional. The contents of the original request that was passed to
    /// `[Streaming]DetectIntent` call.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Dialogflow.V2.OriginalDetectIntentRequest OriginalDetectIntentRequest {
      get { return originalDetectIntentRequest_; }
      set {
        originalDetectIntentRequest_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WebhookRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WebhookRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Session != other.Session) return false;
      if (ResponseId != other.ResponseId) return false;
      if (!object.Equals(QueryResult, other.QueryResult)) return false;
      if (!object.Equals(OriginalDetectIntentRequest, other.OriginalDetectIntentRequest)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Session.Length != 0) hash ^= Session.GetHashCode();
      if (ResponseId.Length != 0) hash ^= ResponseId.GetHashCode();
      if (queryResult_ != null) hash ^= QueryResult.GetHashCode();
      if (originalDetectIntentRequest_ != null) hash ^= OriginalDetectIntentRequest.GetHashCode();
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
      if (ResponseId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResponseId);
      }
      if (queryResult_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(QueryResult);
      }
      if (originalDetectIntentRequest_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(OriginalDetectIntentRequest);
      }
      if (Session.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Session);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Session.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Session);
      }
      if (ResponseId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResponseId);
      }
      if (queryResult_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(QueryResult);
      }
      if (originalDetectIntentRequest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OriginalDetectIntentRequest);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WebhookRequest other) {
      if (other == null) {
        return;
      }
      if (other.Session.Length != 0) {
        Session = other.Session;
      }
      if (other.ResponseId.Length != 0) {
        ResponseId = other.ResponseId;
      }
      if (other.queryResult_ != null) {
        if (queryResult_ == null) {
          QueryResult = new global::Google.Cloud.Dialogflow.V2.QueryResult();
        }
        QueryResult.MergeFrom(other.QueryResult);
      }
      if (other.originalDetectIntentRequest_ != null) {
        if (originalDetectIntentRequest_ == null) {
          OriginalDetectIntentRequest = new global::Google.Cloud.Dialogflow.V2.OriginalDetectIntentRequest();
        }
        OriginalDetectIntentRequest.MergeFrom(other.OriginalDetectIntentRequest);
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
            ResponseId = input.ReadString();
            break;
          }
          case 18: {
            if (queryResult_ == null) {
              QueryResult = new global::Google.Cloud.Dialogflow.V2.QueryResult();
            }
            input.ReadMessage(QueryResult);
            break;
          }
          case 26: {
            if (originalDetectIntentRequest_ == null) {
              OriginalDetectIntentRequest = new global::Google.Cloud.Dialogflow.V2.OriginalDetectIntentRequest();
            }
            input.ReadMessage(OriginalDetectIntentRequest);
            break;
          }
          case 34: {
            Session = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message for a webhook call.
  /// </summary>
  public sealed partial class WebhookResponse : pb::IMessage<WebhookResponse> {
    private static readonly pb::MessageParser<WebhookResponse> _parser = new pb::MessageParser<WebhookResponse>(() => new WebhookResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WebhookResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.V2.WebhookReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebhookResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebhookResponse(WebhookResponse other) : this() {
      fulfillmentText_ = other.fulfillmentText_;
      fulfillmentMessages_ = other.fulfillmentMessages_.Clone();
      source_ = other.source_;
      payload_ = other.payload_ != null ? other.payload_.Clone() : null;
      outputContexts_ = other.outputContexts_.Clone();
      followupEventInput_ = other.followupEventInput_ != null ? other.followupEventInput_.Clone() : null;
      sessionEntityTypes_ = other.sessionEntityTypes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WebhookResponse Clone() {
      return new WebhookResponse(this);
    }

    /// <summary>Field number for the "fulfillment_text" field.</summary>
    public const int FulfillmentTextFieldNumber = 1;
    private string fulfillmentText_ = "";
    /// <summary>
    /// Optional. The text to be shown on the screen. This value is passed directly
    /// to `QueryResult.fulfillment_text`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FulfillmentText {
      get { return fulfillmentText_; }
      set {
        fulfillmentText_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fulfillment_messages" field.</summary>
    public const int FulfillmentMessagesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Cloud.Dialogflow.V2.Intent.Types.Message> _repeated_fulfillmentMessages_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Cloud.Dialogflow.V2.Intent.Types.Message.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.Intent.Types.Message> fulfillmentMessages_ = new pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.Intent.Types.Message>();
    /// <summary>
    /// Optional. The collection of rich messages to present to the user. This
    /// value is passed directly to `QueryResult.fulfillment_messages`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.Intent.Types.Message> FulfillmentMessages {
      get { return fulfillmentMessages_; }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 3;
    private string source_ = "";
    /// <summary>
    /// Optional. This value is passed directly to `QueryResult.webhook_source`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Source {
      get { return source_; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Struct payload_;
    /// <summary>
    /// Optional. This value is passed directly to `QueryResult.webhook_payload`.
    /// See the related `fulfillment_messages[i].payload field`, which may be used
    /// as an alternative to this field.
    ///
    /// This field can be used for Actions on Google responses.
    /// It should have a structure similar to the JSON message shown here. For more
    /// information, see
    /// [Actions on Google Webhook
    /// Format](https://developers.google.com/actions/dialogflow/webhook)
    /// &lt;pre>{
    ///   "google": {
    ///     "expectUserResponse": true,
    ///     "richResponse": {
    ///       "items": [
    ///         {
    ///           "simpleResponse": {
    ///             "textToSpeech": "this is a simple response"
    ///           }
    ///         }
    ///       ]
    ///     }
    ///   }
    /// }&lt;/pre>
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Payload {
      get { return payload_; }
      set {
        payload_ = value;
      }
    }

    /// <summary>Field number for the "output_contexts" field.</summary>
    public const int OutputContextsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Cloud.Dialogflow.V2.Context> _repeated_outputContexts_codec
        = pb::FieldCodec.ForMessage(42, global::Google.Cloud.Dialogflow.V2.Context.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.Context> outputContexts_ = new pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.Context>();
    /// <summary>
    /// Optional. The collection of output contexts. This value is passed directly
    /// to `QueryResult.output_contexts`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.Context> OutputContexts {
      get { return outputContexts_; }
    }

    /// <summary>Field number for the "followup_event_input" field.</summary>
    public const int FollowupEventInputFieldNumber = 6;
    private global::Google.Cloud.Dialogflow.V2.EventInput followupEventInput_;
    /// <summary>
    /// Optional. Makes the platform immediately invoke another `DetectIntent` call
    /// internally with the specified event as input.
    /// When this field is set, Dialogflow ignores the `fulfillment_text`,
    /// `fulfillment_messages`, and `payload` fields.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Dialogflow.V2.EventInput FollowupEventInput {
      get { return followupEventInput_; }
      set {
        followupEventInput_ = value;
      }
    }

    /// <summary>Field number for the "session_entity_types" field.</summary>
    public const int SessionEntityTypesFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Google.Cloud.Dialogflow.V2.SessionEntityType> _repeated_sessionEntityTypes_codec
        = pb::FieldCodec.ForMessage(82, global::Google.Cloud.Dialogflow.V2.SessionEntityType.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.SessionEntityType> sessionEntityTypes_ = new pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.SessionEntityType>();
    /// <summary>
    /// Optional. Additional session entity types to replace or extend developer
    /// entity types with. The entity synonyms apply to all languages and persist
    /// for the session of this query. Setting the session entity types inside
    /// webhook overwrites the session entity types that have been set through
    /// `DetectIntentRequest.query_params.session_entity_types`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Dialogflow.V2.SessionEntityType> SessionEntityTypes {
      get { return sessionEntityTypes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WebhookResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WebhookResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FulfillmentText != other.FulfillmentText) return false;
      if(!fulfillmentMessages_.Equals(other.fulfillmentMessages_)) return false;
      if (Source != other.Source) return false;
      if (!object.Equals(Payload, other.Payload)) return false;
      if(!outputContexts_.Equals(other.outputContexts_)) return false;
      if (!object.Equals(FollowupEventInput, other.FollowupEventInput)) return false;
      if(!sessionEntityTypes_.Equals(other.sessionEntityTypes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FulfillmentText.Length != 0) hash ^= FulfillmentText.GetHashCode();
      hash ^= fulfillmentMessages_.GetHashCode();
      if (Source.Length != 0) hash ^= Source.GetHashCode();
      if (payload_ != null) hash ^= Payload.GetHashCode();
      hash ^= outputContexts_.GetHashCode();
      if (followupEventInput_ != null) hash ^= FollowupEventInput.GetHashCode();
      hash ^= sessionEntityTypes_.GetHashCode();
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
      if (FulfillmentText.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FulfillmentText);
      }
      fulfillmentMessages_.WriteTo(output, _repeated_fulfillmentMessages_codec);
      if (Source.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Source);
      }
      if (payload_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Payload);
      }
      outputContexts_.WriteTo(output, _repeated_outputContexts_codec);
      if (followupEventInput_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(FollowupEventInput);
      }
      sessionEntityTypes_.WriteTo(output, _repeated_sessionEntityTypes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FulfillmentText.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FulfillmentText);
      }
      size += fulfillmentMessages_.CalculateSize(_repeated_fulfillmentMessages_codec);
      if (Source.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Source);
      }
      if (payload_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Payload);
      }
      size += outputContexts_.CalculateSize(_repeated_outputContexts_codec);
      if (followupEventInput_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FollowupEventInput);
      }
      size += sessionEntityTypes_.CalculateSize(_repeated_sessionEntityTypes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WebhookResponse other) {
      if (other == null) {
        return;
      }
      if (other.FulfillmentText.Length != 0) {
        FulfillmentText = other.FulfillmentText;
      }
      fulfillmentMessages_.Add(other.fulfillmentMessages_);
      if (other.Source.Length != 0) {
        Source = other.Source;
      }
      if (other.payload_ != null) {
        if (payload_ == null) {
          Payload = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Payload.MergeFrom(other.Payload);
      }
      outputContexts_.Add(other.outputContexts_);
      if (other.followupEventInput_ != null) {
        if (followupEventInput_ == null) {
          FollowupEventInput = new global::Google.Cloud.Dialogflow.V2.EventInput();
        }
        FollowupEventInput.MergeFrom(other.FollowupEventInput);
      }
      sessionEntityTypes_.Add(other.sessionEntityTypes_);
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
            FulfillmentText = input.ReadString();
            break;
          }
          case 18: {
            fulfillmentMessages_.AddEntriesFrom(input, _repeated_fulfillmentMessages_codec);
            break;
          }
          case 26: {
            Source = input.ReadString();
            break;
          }
          case 34: {
            if (payload_ == null) {
              Payload = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Payload);
            break;
          }
          case 42: {
            outputContexts_.AddEntriesFrom(input, _repeated_outputContexts_codec);
            break;
          }
          case 50: {
            if (followupEventInput_ == null) {
              FollowupEventInput = new global::Google.Cloud.Dialogflow.V2.EventInput();
            }
            input.ReadMessage(FollowupEventInput);
            break;
          }
          case 82: {
            sessionEntityTypes_.AddEntriesFrom(input, _repeated_sessionEntityTypes_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Represents the contents of the original request that was passed to
  /// the `[Streaming]DetectIntent` call.
  /// </summary>
  public sealed partial class OriginalDetectIntentRequest : pb::IMessage<OriginalDetectIntentRequest> {
    private static readonly pb::MessageParser<OriginalDetectIntentRequest> _parser = new pb::MessageParser<OriginalDetectIntentRequest>(() => new OriginalDetectIntentRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OriginalDetectIntentRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Dialogflow.V2.WebhookReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OriginalDetectIntentRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OriginalDetectIntentRequest(OriginalDetectIntentRequest other) : this() {
      source_ = other.source_;
      version_ = other.version_;
      payload_ = other.payload_ != null ? other.payload_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OriginalDetectIntentRequest Clone() {
      return new OriginalDetectIntentRequest(this);
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 1;
    private string source_ = "";
    /// <summary>
    /// The source of this request, e.g., `google`, `facebook`, `slack`. It is set
    /// by Dialogflow-owned servers.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Source {
      get { return source_; }
      set {
        source_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 2;
    private string version_ = "";
    /// <summary>
    /// Optional. The version of the protocol used for this request.
    /// This field is AoG-specific.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Struct payload_;
    /// <summary>
    /// Optional. This field is set to the value of the `QueryParameters.payload`
    /// field passed in the request. Some integrations that query a Dialogflow
    /// agent may provide additional information in the payload.
    ///
    /// In particular for the Telephony Gateway this field has the form:
    /// &lt;pre>{
    ///  "telephony": {
    ///    "caller_id": "+18558363987"
    ///  }
    /// }&lt;/pre>
    /// Note: The caller ID field (`caller_id`) will be redacted for Standard
    /// Edition agents and populated with the caller ID in [E.164
    /// format](https://en.wikipedia.org/wiki/E.164) for Enterprise Edition agents.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Struct Payload {
      get { return payload_; }
      set {
        payload_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OriginalDetectIntentRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OriginalDetectIntentRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Source != other.Source) return false;
      if (Version != other.Version) return false;
      if (!object.Equals(Payload, other.Payload)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Source.Length != 0) hash ^= Source.GetHashCode();
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      if (payload_ != null) hash ^= Payload.GetHashCode();
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
      if (Source.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Source);
      }
      if (Version.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Version);
      }
      if (payload_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Payload);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Source.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Source);
      }
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (payload_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Payload);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OriginalDetectIntentRequest other) {
      if (other == null) {
        return;
      }
      if (other.Source.Length != 0) {
        Source = other.Source;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      if (other.payload_ != null) {
        if (payload_ == null) {
          Payload = new global::Google.Protobuf.WellKnownTypes.Struct();
        }
        Payload.MergeFrom(other.Payload);
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
            Source = input.ReadString();
            break;
          }
          case 18: {
            Version = input.ReadString();
            break;
          }
          case 26: {
            if (payload_ == null) {
              Payload = new global::Google.Protobuf.WellKnownTypes.Struct();
            }
            input.ReadMessage(Payload);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
