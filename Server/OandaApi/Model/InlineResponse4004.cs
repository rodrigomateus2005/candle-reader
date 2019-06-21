using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InlineResponse4004 {
    /// <summary>
    /// Gets or Sets TakeProfitOrderCancelRejectTransaction
    /// </summary>
    [DataMember(Name="takeProfitOrderCancelRejectTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takeProfitOrderCancelRejectTransaction")]
    public OrderCancelRejectTransaction TakeProfitOrderCancelRejectTransaction { get; set; }

    /// <summary>
    /// Gets or Sets TakeProfitOrderRejectTransaction
    /// </summary>
    [DataMember(Name="takeProfitOrderRejectTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takeProfitOrderRejectTransaction")]
    public TakeProfitOrderRejectTransaction TakeProfitOrderRejectTransaction { get; set; }

    /// <summary>
    /// Gets or Sets StopLossOrderCancelRejectTransaction
    /// </summary>
    [DataMember(Name="stopLossOrderCancelRejectTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLossOrderCancelRejectTransaction")]
    public OrderCancelRejectTransaction StopLossOrderCancelRejectTransaction { get; set; }

    /// <summary>
    /// Gets or Sets StopLossOrderRejectTransaction
    /// </summary>
    [DataMember(Name="stopLossOrderRejectTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLossOrderRejectTransaction")]
    public StopLossOrderRejectTransaction StopLossOrderRejectTransaction { get; set; }

    /// <summary>
    /// Gets or Sets TrailingStopLossOrderCancelRejectTransaction
    /// </summary>
    [DataMember(Name="trailingStopLossOrderCancelRejectTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trailingStopLossOrderCancelRejectTransaction")]
    public OrderCancelRejectTransaction TrailingStopLossOrderCancelRejectTransaction { get; set; }

    /// <summary>
    /// Gets or Sets TrailingStopLossOrderRejectTransaction
    /// </summary>
    [DataMember(Name="trailingStopLossOrderRejectTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trailingStopLossOrderRejectTransaction")]
    public TrailingStopLossOrderRejectTransaction TrailingStopLossOrderRejectTransaction { get; set; }

    /// <summary>
    /// The ID of the most recent Transaction created for the Account.
    /// </summary>
    /// <value>The ID of the most recent Transaction created for the Account.</value>
    [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransactionID")]
    public string LastTransactionID { get; set; }

    /// <summary>
    /// The IDs of all Transactions that were created while satisfying the request.
    /// </summary>
    /// <value>The IDs of all Transactions that were created while satisfying the request.</value>
    [DataMember(Name="relatedTransactionIDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relatedTransactionIDs")]
    public List<string> RelatedTransactionIDs { get; set; }

    /// <summary>
    /// The code of the error that has occurred. This field may not be returned for some errors.
    /// </summary>
    /// <value>The code of the error that has occurred. This field may not be returned for some errors.</value>
    [DataMember(Name="errorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorCode")]
    public string ErrorCode { get; set; }

    /// <summary>
    /// The human-readable description of the error that has occurred.
    /// </summary>
    /// <value>The human-readable description of the error that has occurred.</value>
    [DataMember(Name="errorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorMessage")]
    public string ErrorMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse4004 {\n");
      sb.Append("  TakeProfitOrderCancelRejectTransaction: ").Append(TakeProfitOrderCancelRejectTransaction).Append("\n");
      sb.Append("  TakeProfitOrderRejectTransaction: ").Append(TakeProfitOrderRejectTransaction).Append("\n");
      sb.Append("  StopLossOrderCancelRejectTransaction: ").Append(StopLossOrderCancelRejectTransaction).Append("\n");
      sb.Append("  StopLossOrderRejectTransaction: ").Append(StopLossOrderRejectTransaction).Append("\n");
      sb.Append("  TrailingStopLossOrderCancelRejectTransaction: ").Append(TrailingStopLossOrderCancelRejectTransaction).Append("\n");
      sb.Append("  TrailingStopLossOrderRejectTransaction: ").Append(TrailingStopLossOrderRejectTransaction).Append("\n");
      sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
      sb.Append("  RelatedTransactionIDs: ").Append(RelatedTransactionIDs).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
