using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A TrailingStopLossOrderRequest specifies the parameters that may be set when creating a Trailing Stop Loss Order.
  /// </summary>
  [DataContract]
  public class TrailingStopLossOrderRequest {
    /// <summary>
    /// The type of the Order to Create. Must be set to \"TRAILING_STOP_LOSS\" when creating a Trailng Stop Loss Order.
    /// </summary>
    /// <value>The type of the Order to Create. Must be set to \"TRAILING_STOP_LOSS\" when creating a Trailng Stop Loss Order.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The ID of the Trade to close when the price threshold is breached.
    /// </summary>
    /// <value>The ID of the Trade to close when the price threshold is breached.</value>
    [DataMember(Name="tradeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeID")]
    public string TradeID { get; set; }

    /// <summary>
    /// The client ID of the Trade to be closed when the price threshold is breached.
    /// </summary>
    /// <value>The client ID of the Trade to be closed when the price threshold is breached.</value>
    [DataMember(Name="clientTradeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientTradeID")]
    public string ClientTradeID { get; set; }

    /// <summary>
    /// The price distance (in price units) specified for the TrailingStopLoss Order.
    /// </summary>
    /// <value>The price distance (in price units) specified for the TrailingStopLoss Order.</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public string Distance { get; set; }

    /// <summary>
    /// The time-in-force requested for the TrailingStopLoss Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for TrailingStopLoss Orders.
    /// </summary>
    /// <value>The time-in-force requested for the TrailingStopLoss Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for TrailingStopLoss Orders.</value>
    [DataMember(Name="timeInForce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeInForce")]
    public string TimeInForce { get; set; }

    /// <summary>
    /// The date/time when the StopLoss Order will be cancelled if its timeInForce is \"GTD\".
    /// </summary>
    /// <value>The date/time when the StopLoss Order will be cancelled if its timeInForce is \"GTD\".</value>
    [DataMember(Name="gtdTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gtdTime")]
    public string GtdTime { get; set; }

    /// <summary>
    /// Specification of which price component should be used when determining if an Order should be triggered and filled. This allows Orders to be triggered based on the bid, ask, mid, default (ask for buy, bid for sell) or inverse (ask for sell, bid for buy) price depending on the desired behaviour. Orders are always filled using their default price component. This feature is only provided through the REST API. Clients who choose to specify a non-default trigger condition will not see it reflected in any of OANDA's proprietary or partner trading platforms, their transaction history or their account statements. OANDA platforms always assume that an Order's trigger condition is set to the default value when indicating the distance from an Order's trigger price, and will always provide the default trigger condition when creating or modifying an Order. A special restriction applies when creating a guaranteed Stop Loss Order. In this case the TriggerCondition value must either be \"DEFAULT\", or the \"natural\" trigger side \"DEFAULT\" results in. So for a Stop Loss Order for a long trade valid values are \"DEFAULT\" and \"BID\", and for short trades \"DEFAULT\" and \"ASK\" are valid.
    /// </summary>
    /// <value>Specification of which price component should be used when determining if an Order should be triggered and filled. This allows Orders to be triggered based on the bid, ask, mid, default (ask for buy, bid for sell) or inverse (ask for sell, bid for buy) price depending on the desired behaviour. Orders are always filled using their default price component. This feature is only provided through the REST API. Clients who choose to specify a non-default trigger condition will not see it reflected in any of OANDA's proprietary or partner trading platforms, their transaction history or their account statements. OANDA platforms always assume that an Order's trigger condition is set to the default value when indicating the distance from an Order's trigger price, and will always provide the default trigger condition when creating or modifying an Order. A special restriction applies when creating a guaranteed Stop Loss Order. In this case the TriggerCondition value must either be \"DEFAULT\", or the \"natural\" trigger side \"DEFAULT\" results in. So for a Stop Loss Order for a long trade valid values are \"DEFAULT\" and \"BID\", and for short trades \"DEFAULT\" and \"ASK\" are valid.</value>
    [DataMember(Name="triggerCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerCondition")]
    public string TriggerCondition { get; set; }

    /// <summary>
    /// Gets or Sets ClientExtensions
    /// </summary>
    [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientExtensions")]
    public ClientExtensions ClientExtensions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TrailingStopLossOrderRequest {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TradeID: ").Append(TradeID).Append("\n");
      sb.Append("  ClientTradeID: ").Append(ClientTradeID).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
      sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
      sb.Append("  TriggerCondition: ").Append(TriggerCondition).Append("\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
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
