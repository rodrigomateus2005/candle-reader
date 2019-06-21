using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A FixedPriceOrder is an order that is filled immediately upon creation using a fixed price.
  /// </summary>
  [DataContract]
  public class FixedPriceOrder {
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
    /// The type of the Order. Always set to \"FIXED_PRICE\" for Fixed Price Orders.
    /// </summary>
    /// <value>The type of the Order. Always set to \"FIXED_PRICE\" for Fixed Price Orders.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The Fixed Price Order's Instrument.
    /// </summary>
    /// <value>The Fixed Price Order's Instrument.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// The quantity requested to be filled by the Fixed Price Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.
    /// </summary>
    /// <value>The quantity requested to be filled by the Fixed Price Order. A posititive number of units results in a long Order, and a negative number of units results in a short Order.</value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public string Units { get; set; }

    /// <summary>
    /// The price specified for the Fixed Price Order. This price is the exact price that the Fixed Price Order will be filled at.
    /// </summary>
    /// <value>The price specified for the Fixed Price Order. This price is the exact price that the Fixed Price Order will be filled at.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// Specification of how Positions in the Account are modified when the Order is filled.
    /// </summary>
    /// <value>Specification of how Positions in the Account are modified when the Order is filled.</value>
    [DataMember(Name="positionFill", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "positionFill")]
    public string PositionFill { get; set; }

    /// <summary>
    /// The state that the trade resulting from the Fixed Price Order should be set to.
    /// </summary>
    /// <value>The state that the trade resulting from the Fixed Price Order should be set to.</value>
    [DataMember(Name="tradeState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeState")]
    public string TradeState { get; set; }

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
      sb.Append("class FixedPriceOrder {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  PositionFill: ").Append(PositionFill).Append("\n");
      sb.Append("  TradeState: ").Append(TradeState).Append("\n");
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
