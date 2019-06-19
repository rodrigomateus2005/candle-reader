using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A TradeReduce object represents a Trade for an instrument that was reduced (either partially or fully) in an Account. It is found embedded in Transactions that affect the position of an instrument in the account, specifically the OrderFill Transaction.
  /// </summary>
  [DataContract]
  public class TradeReduce {
    /// <summary>
    /// The ID of the Trade that was reduced or closed
    /// </summary>
    /// <value>The ID of the Trade that was reduced or closed</value>
    [DataMember(Name="tradeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeID")]
    public string TradeID { get; set; }

    /// <summary>
    /// The number of units that the Trade was reduced by
    /// </summary>
    /// <value>The number of units that the Trade was reduced by</value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public string Units { get; set; }

    /// <summary>
    /// The average price that the units were closed at. This price may be clamped for guaranteed Stop Loss Orders.
    /// </summary>
    /// <value>The average price that the units were closed at. This price may be clamped for guaranteed Stop Loss Orders.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// The PL realized when reducing the Trade
    /// </summary>
    /// <value>The PL realized when reducing the Trade</value>
    [DataMember(Name="realizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "realizedPL")]
    public string RealizedPL { get; set; }

    /// <summary>
    /// The financing paid/collected when reducing the Trade
    /// </summary>
    /// <value>The financing paid/collected when reducing the Trade</value>
    [DataMember(Name="financing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financing")]
    public string Financing { get; set; }

    /// <summary>
    /// This is the fee that is charged for closing the Trade if it has a guaranteed Stop Loss Order attached to it.
    /// </summary>
    /// <value>This is the fee that is charged for closing the Trade if it has a guaranteed Stop Loss Order attached to it.</value>
    [DataMember(Name="guaranteedExecutionFee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guaranteedExecutionFee")]
    public string GuaranteedExecutionFee { get; set; }

    /// <summary>
    /// The half spread cost for the trade reduce/close. This can be a positive or negative value and is represented in the home currency of the Account.
    /// </summary>
    /// <value>The half spread cost for the trade reduce/close. This can be a positive or negative value and is represented in the home currency of the Account.</value>
    [DataMember(Name="halfSpreadCost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "halfSpreadCost")]
    public string HalfSpreadCost { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TradeReduce {\n");
      sb.Append("  TradeID: ").Append(TradeID).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  RealizedPL: ").Append(RealizedPL).Append("\n");
      sb.Append("  Financing: ").Append(Financing).Append("\n");
      sb.Append("  GuaranteedExecutionFee: ").Append(GuaranteedExecutionFee).Append("\n");
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
