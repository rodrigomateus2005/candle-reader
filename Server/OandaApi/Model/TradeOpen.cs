using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A TradeOpen object represents a Trade for an instrument that was opened in an Account. It is found embedded in Transactions that affect the position of an instrument in the Account, specifically the OrderFill Transaction.
  /// </summary>
  [DataContract]
  public class TradeOpen {
    /// <summary>
    /// The ID of the Trade that was opened
    /// </summary>
    /// <value>The ID of the Trade that was opened</value>
    [DataMember(Name="tradeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeID")]
    public string TradeID { get; set; }

    /// <summary>
    /// The number of units opened by the Trade
    /// </summary>
    /// <value>The number of units opened by the Trade</value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public string Units { get; set; }

    /// <summary>
    /// The average price that the units were opened at.
    /// </summary>
    /// <value>The average price that the units were opened at.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// This is the fee charged for opening the trade if it has a guaranteed Stop Loss Order attached to it.
    /// </summary>
    /// <value>This is the fee charged for opening the trade if it has a guaranteed Stop Loss Order attached to it.</value>
    [DataMember(Name="guaranteedExecutionFee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guaranteedExecutionFee")]
    public string GuaranteedExecutionFee { get; set; }

    /// <summary>
    /// Gets or Sets ClientExtensions
    /// </summary>
    [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientExtensions")]
    public ClientExtensions ClientExtensions { get; set; }

    /// <summary>
    /// The half spread cost for the trade open. This can be a positive or negative value and is represented in the home currency of the Account.
    /// </summary>
    /// <value>The half spread cost for the trade open. This can be a positive or negative value and is represented in the home currency of the Account.</value>
    [DataMember(Name="halfSpreadCost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "halfSpreadCost")]
    public string HalfSpreadCost { get; set; }

    /// <summary>
    /// The margin required at the time the Trade was created. Note, this is the 'pure' margin required, it is not the 'effective' margin used that factors in the trade risk if a GSLO is attached to the trade.
    /// </summary>
    /// <value>The margin required at the time the Trade was created. Note, this is the 'pure' margin required, it is not the 'effective' margin used that factors in the trade risk if a GSLO is attached to the trade.</value>
    [DataMember(Name="initialMarginRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "initialMarginRequired")]
    public string InitialMarginRequired { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TradeOpen {\n");
      sb.Append("  TradeID: ").Append(TradeID).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  GuaranteedExecutionFee: ").Append(GuaranteedExecutionFee).Append("\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
      sb.Append("  HalfSpreadCost: ").Append(HalfSpreadCost).Append("\n");
      sb.Append("  InitialMarginRequired: ").Append(InitialMarginRequired).Append("\n");
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
