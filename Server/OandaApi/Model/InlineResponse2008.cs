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
  public class InlineResponse2008 {
    /// <summary>
    /// Gets or Sets LongOrderCreateTransaction
    /// </summary>
    [DataMember(Name="longOrderCreateTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longOrderCreateTransaction")]
    public MarketOrderTransaction LongOrderCreateTransaction { get; set; }

    /// <summary>
    /// Gets or Sets LongOrderFillTransaction
    /// </summary>
    [DataMember(Name="longOrderFillTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longOrderFillTransaction")]
    public OrderFillTransaction LongOrderFillTransaction { get; set; }

    /// <summary>
    /// Gets or Sets LongOrderCancelTransaction
    /// </summary>
    [DataMember(Name="longOrderCancelTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longOrderCancelTransaction")]
    public OrderCancelTransaction LongOrderCancelTransaction { get; set; }

    /// <summary>
    /// Gets or Sets ShortOrderCreateTransaction
    /// </summary>
    [DataMember(Name="shortOrderCreateTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortOrderCreateTransaction")]
    public MarketOrderTransaction ShortOrderCreateTransaction { get; set; }

    /// <summary>
    /// Gets or Sets ShortOrderFillTransaction
    /// </summary>
    [DataMember(Name="shortOrderFillTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortOrderFillTransaction")]
    public OrderFillTransaction ShortOrderFillTransaction { get; set; }

    /// <summary>
    /// Gets or Sets ShortOrderCancelTransaction
    /// </summary>
    [DataMember(Name="shortOrderCancelTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortOrderCancelTransaction")]
    public OrderCancelTransaction ShortOrderCancelTransaction { get; set; }

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
      sb.Append("class InlineResponse2008 {\n");
      sb.Append("  LongOrderCreateTransaction: ").Append(LongOrderCreateTransaction).Append("\n");
      sb.Append("  LongOrderFillTransaction: ").Append(LongOrderFillTransaction).Append("\n");
      sb.Append("  LongOrderCancelTransaction: ").Append(LongOrderCancelTransaction).Append("\n");
      sb.Append("  ShortOrderCreateTransaction: ").Append(ShortOrderCreateTransaction).Append("\n");
      sb.Append("  ShortOrderFillTransaction: ").Append(ShortOrderFillTransaction).Append("\n");
      sb.Append("  ShortOrderCancelTransaction: ").Append(ShortOrderCancelTransaction).Append("\n");
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
