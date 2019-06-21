using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The representation of a Position for a single direction (long or short).
  /// </summary>
  [DataContract]
  public class PositionSide {
    /// <summary>
    /// Number of units in the position (negative value indicates short position, positive indicates long position).
    /// </summary>
    /// <value>Number of units in the position (negative value indicates short position, positive indicates long position).</value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public string Units { get; set; }

    /// <summary>
    /// Volume-weighted average of the underlying Trade open prices for the Position.
    /// </summary>
    /// <value>Volume-weighted average of the underlying Trade open prices for the Position.</value>
    [DataMember(Name="averagePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "averagePrice")]
    public string AveragePrice { get; set; }

    /// <summary>
    /// List of the open Trade IDs which contribute to the open Position.
    /// </summary>
    /// <value>List of the open Trade IDs which contribute to the open Position.</value>
    [DataMember(Name="tradeIDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeIDs")]
    public List<string> TradeIDs { get; set; }

    /// <summary>
    /// Profit/loss realized by the PositionSide over the lifetime of the Account.
    /// </summary>
    /// <value>Profit/loss realized by the PositionSide over the lifetime of the Account.</value>
    [DataMember(Name="pl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pl")]
    public string Pl { get; set; }

    /// <summary>
    /// The unrealized profit/loss of all open Trades that contribute to this PositionSide.
    /// </summary>
    /// <value>The unrealized profit/loss of all open Trades that contribute to this PositionSide.</value>
    [DataMember(Name="unrealizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unrealizedPL")]
    public string UnrealizedPL { get; set; }

    /// <summary>
    /// Profit/loss realized by the PositionSide since the Account's resettablePL was last reset by the client.
    /// </summary>
    /// <value>Profit/loss realized by the PositionSide since the Account's resettablePL was last reset by the client.</value>
    [DataMember(Name="resettablePL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resettablePL")]
    public string ResettablePL { get; set; }

    /// <summary>
    /// The total amount of financing paid/collected for this PositionSide over the lifetime of the Account.
    /// </summary>
    /// <value>The total amount of financing paid/collected for this PositionSide over the lifetime of the Account.</value>
    [DataMember(Name="financing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financing")]
    public string Financing { get; set; }

    /// <summary>
    /// The total amount of fees charged over the lifetime of the Account for the execution of guaranteed Stop Loss Orders attached to Trades for this PositionSide.
    /// </summary>
    /// <value>The total amount of fees charged over the lifetime of the Account for the execution of guaranteed Stop Loss Orders attached to Trades for this PositionSide.</value>
    [DataMember(Name="guaranteedExecutionFees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guaranteedExecutionFees")]
    public string GuaranteedExecutionFees { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PositionSide {\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
      sb.Append("  AveragePrice: ").Append(AveragePrice).Append("\n");
      sb.Append("  TradeIDs: ").Append(TradeIDs).Append("\n");
      sb.Append("  Pl: ").Append(Pl).Append("\n");
      sb.Append("  UnrealizedPL: ").Append(UnrealizedPL).Append("\n");
      sb.Append("  ResettablePL: ").Append(ResettablePL).Append("\n");
      sb.Append("  Financing: ").Append(Financing).Append("\n");
      sb.Append("  GuaranteedExecutionFees: ").Append(GuaranteedExecutionFees).Append("\n");
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
