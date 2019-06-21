using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The specification of a Position within an Account.
  /// </summary>
  [DataContract]
  public class Position {
    /// <summary>
    /// The Position's Instrument.
    /// </summary>
    /// <value>The Position's Instrument.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// Profit/loss realized by the Position over the lifetime of the Account.
    /// </summary>
    /// <value>Profit/loss realized by the Position over the lifetime of the Account.</value>
    [DataMember(Name="pl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pl")]
    public string Pl { get; set; }

    /// <summary>
    /// The unrealized profit/loss of all open Trades that contribute to this Position.
    /// </summary>
    /// <value>The unrealized profit/loss of all open Trades that contribute to this Position.</value>
    [DataMember(Name="unrealizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unrealizedPL")]
    public string UnrealizedPL { get; set; }

    /// <summary>
    /// Margin currently used by the Position.
    /// </summary>
    /// <value>Margin currently used by the Position.</value>
    [DataMember(Name="marginUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginUsed")]
    public string MarginUsed { get; set; }

    /// <summary>
    /// Profit/loss realized by the Position since the Account's resettablePL was last reset by the client.
    /// </summary>
    /// <value>Profit/loss realized by the Position since the Account's resettablePL was last reset by the client.</value>
    [DataMember(Name="resettablePL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resettablePL")]
    public string ResettablePL { get; set; }

    /// <summary>
    /// The total amount of financing paid/collected for this instrument over the lifetime of the Account.
    /// </summary>
    /// <value>The total amount of financing paid/collected for this instrument over the lifetime of the Account.</value>
    [DataMember(Name="financing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financing")]
    public string Financing { get; set; }

    /// <summary>
    /// The total amount of commission paid for this instrument over the lifetime of the Account.
    /// </summary>
    /// <value>The total amount of commission paid for this instrument over the lifetime of the Account.</value>
    [DataMember(Name="commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commission")]
    public string Commission { get; set; }

    /// <summary>
    /// The total amount of fees charged over the lifetime of the Account for the execution of guaranteed Stop Loss Orders for this instrument.
    /// </summary>
    /// <value>The total amount of fees charged over the lifetime of the Account for the execution of guaranteed Stop Loss Orders for this instrument.</value>
    [DataMember(Name="guaranteedExecutionFees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guaranteedExecutionFees")]
    public string GuaranteedExecutionFees { get; set; }

    /// <summary>
    /// Gets or Sets Long
    /// </summary>
    [DataMember(Name="long", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long")]
    public PositionSide Long { get; set; }

    /// <summary>
    /// Gets or Sets Short
    /// </summary>
    [DataMember(Name="short", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short")]
    public PositionSide Short { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Position {\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Pl: ").Append(Pl).Append("\n");
      sb.Append("  UnrealizedPL: ").Append(UnrealizedPL).Append("\n");
      sb.Append("  MarginUsed: ").Append(MarginUsed).Append("\n");
      sb.Append("  ResettablePL: ").Append(ResettablePL).Append("\n");
      sb.Append("  Financing: ").Append(Financing).Append("\n");
      sb.Append("  Commission: ").Append(Commission).Append("\n");
      sb.Append("  GuaranteedExecutionFees: ").Append(GuaranteedExecutionFees).Append("\n");
      sb.Append("  Long: ").Append(Long).Append("\n");
      sb.Append("  Short: ").Append(Short).Append("\n");
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
