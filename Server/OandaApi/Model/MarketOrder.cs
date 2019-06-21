using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A MarketOrder is an order that is filled immediately upon creation using the current market price.
  /// </summary>
  [DataContract]
  public class MarketOrder {
    /// <summary>
    /// The Order's identifier, unique within the Order's Account.
    /// </summary>
    /// <value>The Order's identifier, unique within the Order's Account.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The time when the Order was created.
    /// </summary>
    /// <value>The time when the Order was created.</value>
    [DataMember(Name="createTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createTime")]
    public string CreateTime { get; set; }

    /// <summary>
    /// The current state of the Order.
    /// </summary>
    /// <value>The current state of the Order.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or Sets ClientExtensions
    /// </summary>
    [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientExtensions")]
    public ClientExtensions ClientExtensions { get; set; }

    /// <summary>
    /// The type of the Order. Always set to \"MARKET\" for Market Orders.
    /// </summary>
    /// <value>The type of the Order. Always set to \"MARKET\" for Market Orders.</value>
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
    /// Gets or Sets TradeClose
    /// </summary>
    [DataMember(Name="tradeClose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeClose")]
    public MarketOrderTradeClose TradeClose { get; set; }

    /// <summary>
    /// Gets or Sets LongPositionCloseout
    /// </summary>
    [DataMember(Name="longPositionCloseout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longPositionCloseout")]
    public MarketOrderPositionCloseout LongPositionCloseout { get; set; }

    /// <summary>
    /// Gets or Sets ShortPositionCloseout
    /// </summary>
    [DataMember(Name="shortPositionCloseout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortPositionCloseout")]
    public MarketOrderPositionCloseout ShortPositionCloseout { get; set; }

    /// <summary>
    /// Gets or Sets MarginCloseout
    /// </summary>
    [DataMember(Name="marginCloseout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginCloseout")]
    public MarketOrderMarginCloseout MarginCloseout { get; set; }

    /// <summary>
    /// Gets or Sets DelayedTradeClose
    /// </summary>
    [DataMember(Name="delayedTradeClose", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delayedTradeClose")]
    public MarketOrderDelayedTradeClose DelayedTradeClose { get; set; }

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
    /// ID of the Transaction that filled this Order (only provided when the Order's state is FILLED)
    /// </summary>
    /// <value>ID of the Transaction that filled this Order (only provided when the Order's state is FILLED)</value>
    [DataMember(Name="fillingTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fillingTransactionID")]
    public string FillingTransactionID { get; set; }

    /// <summary>
    /// Date/time when the Order was filled (only provided when the Order's state is FILLED)
    /// </summary>
    /// <value>Date/time when the Order was filled (only provided when the Order's state is FILLED)</value>
    [DataMember(Name="filledTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filledTime")]
    public string FilledTime { get; set; }

    /// <summary>
    /// Trade ID of Trade opened when the Order was filled (only provided when the Order's state is FILLED and a Trade was opened as a result of the fill)
    /// </summary>
    /// <value>Trade ID of Trade opened when the Order was filled (only provided when the Order's state is FILLED and a Trade was opened as a result of the fill)</value>
    [DataMember(Name="tradeOpenedID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeOpenedID")]
    public string TradeOpenedID { get; set; }

    /// <summary>
    /// Trade ID of Trade reduced when the Order was filled (only provided when the Order's state is FILLED and a Trade was reduced as a result of the fill)
    /// </summary>
    /// <value>Trade ID of Trade reduced when the Order was filled (only provided when the Order's state is FILLED and a Trade was reduced as a result of the fill)</value>
    [DataMember(Name="tradeReducedID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeReducedID")]
    public string TradeReducedID { get; set; }

    /// <summary>
    /// Trade IDs of Trades closed when the Order was filled (only provided when the Order's state is FILLED and one or more Trades were closed as a result of the fill)
    /// </summary>
    /// <value>Trade IDs of Trades closed when the Order was filled (only provided when the Order's state is FILLED and one or more Trades were closed as a result of the fill)</value>
    [DataMember(Name="tradeClosedIDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeClosedIDs")]
    public List<string> TradeClosedIDs { get; set; }

    /// <summary>
    /// ID of the Transaction that cancelled the Order (only provided when the Order's state is CANCELLED)
    /// </summary>
    /// <value>ID of the Transaction that cancelled the Order (only provided when the Order's state is CANCELLED)</value>
    [DataMember(Name="cancellingTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancellingTransactionID")]
    public string CancellingTransactionID { get; set; }

    /// <summary>
    /// Date/time when the Order was cancelled (only provided when the state of the Order is CANCELLED)
    /// </summary>
    /// <value>Date/time when the Order was cancelled (only provided when the state of the Order is CANCELLED)</value>
    [DataMember(Name="cancelledTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancelledTime")]
    public string CancelledTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketOrder {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
      sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
      sb.Append("  PriceBound: ").Append(PriceBound).Append("\n");
      sb.Append("  PositionFill: ").Append(PositionFill).Append("\n");
      sb.Append("  TradeClose: ").Append(TradeClose).Append("\n");
      sb.Append("  LongPositionCloseout: ").Append(LongPositionCloseout).Append("\n");
      sb.Append("  ShortPositionCloseout: ").Append(ShortPositionCloseout).Append("\n");
      sb.Append("  MarginCloseout: ").Append(MarginCloseout).Append("\n");
      sb.Append("  DelayedTradeClose: ").Append(DelayedTradeClose).Append("\n");
      sb.Append("  TakeProfitOnFill: ").Append(TakeProfitOnFill).Append("\n");
      sb.Append("  StopLossOnFill: ").Append(StopLossOnFill).Append("\n");
      sb.Append("  TrailingStopLossOnFill: ").Append(TrailingStopLossOnFill).Append("\n");
      sb.Append("  TradeClientExtensions: ").Append(TradeClientExtensions).Append("\n");
      sb.Append("  FillingTransactionID: ").Append(FillingTransactionID).Append("\n");
      sb.Append("  FilledTime: ").Append(FilledTime).Append("\n");
      sb.Append("  TradeOpenedID: ").Append(TradeOpenedID).Append("\n");
      sb.Append("  TradeReducedID: ").Append(TradeReducedID).Append("\n");
      sb.Append("  TradeClosedIDs: ").Append(TradeClosedIDs).Append("\n");
      sb.Append("  CancellingTransactionID: ").Append(CancellingTransactionID).Append("\n");
      sb.Append("  CancelledTime: ").Append(CancelledTime).Append("\n");
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
