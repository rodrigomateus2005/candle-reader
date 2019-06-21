using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The summary of a Trade within an Account. This representation does not provide the full details of the Trade&#39;s dependent Orders.
  /// </summary>
  [DataContract]
  public class TradeSummary {
    /// <summary>
    /// The Trade's identifier, unique within the Trade's Account.
    /// </summary>
    /// <value>The Trade's identifier, unique within the Trade's Account.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The Trade's Instrument.
    /// </summary>
    /// <value>The Trade's Instrument.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// The execution price of the Trade.
    /// </summary>
    /// <value>The execution price of the Trade.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// The date/time when the Trade was opened.
    /// </summary>
    /// <value>The date/time when the Trade was opened.</value>
    [DataMember(Name="openTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openTime")]
    public string OpenTime { get; set; }

    /// <summary>
    /// The current state of the Trade.
    /// </summary>
    /// <value>The current state of the Trade.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The initial size of the Trade. Negative values indicate a short Trade, and positive values indicate a long Trade.
    /// </summary>
    /// <value>The initial size of the Trade. Negative values indicate a short Trade, and positive values indicate a long Trade.</value>
    [DataMember(Name="initialUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialUnits")]
    public string InitialUnits { get; set; }

    /// <summary>
    /// The margin required at the time the Trade was created. Note, this is the 'pure' margin required, it is not the 'effective' margin used that factors in the trade risk if a GSLO is attached to the trade.
    /// </summary>
    /// <value>The margin required at the time the Trade was created. Note, this is the 'pure' margin required, it is not the 'effective' margin used that factors in the trade risk if a GSLO is attached to the trade.</value>
    [DataMember(Name="initialMarginRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialMarginRequired")]
    public string InitialMarginRequired { get; set; }

    /// <summary>
    /// The number of units currently open for the Trade. This value is reduced to 0.0 as the Trade is closed.
    /// </summary>
    /// <value>The number of units currently open for the Trade. This value is reduced to 0.0 as the Trade is closed.</value>
    [DataMember(Name="currentUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentUnits")]
    public string CurrentUnits { get; set; }

    /// <summary>
    /// The total profit/loss realized on the closed portion of the Trade.
    /// </summary>
    /// <value>The total profit/loss realized on the closed portion of the Trade.</value>
    [DataMember(Name="realizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realizedPL")]
    public string RealizedPL { get; set; }

    /// <summary>
    /// The unrealized profit/loss on the open portion of the Trade.
    /// </summary>
    /// <value>The unrealized profit/loss on the open portion of the Trade.</value>
    [DataMember(Name="unrealizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unrealizedPL")]
    public string UnrealizedPL { get; set; }

    /// <summary>
    /// Margin currently used by the Trade.
    /// </summary>
    /// <value>Margin currently used by the Trade.</value>
    [DataMember(Name="marginUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginUsed")]
    public string MarginUsed { get; set; }

    /// <summary>
    /// The average closing price of the Trade. Only present if the Trade has been closed or reduced at least once.
    /// </summary>
    /// <value>The average closing price of the Trade. Only present if the Trade has been closed or reduced at least once.</value>
    [DataMember(Name="averageClosePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "averageClosePrice")]
    public string AverageClosePrice { get; set; }

    /// <summary>
    /// The IDs of the Transactions that have closed portions of this Trade.
    /// </summary>
    /// <value>The IDs of the Transactions that have closed portions of this Trade.</value>
    [DataMember(Name="closingTransactionIDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closingTransactionIDs")]
    public List<string> ClosingTransactionIDs { get; set; }

    /// <summary>
    /// The financing paid/collected for this Trade.
    /// </summary>
    /// <value>The financing paid/collected for this Trade.</value>
    [DataMember(Name="financing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financing")]
    public string Financing { get; set; }

    /// <summary>
    /// The date/time when the Trade was fully closed. Only provided for Trades whose state is CLOSED.
    /// </summary>
    /// <value>The date/time when the Trade was fully closed. Only provided for Trades whose state is CLOSED.</value>
    [DataMember(Name="closeTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closeTime")]
    public string CloseTime { get; set; }

    /// <summary>
    /// Gets or Sets ClientExtensions
    /// </summary>
    [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientExtensions")]
    public ClientExtensions ClientExtensions { get; set; }

    /// <summary>
    /// ID of the Trade's Take Profit Order, only provided if such an Order exists.
    /// </summary>
    /// <value>ID of the Trade's Take Profit Order, only provided if such an Order exists.</value>
    [DataMember(Name="takeProfitOrderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takeProfitOrderID")]
    public string TakeProfitOrderID { get; set; }

    /// <summary>
    /// ID of the Trade's Stop Loss Order, only provided if such an Order exists.
    /// </summary>
    /// <value>ID of the Trade's Stop Loss Order, only provided if such an Order exists.</value>
    [DataMember(Name="stopLossOrderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLossOrderID")]
    public string StopLossOrderID { get; set; }

    /// <summary>
    /// ID of the Trade's Trailing Stop Loss Order, only provided if such an Order exists.
    /// </summary>
    /// <value>ID of the Trade's Trailing Stop Loss Order, only provided if such an Order exists.</value>
    [DataMember(Name="trailingStopLossOrderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trailingStopLossOrderID")]
    public string TrailingStopLossOrderID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TradeSummary {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  OpenTime: ").Append(OpenTime).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  InitialUnits: ").Append(InitialUnits).Append("\n");
      sb.Append("  InitialMarginRequired: ").Append(InitialMarginRequired).Append("\n");
      sb.Append("  CurrentUnits: ").Append(CurrentUnits).Append("\n");
      sb.Append("  RealizedPL: ").Append(RealizedPL).Append("\n");
      sb.Append("  UnrealizedPL: ").Append(UnrealizedPL).Append("\n");
      sb.Append("  MarginUsed: ").Append(MarginUsed).Append("\n");
      sb.Append("  AverageClosePrice: ").Append(AverageClosePrice).Append("\n");
      sb.Append("  ClosingTransactionIDs: ").Append(ClosingTransactionIDs).Append("\n");
      sb.Append("  Financing: ").Append(Financing).Append("\n");
      sb.Append("  CloseTime: ").Append(CloseTime).Append("\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
      sb.Append("  TakeProfitOrderID: ").Append(TakeProfitOrderID).Append("\n");
      sb.Append("  StopLossOrderID: ").Append(StopLossOrderID).Append("\n");
      sb.Append("  TrailingStopLossOrderID: ").Append(TrailingStopLossOrderID).Append("\n");
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
