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
  public class InlineResponse20014 {
    /// <summary>
    /// Gets or Sets TakeProfitOrderCancelTransaction
    /// </summary>
    [DataMember(Name="takeProfitOrderCancelTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takeProfitOrderCancelTransaction")]
    public OrderCancelTransaction TakeProfitOrderCancelTransaction { get; set; }

    /// <summary>
    /// Gets or Sets TakeProfitOrderTransaction
    /// </summary>
    [DataMember(Name="takeProfitOrderTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takeProfitOrderTransaction")]
    public TakeProfitOrderTransaction TakeProfitOrderTransaction { get; set; }

    /// <summary>
    /// Gets or Sets TakeProfitOrderFillTransaction
    /// </summary>
    [DataMember(Name="takeProfitOrderFillTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takeProfitOrderFillTransaction")]
    public OrderFillTransaction TakeProfitOrderFillTransaction { get; set; }

    /// <summary>
    /// Gets or Sets TakeProfitOrderCreatedCancelTransaction
    /// </summary>
    [DataMember(Name="takeProfitOrderCreatedCancelTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takeProfitOrderCreatedCancelTransaction")]
    public OrderCancelTransaction TakeProfitOrderCreatedCancelTransaction { get; set; }

    /// <summary>
    /// Gets or Sets StopLossOrderCancelTransaction
    /// </summary>
    [DataMember(Name="stopLossOrderCancelTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLossOrderCancelTransaction")]
    public OrderCancelTransaction StopLossOrderCancelTransaction { get; set; }

    /// <summary>
    /// Gets or Sets StopLossOrderTransaction
    /// </summary>
    [DataMember(Name="stopLossOrderTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLossOrderTransaction")]
    public StopLossOrderTransaction StopLossOrderTransaction { get; set; }

    /// <summary>
    /// Gets or Sets StopLossOrderFillTransaction
    /// </summary>
    [DataMember(Name="stopLossOrderFillTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLossOrderFillTransaction")]
    public OrderFillTransaction StopLossOrderFillTransaction { get; set; }

    /// <summary>
    /// Gets or Sets StopLossOrderCreatedCancelTransaction
    /// </summary>
    [DataMember(Name="stopLossOrderCreatedCancelTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLossOrderCreatedCancelTransaction")]
    public OrderCancelTransaction StopLossOrderCreatedCancelTransaction { get; set; }

    /// <summary>
    /// Gets or Sets TrailingStopLossOrderCancelTransaction
    /// </summary>
    [DataMember(Name="trailingStopLossOrderCancelTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trailingStopLossOrderCancelTransaction")]
    public OrderCancelTransaction TrailingStopLossOrderCancelTransaction { get; set; }

    /// <summary>
    /// Gets or Sets TrailingStopLossOrderTransaction
    /// </summary>
    [DataMember(Name="trailingStopLossOrderTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trailingStopLossOrderTransaction")]
    public TrailingStopLossOrderTransaction TrailingStopLossOrderTransaction { get; set; }

    /// <summary>
    /// The IDs of all Transactions that were created while satisfying the request.
    /// </summary>
    /// <value>The IDs of all Transactions that were created while satisfying the request.</value>
    [DataMember(Name="relatedTransactionIDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relatedTransactionIDs")]
    public List<string> RelatedTransactionIDs { get; set; }

    /// <summary>
    /// The ID of the most recent Transaction created for the Account
    /// </summary>
    /// <value>The ID of the most recent Transaction created for the Account</value>
    [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransactionID")]
    public string LastTransactionID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse20014 {\n");
      sb.Append("  TakeProfitOrderCancelTransaction: ").Append(TakeProfitOrderCancelTransaction).Append("\n");
      sb.Append("  TakeProfitOrderTransaction: ").Append(TakeProfitOrderTransaction).Append("\n");
      sb.Append("  TakeProfitOrderFillTransaction: ").Append(TakeProfitOrderFillTransaction).Append("\n");
      sb.Append("  TakeProfitOrderCreatedCancelTransaction: ").Append(TakeProfitOrderCreatedCancelTransaction).Append("\n");
      sb.Append("  StopLossOrderCancelTransaction: ").Append(StopLossOrderCancelTransaction).Append("\n");
      sb.Append("  StopLossOrderTransaction: ").Append(StopLossOrderTransaction).Append("\n");
      sb.Append("  StopLossOrderFillTransaction: ").Append(StopLossOrderFillTransaction).Append("\n");
      sb.Append("  StopLossOrderCreatedCancelTransaction: ").Append(StopLossOrderCreatedCancelTransaction).Append("\n");
      sb.Append("  TrailingStopLossOrderCancelTransaction: ").Append(TrailingStopLossOrderCancelTransaction).Append("\n");
      sb.Append("  TrailingStopLossOrderTransaction: ").Append(TrailingStopLossOrderTransaction).Append("\n");
      sb.Append("  RelatedTransactionIDs: ").Append(RelatedTransactionIDs).Append("\n");
      sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
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
