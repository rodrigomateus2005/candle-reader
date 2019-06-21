using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A MarketOrderRequest specifies the parameters that may be set when creating a Market Order.
  /// </summary>
  [DataContract]
  public class MarketOrderRequest {
    /// <summary>
    /// The type of the Order to Create. Must be set to \"MARKET\" when creating a Market Order.
    /// </summary>
    /// <value>The type of the Order to Create. Must be set to \"MARKET\" when creating a Market Order.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The Market Order's Instrument.
    /// </summary>
    /// <value>The Market Order's Instrument.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.
    /// </summary>
    /// <value>The quantity requested to be filled by the Market Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.</value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public string Units { get; set; }

    /// <summary>
    /// The time-in-force requested for the Market Order. Restricted to FOK or IOC for a MarketOrder.
    /// </summary>
    /// <value>The time-in-force requested for the Market Order. Restricted to FOK or IOC for a MarketOrder.</value>
    [DataMember(Name="timeInForce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeInForce")]
    public string TimeInForce { get; set; }

    /// <summary>
    /// The worst price that the client is willing to have the Market Order filled at.
    /// </summary>
    /// <value>The worst price that the client is willing to have the Market Order filled at.</value>
    [DataMember(Name="priceBound", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceBound")]
    public string PriceBound { get; set; }

    /// <summary>
    /// Specification of how Positions in the Account are modified when the Order is filled.
    /// </summary>
    /// <value>Specification of how Positions in the Account are modified when the Order is filled.</value>
    [DataMember(Name="positionFill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "positionFill")]
    public string PositionFill { get; set; }

    /// <summary>
    /// Gets or Sets ClientExtensions
    /// </summary>
    [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientExtensions")]
    public ClientExtensions ClientExtensions { get; set; }

    /// <summary>
    /// Gets or Sets TakeProfitOnFill
    /// </summary>
    [DataMember(Name="takeProfitOnFill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takeProfitOnFill")]
    public TakeProfitDetails TakeProfitOnFill { get; set; }

    /// <summary>
    /// Gets or Sets StopLossOnFill
    /// </summary>
    [DataMember(Name="stopLossOnFill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLossOnFill")]
    public StopLossDetails StopLossOnFill { get; set; }

    /// <summary>
    /// Gets or Sets TrailingStopLossOnFill
    /// </summary>
    [DataMember(Name="trailingStopLossOnFill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trailingStopLossOnFill")]
    public TrailingStopLossDetails TrailingStopLossOnFill { get; set; }

    /// <summary>
    /// Gets or Sets TradeClientExtensions
    /// </summary>
    [DataMember(Name="tradeClientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeClientExtensions")]
    public ClientExtensions TradeClientExtensions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketOrderRequest {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
      sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
      sb.Append("  PriceBound: ").Append(PriceBound).Append("\n");
      sb.Append("  PositionFill: ").Append(PositionFill).Append("\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
      sb.Append("  TakeProfitOnFill: ").Append(TakeProfitOnFill).Append("\n");
      sb.Append("  StopLossOnFill: ").Append(StopLossOnFill).Append("\n");
      sb.Append("  TrailingStopLossOnFill: ").Append(TrailingStopLossOnFill).Append("\n");
      sb.Append("  TradeClientExtensions: ").Append(TradeClientExtensions).Append("\n");
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
