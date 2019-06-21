using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An OrderFillTransaction represents the filling of an Order in the client&#39;s Account.
  /// </summary>
  [DataContract]
  public class OrderFillTransaction {
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
    /// The Type of the Transaction. Always set to \"ORDER_FILL\" for an OrderFillTransaction.
    /// </summary>
    /// <value>The Type of the Transaction. Always set to \"ORDER_FILL\" for an OrderFillTransaction.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The ID of the Order filled.
    /// </summary>
    /// <value>The ID of the Order filled.</value>
    [DataMember(Name="orderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderID")]
    public string OrderID { get; set; }

    /// <summary>
    /// The client Order ID of the Order filled (only provided if the client has assigned one).
    /// </summary>
    /// <value>The client Order ID of the Order filled (only provided if the client has assigned one).</value>
    [DataMember(Name="clientOrderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientOrderID")]
    public string ClientOrderID { get; set; }

    /// <summary>
    /// The name of the filled Order's instrument.
    /// </summary>
    /// <value>The name of the filled Order's instrument.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// The number of units filled by the OrderFill.
    /// </summary>
    /// <value>The number of units filled by the OrderFill.</value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public string Units { get; set; }

    /// <summary>
    /// This is the conversion factor in effect for the Account at the time of the OrderFill for converting any gains realized in Instrument quote units into units of the Account's home currency.
    /// </summary>
    /// <value>This is the conversion factor in effect for the Account at the time of the OrderFill for converting any gains realized in Instrument quote units into units of the Account's home currency.</value>
    [DataMember(Name="gainQuoteHomeConversionFactor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gainQuoteHomeConversionFactor")]
    public string GainQuoteHomeConversionFactor { get; set; }

    /// <summary>
    /// This is the conversion factor in effect for the Account at the time of the OrderFill for converting any losses realized in Instrument quote units into units of the Account's home currency.
    /// </summary>
    /// <value>This is the conversion factor in effect for the Account at the time of the OrderFill for converting any losses realized in Instrument quote units into units of the Account's home currency.</value>
    [DataMember(Name="lossQuoteHomeConversionFactor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lossQuoteHomeConversionFactor")]
    public string LossQuoteHomeConversionFactor { get; set; }

    /// <summary>
    /// This field is now deprecated and should no longer be used. The individual tradesClosed, tradeReduced and tradeOpened fields contain the exact/official price each unit was filled at.
    /// </summary>
    /// <value>This field is now deprecated and should no longer be used. The individual tradesClosed, tradeReduced and tradeOpened fields contain the exact/official price each unit was filled at.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// The price that all of the units of the OrderFill should have been filled at, in the absence of guaranteed price execution. This factors in the Account's current ClientPrice, used liquidity and the units of the OrderFill only. If no Trades were closed with their price clamped for guaranteed stop loss enforcement, then this value will match the price fields of each Trade opened, closed, and reduced, and they will all be the exact same.
    /// </summary>
    /// <value>The price that all of the units of the OrderFill should have been filled at, in the absence of guaranteed price execution. This factors in the Account's current ClientPrice, used liquidity and the units of the OrderFill only. If no Trades were closed with their price clamped for guaranteed stop loss enforcement, then this value will match the price fields of each Trade opened, closed, and reduced, and they will all be the exact same.</value>
    [DataMember(Name="fullVWAP", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullVWAP")]
    public string FullVWAP { get; set; }

    /// <summary>
    /// Gets or Sets FullPrice
    /// </summary>
    [DataMember(Name="fullPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fullPrice")]
    public ClientPrice FullPrice { get; set; }

    /// <summary>
    /// The reason that an Order was filled
    /// </summary>
    /// <value>The reason that an Order was filled</value>
    [DataMember(Name="reason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The profit or loss incurred when the Order was filled.
    /// </summary>
    /// <value>The profit or loss incurred when the Order was filled.</value>
    [DataMember(Name="pl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pl")]
    public string Pl { get; set; }

    /// <summary>
    /// The financing paid or collected when the Order was filled.
    /// </summary>
    /// <value>The financing paid or collected when the Order was filled.</value>
    [DataMember(Name="financing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financing")]
    public string Financing { get; set; }

    /// <summary>
    /// The commission charged in the Account's home currency as a result of filling the Order. The commission is always represented as a positive quantity of the Account's home currency, however it reduces the balance in the Account.
    /// </summary>
    /// <value>The commission charged in the Account's home currency as a result of filling the Order. The commission is always represented as a positive quantity of the Account's home currency, however it reduces the balance in the Account.</value>
    [DataMember(Name="commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commission")]
    public string Commission { get; set; }

    /// <summary>
    /// The total guaranteed execution fees charged for all Trades opened, closed or reduced with guaranteed Stop Loss Orders.
    /// </summary>
    /// <value>The total guaranteed execution fees charged for all Trades opened, closed or reduced with guaranteed Stop Loss Orders.</value>
    [DataMember(Name="guaranteedExecutionFee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guaranteedExecutionFee")]
    public string GuaranteedExecutionFee { get; set; }

    /// <summary>
    /// The Account's balance after the Order was filled.
    /// </summary>
    /// <value>The Account's balance after the Order was filled.</value>
    [DataMember(Name="accountBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountBalance")]
    public string AccountBalance { get; set; }

    /// <summary>
    /// Gets or Sets TradeOpened
    /// </summary>
    [DataMember(Name="tradeOpened", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeOpened")]
    public TradeOpen TradeOpened { get; set; }

    /// <summary>
    /// The Trades that were closed when the Order was filled (only provided if filling the Order resulted in a closing open Trades).
    /// </summary>
    /// <value>The Trades that were closed when the Order was filled (only provided if filling the Order resulted in a closing open Trades).</value>
    [DataMember(Name="tradesClosed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradesClosed")]
    public List<TradeReduce> TradesClosed { get; set; }

    /// <summary>
    /// Gets or Sets TradeReduced
    /// </summary>
    [DataMember(Name="tradeReduced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeReduced")]
    public TradeReduce TradeReduced { get; set; }

    /// <summary>
    /// The half spread cost for the OrderFill, which is the sum of the halfSpreadCost values in the tradeOpened, tradesClosed and tradeReduced fields. This can be a positive or negative value and is represented in the home currency of the Account.
    /// </summary>
    /// <value>The half spread cost for the OrderFill, which is the sum of the halfSpreadCost values in the tradeOpened, tradesClosed and tradeReduced fields. This can be a positive or negative value and is represented in the home currency of the Account.</value>
    [DataMember(Name="halfSpreadCost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "halfSpreadCost")]
    public string HalfSpreadCost { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderFillTransaction {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  UserID: ").Append(UserID).Append("\n");
      sb.Append("  AccountID: ").Append(AccountID).Append("\n");
      sb.Append("  BatchID: ").Append(BatchID).Append("\n");
      sb.Append("  RequestID: ").Append(RequestID).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  OrderID: ").Append(OrderID).Append("\n");
      sb.Append("  ClientOrderID: ").Append(ClientOrderID).Append("\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
      sb.Append("  GainQuoteHomeConversionFactor: ").Append(GainQuoteHomeConversionFactor).Append("\n");
      sb.Append("  LossQuoteHomeConversionFactor: ").Append(LossQuoteHomeConversionFactor).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  FullVWAP: ").Append(FullVWAP).Append("\n");
      sb.Append("  FullPrice: ").Append(FullPrice).Append("\n");
      sb.Append("  Reason: ").Append(Reason).Append("\n");
      sb.Append("  Pl: ").Append(Pl).Append("\n");
      sb.Append("  Financing: ").Append(Financing).Append("\n");
      sb.Append("  Commission: ").Append(Commission).Append("\n");
      sb.Append("  GuaranteedExecutionFee: ").Append(GuaranteedExecutionFee).Append("\n");
      sb.Append("  AccountBalance: ").Append(AccountBalance).Append("\n");
      sb.Append("  TradeOpened: ").Append(TradeOpened).Append("\n");
      sb.Append("  TradesClosed: ").Append(TradesClosed).Append("\n");
      sb.Append("  TradeReduced: ").Append(TradeReduced).Append("\n");
      sb.Append("  HalfSpreadCost: ").Append(HalfSpreadCost).Append("\n");
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
