using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A TrailingStopLossOrderTransaction represents the creation of a TrailingStopLoss Order in the user&#39;s Account.
  /// </summary>
  [DataContract]
  public class TrailingStopLossOrderTransaction {
    /// <summary>
    /// The Transaction's Identifier.
    /// </summary>
    /// <value>The Transaction's Identifier.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The date/time when the Transaction was created.
    /// </summary>
    /// <value>The date/time when the Transaction was created.</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public string Time { get; set; }

    /// <summary>
    /// The ID of the user that initiated the creation of the Transaction.
    /// </summary>
    /// <value>The ID of the user that initiated the creation of the Transaction.</value>
    [DataMember(Name="userID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userID")]
    public int? UserID { get; set; }

    /// <summary>
    /// The ID of the Account the Transaction was created for.
    /// </summary>
    /// <value>The ID of the Account the Transaction was created for.</value>
    [DataMember(Name="accountID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountID")]
    public string AccountID { get; set; }

    /// <summary>
    /// The ID of the \"batch\" that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously.
    /// </summary>
    /// <value>The ID of the \"batch\" that the Transaction belongs to. Transactions in the same batch are applied to the Account simultaneously.</value>
    [DataMember(Name="batchID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "batchID")]
    public string BatchID { get; set; }

    /// <summary>
    /// The Request ID of the request which generated the transaction.
    /// </summary>
    /// <value>The Request ID of the request which generated the transaction.</value>
    [DataMember(Name="requestID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestID")]
    public string RequestID { get; set; }

    /// <summary>
    /// The Type of the Transaction. Always set to \"TRAILING_STOP_LOSS_ORDER\" in a TrailingStopLossOrderTransaction.
    /// </summary>
    /// <value>The Type of the Transaction. Always set to \"TRAILING_STOP_LOSS_ORDER\" in a TrailingStopLossOrderTransaction.</value>
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
    /// The reason that the Trailing Stop Loss Order was initiated
    /// </summary>
    /// <value>The reason that the Trailing Stop Loss Order was initiated</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Gets or Sets ClientExtensions
    /// </summary>
    [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientExtensions")]
    public ClientExtensions ClientExtensions { get; set; }

    /// <summary>
    /// The ID of the OrderFill Transaction that caused this Order to be created (only provided if this Order was created automatically when another Order was filled).
    /// </summary>
    /// <value>The ID of the OrderFill Transaction that caused this Order to be created (only provided if this Order was created automatically when another Order was filled).</value>
    [DataMember(Name="orderFillTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderFillTransactionID")]
    public string OrderFillTransactionID { get; set; }

    /// <summary>
    /// The ID of the Order that this Order replaces (only provided if this Order replaces an existing Order).
    /// </summary>
    /// <value>The ID of the Order that this Order replaces (only provided if this Order replaces an existing Order).</value>
    [DataMember(Name="replacesOrderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "replacesOrderID")]
    public string ReplacesOrderID { get; set; }

    /// <summary>
    /// The ID of the Transaction that cancels the replaced Order (only provided if this Order replaces an existing Order).
    /// </summary>
    /// <value>The ID of the Transaction that cancels the replaced Order (only provided if this Order replaces an existing Order).</value>
    [DataMember(Name="cancellingTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cancellingTransactionID")]
    public string CancellingTransactionID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TrailingStopLossOrderTransaction {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  UserID: ").Append(UserID).Append("\n");
      sb.Append("  AccountID: ").Append(AccountID).Append("\n");
      sb.Append("  BatchID: ").Append(BatchID).Append("\n");
      sb.Append("  RequestID: ").Append(RequestID).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TradeID: ").Append(TradeID).Append("\n");
      sb.Append("  ClientTradeID: ").Append(ClientTradeID).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
      sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
      sb.Append("  TriggerCondition: ").Append(TriggerCondition).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
      sb.Append("  OrderFillTransactionID: ").Append(OrderFillTransactionID).Append("\n");
      sb.Append("  ReplacesOrderID: ").Append(ReplacesOrderID).Append("\n");
      sb.Append("  CancellingTransactionID: ").Append(CancellingTransactionID).Append("\n");
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
