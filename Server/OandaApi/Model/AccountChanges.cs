using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An AccountChanges Object is used to represent the changes to an Account&#39;s Orders, Trades and Positions since a specified Account TransactionID in the past.
  /// </summary>
  [DataContract]
  public class AccountChanges {
    /// <summary>
    /// The Orders created. These Orders may have been filled, cancelled or triggered in the same period.
    /// </summary>
    /// <value>The Orders created. These Orders may have been filled, cancelled or triggered in the same period.</value>
    [DataMember(Name="ordersCreated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ordersCreated")]
    public List<Order> OrdersCreated { get; set; }

    /// <summary>
    /// The Orders cancelled.
    /// </summary>
    /// <value>The Orders cancelled.</value>
    [DataMember(Name="ordersCancelled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ordersCancelled")]
    public List<Order> OrdersCancelled { get; set; }

    /// <summary>
    /// The Orders filled.
    /// </summary>
    /// <value>The Orders filled.</value>
    [DataMember(Name="ordersFilled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ordersFilled")]
    public List<Order> OrdersFilled { get; set; }

    /// <summary>
    /// The Orders triggered.
    /// </summary>
    /// <value>The Orders triggered.</value>
    [DataMember(Name="ordersTriggered", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ordersTriggered")]
    public List<Order> OrdersTriggered { get; set; }

    /// <summary>
    /// The Trades opened.
    /// </summary>
    /// <value>The Trades opened.</value>
    [DataMember(Name="tradesOpened", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradesOpened")]
    public List<TradeSummary> TradesOpened { get; set; }

    /// <summary>
    /// The Trades reduced.
    /// </summary>
    /// <value>The Trades reduced.</value>
    [DataMember(Name="tradesReduced", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradesReduced")]
    public List<TradeSummary> TradesReduced { get; set; }

    /// <summary>
    /// The Trades closed.
    /// </summary>
    /// <value>The Trades closed.</value>
    [DataMember(Name="tradesClosed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradesClosed")]
    public List<TradeSummary> TradesClosed { get; set; }

    /// <summary>
    /// The Positions changed.
    /// </summary>
    /// <value>The Positions changed.</value>
    [DataMember(Name="positions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "positions")]
    public List<Position> Positions { get; set; }

    /// <summary>
    /// The Transactions that have been generated.
    /// </summary>
    /// <value>The Transactions that have been generated.</value>
    [DataMember(Name="transactions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactions")]
    public List<Transaction> Transactions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountChanges {\n");
      sb.Append("  OrdersCreated: ").Append(OrdersCreated).Append("\n");
      sb.Append("  OrdersCancelled: ").Append(OrdersCancelled).Append("\n");
      sb.Append("  OrdersFilled: ").Append(OrdersFilled).Append("\n");
      sb.Append("  OrdersTriggered: ").Append(OrdersTriggered).Append("\n");
      sb.Append("  TradesOpened: ").Append(TradesOpened).Append("\n");
      sb.Append("  TradesReduced: ").Append(TradesReduced).Append("\n");
      sb.Append("  TradesClosed: ").Append(TradesClosed).Append("\n");
      sb.Append("  Positions: ").Append(Positions).Append("\n");
      sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
