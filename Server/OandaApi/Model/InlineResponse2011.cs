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
  public class InlineResponse2011 {
    /// <summary>
    /// Gets or Sets OrderCancelTransaction
    /// </summary>
    [DataMember(Name="orderCancelTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderCancelTransaction")]
    public OrderCancelTransaction OrderCancelTransaction { get; set; }

    /// <summary>
    /// Gets or Sets OrderCreateTransaction
    /// </summary>
    [DataMember(Name="orderCreateTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderCreateTransaction")]
    public Transaction OrderCreateTransaction { get; set; }

    /// <summary>
    /// Gets or Sets OrderFillTransaction
    /// </summary>
    [DataMember(Name="orderFillTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderFillTransaction")]
    public OrderFillTransaction OrderFillTransaction { get; set; }

    /// <summary>
    /// Gets or Sets OrderReissueTransaction
    /// </summary>
    [DataMember(Name="orderReissueTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderReissueTransaction")]
    public Transaction OrderReissueTransaction { get; set; }

    /// <summary>
    /// Gets or Sets OrderReissueRejectTransaction
    /// </summary>
    [DataMember(Name="orderReissueRejectTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderReissueRejectTransaction")]
    public Transaction OrderReissueRejectTransaction { get; set; }

    /// <summary>
    /// Gets or Sets ReplacingOrderCancelTransaction
    /// </summary>
    [DataMember(Name="replacingOrderCancelTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replacingOrderCancelTransaction")]
    public OrderCancelTransaction ReplacingOrderCancelTransaction { get; set; }

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
      sb.Append("class InlineResponse2011 {\n");
      sb.Append("  OrderCancelTransaction: ").Append(OrderCancelTransaction).Append("\n");
      sb.Append("  OrderCreateTransaction: ").Append(OrderCreateTransaction).Append("\n");
      sb.Append("  OrderFillTransaction: ").Append(OrderFillTransaction).Append("\n");
      sb.Append("  OrderReissueTransaction: ").Append(OrderReissueTransaction).Append("\n");
      sb.Append("  OrderReissueRejectTransaction: ").Append(OrderReissueRejectTransaction).Append("\n");
      sb.Append("  ReplacingOrderCancelTransaction: ").Append(ReplacingOrderCancelTransaction).Append("\n");
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
