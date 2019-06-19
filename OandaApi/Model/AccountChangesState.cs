using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An AccountState Object is used to represent an Account&#39;s current price-dependent state. Price-dependent Account state is dependent on OANDA&#39;s current Prices, and includes things like unrealized PL, NAV and Trailing Stop Loss Order state.
  /// </summary>
  [DataContract]
  public class AccountChangesState {
    /// <summary>
    /// The total unrealized profit/loss for all Trades currently open in the Account.
    /// </summary>
    /// <value>The total unrealized profit/loss for all Trades currently open in the Account.</value>
    [DataMember(Name="unrealizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unrealizedPL")]
    public string UnrealizedPL { get; set; }

    /// <summary>
    /// The net asset value of the Account. Equal to Account balance + unrealizedPL.
    /// </summary>
    /// <value>The net asset value of the Account. Equal to Account balance + unrealizedPL.</value>
    [DataMember(Name="NAV", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NAV")]
    public string NAV { get; set; }

    /// <summary>
    /// Margin currently used for the Account.
    /// </summary>
    /// <value>Margin currently used for the Account.</value>
    [DataMember(Name="marginUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginUsed")]
    public string MarginUsed { get; set; }

    /// <summary>
    /// Margin available for Account currency.
    /// </summary>
    /// <value>Margin available for Account currency.</value>
    [DataMember(Name="marginAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginAvailable")]
    public string MarginAvailable { get; set; }

    /// <summary>
    /// The value of the Account's open positions represented in the Account's home currency.
    /// </summary>
    /// <value>The value of the Account's open positions represented in the Account's home currency.</value>
    [DataMember(Name="positionValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "positionValue")]
    public string PositionValue { get; set; }

    /// <summary>
    /// The Account's margin closeout unrealized PL.
    /// </summary>
    /// <value>The Account's margin closeout unrealized PL.</value>
    [DataMember(Name="marginCloseoutUnrealizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginCloseoutUnrealizedPL")]
    public string MarginCloseoutUnrealizedPL { get; set; }

    /// <summary>
    /// The Account's margin closeout NAV.
    /// </summary>
    /// <value>The Account's margin closeout NAV.</value>
    [DataMember(Name="marginCloseoutNAV", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginCloseoutNAV")]
    public string MarginCloseoutNAV { get; set; }

    /// <summary>
    /// The Account's margin closeout margin used.
    /// </summary>
    /// <value>The Account's margin closeout margin used.</value>
    [DataMember(Name="marginCloseoutMarginUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginCloseoutMarginUsed")]
    public string MarginCloseoutMarginUsed { get; set; }

    /// <summary>
    /// The Account's margin closeout percentage. When this value is 1.0 or above the Account is in a margin closeout situation.
    /// </summary>
    /// <value>The Account's margin closeout percentage. When this value is 1.0 or above the Account is in a margin closeout situation.</value>
    [DataMember(Name="marginCloseoutPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginCloseoutPercent")]
    public string MarginCloseoutPercent { get; set; }

    /// <summary>
    /// The value of the Account's open positions as used for margin closeout calculations represented in the Account's home currency.
    /// </summary>
    /// <value>The value of the Account's open positions as used for margin closeout calculations represented in the Account's home currency.</value>
    [DataMember(Name="marginCloseoutPositionValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginCloseoutPositionValue")]
    public string MarginCloseoutPositionValue { get; set; }

    /// <summary>
    /// The current WithdrawalLimit for the account which will be zero or a positive value indicating how much can be withdrawn from the account.
    /// </summary>
    /// <value>The current WithdrawalLimit for the account which will be zero or a positive value indicating how much can be withdrawn from the account.</value>
    [DataMember(Name="withdrawalLimit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "withdrawalLimit")]
    public string WithdrawalLimit { get; set; }

    /// <summary>
    /// The Account's margin call margin used.
    /// </summary>
    /// <value>The Account's margin call margin used.</value>
    [DataMember(Name="marginCallMarginUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginCallMarginUsed")]
    public string MarginCallMarginUsed { get; set; }

    /// <summary>
    /// The Account's margin call percentage. When this value is 1.0 or above the Account is in a margin call situation.
    /// </summary>
    /// <value>The Account's margin call percentage. When this value is 1.0 or above the Account is in a margin call situation.</value>
    [DataMember(Name="marginCallPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginCallPercent")]
    public string MarginCallPercent { get; set; }

    /// <summary>
    /// The price-dependent state of each pending Order in the Account.
    /// </summary>
    /// <value>The price-dependent state of each pending Order in the Account.</value>
    [DataMember(Name="orders", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orders")]
    public List<DynamicOrderState> Orders { get; set; }

    /// <summary>
    /// The price-dependent state for each open Trade in the Account.
    /// </summary>
    /// <value>The price-dependent state for each open Trade in the Account.</value>
    [DataMember(Name="trades", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trades")]
    public List<CalculatedTradeState> Trades { get; set; }

    /// <summary>
    /// The price-dependent state for each open Position in the Account.
    /// </summary>
    /// <value>The price-dependent state for each open Position in the Account.</value>
    [DataMember(Name="positions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "positions")]
    public List<CalculatedPositionState> Positions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountChangesState {\n");
      sb.Append("  UnrealizedPL: ").Append(UnrealizedPL).Append("\n");
      sb.Append("  NAV: ").Append(NAV).Append("\n");
      sb.Append("  MarginUsed: ").Append(MarginUsed).Append("\n");
      sb.Append("  MarginAvailable: ").Append(MarginAvailable).Append("\n");
      sb.Append("  PositionValue: ").Append(PositionValue).Append("\n");
      sb.Append("  MarginCloseoutUnrealizedPL: ").Append(MarginCloseoutUnrealizedPL).Append("\n");
      sb.Append("  MarginCloseoutNAV: ").Append(MarginCloseoutNAV).Append("\n");
      sb.Append("  MarginCloseoutMarginUsed: ").Append(MarginCloseoutMarginUsed).Append("\n");
      sb.Append("  MarginCloseoutPercent: ").Append(MarginCloseoutPercent).Append("\n");
      sb.Append("  MarginCloseoutPositionValue: ").Append(MarginCloseoutPositionValue).Append("\n");
      sb.Append("  WithdrawalLimit: ").Append(WithdrawalLimit).Append("\n");
      sb.Append("  MarginCallMarginUsed: ").Append(MarginCallMarginUsed).Append("\n");
      sb.Append("  MarginCallPercent: ").Append(MarginCallPercent).Append("\n");
      sb.Append("  Orders: ").Append(Orders).Append("\n");
      sb.Append("  Trades: ").Append(Trades).Append("\n");
      sb.Append("  Positions: ").Append(Positions).Append("\n");
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
