using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Details for the Market Order extensions specific to a Market Order placed with the intent of fully closing a specific open trade that should have already been closed but wasn&#39;t due to halted market conditions
  /// </summary>
  [DataContract]
  public class MarketOrderDelayedTradeClose {
    /// <summary>
    /// The ID of the Trade being closed
    /// </summary>
    /// <value>The ID of the Trade being closed</value>
    [DataMember(Name="tradeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeID")]
    public string TradeID { get; set; }

    /// <summary>
    /// The Client ID of the Trade being closed
    /// </summary>
    /// <value>The Client ID of the Trade being closed</value>
    [DataMember(Name="clientTradeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientTradeID")]
    public string ClientTradeID { get; set; }

    /// <summary>
    /// The Transaction ID of the DelayedTradeClosure transaction to which this Delayed Trade Close belongs to
    /// </summary>
    /// <value>The Transaction ID of the DelayedTradeClosure transaction to which this Delayed Trade Close belongs to</value>
    [DataMember(Name="sourceTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceTransactionID")]
    public string SourceTransactionID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketOrderDelayedTradeClose {\n");
      sb.Append("  TradeID: ").Append(TradeID).Append("\n");
      sb.Append("  ClientTradeID: ").Append(ClientTradeID).Append("\n");
      sb.Append("  SourceTransactionID: ").Append(SourceTransactionID).Append("\n");
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
