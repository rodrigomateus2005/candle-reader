using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A MarketIfTouchedOrder is an order that is created with a price threshold, and will only be filled by a market price that is touches or crosses the threshold.
  /// </summary>
  [DataContract]
  public class MarketIfTouchedOrder {
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
    /// The type of the Order. Always set to \"MARKET_IF_TOUCHED\" for Market If Touched Orders.
    /// </summary>
    /// <value>The type of the Order. Always set to \"MARKET_IF_TOUCHED\" for Market If Touched Orders.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The MarketIfTouched Order's Instrument.
    /// </summary>
    /// <value>The MarketIfTouched Order's Instrument.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// The quantity requested to be filled by the MarketIfTouched Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.
    /// </summary>
    /// <value>The quantity requested to be filled by the MarketIfTouched Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.</value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public string Units { get; set; }

    /// <summary>
    /// The price threshold specified for the MarketIfTouched Order. The MarketIfTouched Order will only be filled by a market price that crosses this price from the direction of the market price at the time when the Order was created (the initialMarketPrice). Depending on the value of the Order's price and initialMarketPrice, the MarketIfTouchedOrder will behave like a Limit or a Stop Order.
    /// </summary>
    /// <value>The price threshold specified for the MarketIfTouched Order. The MarketIfTouched Order will only be filled by a market price that crosses this price from the direction of the market price at the time when the Order was created (the initialMarketPrice). Depending on the value of the Order's price and initialMarketPrice, the MarketIfTouchedOrder will behave like a Limit or a Stop Order.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// The worst market price that may be used to fill this MarketIfTouched Order.
    /// </summary>
    /// <value>The worst market price that may be used to fill this MarketIfTouched Order.</value>
    [DataMember(Name="priceBound", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceBound")]
    public string PriceBound { get; set; }

    /// <summary>
    /// The time-in-force requested for the MarketIfTouched Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for MarketIfTouched Orders.
    /// </summary>
    /// <value>The time-in-force requested for the MarketIfTouched Order. Restricted to \"GTC\", \"GFD\" and \"GTD\" for MarketIfTouched Orders.</value>
    [DataMember(Name="timeInForce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeInForce")]
    public string TimeInForce { get; set; }

    /// <summary>
    /// The date/time when the MarketIfTouched Order will be cancelled if its timeInForce is \"GTD\".
    /// </summary>
    /// <value>The date/time when the MarketIfTouched Order will be cancelled if its timeInForce is \"GTD\".</value>
    [DataMember(Name="gtdTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gtdTime")]
    public string GtdTime { get; set; }

    /// <summary>
    /// Specification of how Positions in the Account are modified when the Order is filled.
    /// </summary>
    /// <value>Specification of how Positions in the Account are modified when the Order is filled.</value>
    [DataMember(Name="positionFill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "positionFill")]
    public string PositionFill { get; set; }

    /// <summary>
    /// Specification of which price component should be used when determining if an Order should be triggered and filled. This allows Orders to be triggered based on the bid, ask, mid, default (ask for buy, bid for sell) or inverse (ask for sell, bid for buy) price depending on the desired behaviour. Orders are always filled using their default price component. This feature is only provided through the REST API. Clients who choose to specify a non-default trigger condition will not see it reflected in any of OANDA's proprietary or partner trading platforms, their transaction history or their account statements. OANDA platforms always assume that an Order's trigger condition is set to the default value when indicating the distance from an Order's trigger price, and will always provide the default trigger condition when creating or modifying an Order. A special restriction applies when creating a guaranteed Stop Loss Order. In this case the TriggerCondition value must either be \"DEFAULT\", or the \"natural\" trigger side \"DEFAULT\" results in. So for a Stop Loss Order for a long trade valid values are \"DEFAULT\" and \"BID\", and for short trades \"DEFAULT\" and \"ASK\" are valid.
    /// </summary>
    /// <value>Specification of which price component should be used when determining if an Order should be triggered and filled. This allows Orders to be triggered based on the bid, ask, mid, default (ask for buy, bid for sell) or inverse (ask for sell, bid for buy) price depending on the desired behaviour. Orders are always filled using their default price component. This feature is only provided through the REST API. Clients who choose to specify a non-default trigger condition will not see it reflected in any of OANDA's proprietary or partner trading platforms, their transaction history or their account statements. OANDA platforms always assume that an Order's trigger condition is set to the default value when indicating the distance from an Order's trigger price, and will always provide the default trigger condition when creating or modifying an Order. A special restriction applies when creating a guaranteed Stop Loss Order. In this case the TriggerCondition value must either be \"DEFAULT\", or the \"natural\" trigger side \"DEFAULT\" results in. So for a Stop Loss Order for a long trade valid values are \"DEFAULT\" and \"BID\", and for short trades \"DEFAULT\" and \"ASK\" are valid.</value>
    [DataMember(Name="triggerCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerCondition")]
    public string TriggerCondition { get; set; }

    /// <summary>
    /// The Market price at the time when the MarketIfTouched Order was created.
    /// </summary>
    /// <value>The Market price at the time when the MarketIfTouched Order was created.</value>
    [DataMember(Name="initialMarketPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialMarketPrice")]
    public string InitialMarketPrice { get; set; }

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
    /// The ID of the Order that was replaced by this Order (only provided if this Order was created as part of a cancel/replace).
    /// </summary>
    /// <value>The ID of the Order that was replaced by this Order (only provided if this Order was created as part of a cancel/replace).</value>
    [DataMember(Name="replacesOrderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replacesOrderID")]
    public string ReplacesOrderID { get; set; }

    /// <summary>
    /// The ID of the Order that replaced this Order (only provided if this Order was cancelled as part of a cancel/replace).
    /// </summary>
    /// <value>The ID of the Order that replaced this Order (only provided if this Order was cancelled as part of a cancel/replace).</value>
    [DataMember(Name="replacedByOrderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replacedByOrderID")]
    public string ReplacedByOrderID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketIfTouchedOrder {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  PriceBound: ").Append(PriceBound).Append("\n");
      sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
      sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
      sb.Append("  PositionFill: ").Append(PositionFill).Append("\n");
      sb.Append("  TriggerCondition: ").Append(TriggerCondition).Append("\n");
      sb.Append("  InitialMarketPrice: ").Append(InitialMarketPrice).Append("\n");
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
      sb.Append("  ReplacesOrderID: ").Append(ReplacesOrderID).Append("\n");
      sb.Append("  ReplacedByOrderID: ").Append(ReplacedByOrderID).Append("\n");
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
