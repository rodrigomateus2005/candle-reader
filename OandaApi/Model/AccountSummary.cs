using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A summary representation of a client&#39;s Account. The AccountSummary does not provide to full specification of pending Orders, open Trades and Positions.
  /// </summary>
  [DataContract]
  public class AccountSummary {
    /// <summary>
    /// The Account's identifier
    /// </summary>
    /// <value>The Account's identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Client-assigned alias for the Account. Only provided if the Account has an alias set
    /// </summary>
    /// <value>Client-assigned alias for the Account. Only provided if the Account has an alias set</value>
    [DataMember(Name="alias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alias")]
    public string Alias { get; set; }

    /// <summary>
    /// The home currency of the Account
    /// </summary>
    /// <value>The home currency of the Account</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The current balance of the Account.
    /// </summary>
    /// <value>The current balance of the Account.</value>
    [DataMember(Name="balance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "balance")]
    public string Balance { get; set; }

    /// <summary>
    /// ID of the user that created the Account.
    /// </summary>
    /// <value>ID of the user that created the Account.</value>
    [DataMember(Name="createdByUserID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdByUserID")]
    public int? CreatedByUserID { get; set; }

    /// <summary>
    /// The date/time when the Account was created.
    /// </summary>
    /// <value>The date/time when the Account was created.</value>
    [DataMember(Name="createdTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdTime")]
    public string CreatedTime { get; set; }

    /// <summary>
    /// The current guaranteed Stop Loss Order mode of the Account.
    /// </summary>
    /// <value>The current guaranteed Stop Loss Order mode of the Account.</value>
    [DataMember(Name="guaranteedStopLossOrderMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guaranteedStopLossOrderMode")]
    public string GuaranteedStopLossOrderMode { get; set; }

    /// <summary>
    /// The total profit/loss realized over the lifetime of the Account.
    /// </summary>
    /// <value>The total profit/loss realized over the lifetime of the Account.</value>
    [DataMember(Name="pl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pl")]
    public string Pl { get; set; }

    /// <summary>
    /// The total realized profit/loss for the Account since it was last reset by the client.
    /// </summary>
    /// <value>The total realized profit/loss for the Account since it was last reset by the client.</value>
    [DataMember(Name="resettablePL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resettablePL")]
    public string ResettablePL { get; set; }

    /// <summary>
    /// The date/time that the Account's resettablePL was last reset.
    /// </summary>
    /// <value>The date/time that the Account's resettablePL was last reset.</value>
    [DataMember(Name="resettablePLTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resettablePLTime")]
    public string ResettablePLTime { get; set; }

    /// <summary>
    /// The total amount of financing paid/collected over the lifetime of the Account.
    /// </summary>
    /// <value>The total amount of financing paid/collected over the lifetime of the Account.</value>
    [DataMember(Name="financing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financing")]
    public string Financing { get; set; }

    /// <summary>
    /// The total amount of commission paid over the lifetime of the Account.
    /// </summary>
    /// <value>The total amount of commission paid over the lifetime of the Account.</value>
    [DataMember(Name="commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commission")]
    public string Commission { get; set; }

    /// <summary>
    /// The total amount of fees charged over the lifetime of the Account for the execution of guaranteed Stop Loss Orders.
    /// </summary>
    /// <value>The total amount of fees charged over the lifetime of the Account for the execution of guaranteed Stop Loss Orders.</value>
    [DataMember(Name="guaranteedExecutionFees", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guaranteedExecutionFees")]
    public string GuaranteedExecutionFees { get; set; }

    /// <summary>
    /// Client-provided margin rate override for the Account. The effective margin rate of the Account is the lesser of this value and the OANDA margin rate for the Account's division. This value is only provided if a margin rate override exists for the Account.
    /// </summary>
    /// <value>Client-provided margin rate override for the Account. The effective margin rate of the Account is the lesser of this value and the OANDA margin rate for the Account's division. This value is only provided if a margin rate override exists for the Account.</value>
    [DataMember(Name="marginRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginRate")]
    public string MarginRate { get; set; }

    /// <summary>
    /// The date/time when the Account entered a margin call state. Only provided if the Account is in a margin call.
    /// </summary>
    /// <value>The date/time when the Account entered a margin call state. Only provided if the Account is in a margin call.</value>
    [DataMember(Name="marginCallEnterTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginCallEnterTime")]
    public string MarginCallEnterTime { get; set; }

    /// <summary>
    /// The number of times that the Account's current margin call was extended.
    /// </summary>
    /// <value>The number of times that the Account's current margin call was extended.</value>
    [DataMember(Name="marginCallExtensionCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginCallExtensionCount")]
    public int? MarginCallExtensionCount { get; set; }

    /// <summary>
    /// The date/time of the Account's last margin call extension.
    /// </summary>
    /// <value>The date/time of the Account's last margin call extension.</value>
    [DataMember(Name="lastMarginCallExtensionTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastMarginCallExtensionTime")]
    public string LastMarginCallExtensionTime { get; set; }

    /// <summary>
    /// The number of Trades currently open in the Account.
    /// </summary>
    /// <value>The number of Trades currently open in the Account.</value>
    [DataMember(Name="openTradeCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openTradeCount")]
    public int? OpenTradeCount { get; set; }

    /// <summary>
    /// The number of Positions currently open in the Account.
    /// </summary>
    /// <value>The number of Positions currently open in the Account.</value>
    [DataMember(Name="openPositionCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openPositionCount")]
    public int? OpenPositionCount { get; set; }

    /// <summary>
    /// The number of Orders currently pending in the Account.
    /// </summary>
    /// <value>The number of Orders currently pending in the Account.</value>
    [DataMember(Name="pendingOrderCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pendingOrderCount")]
    public int? PendingOrderCount { get; set; }

    /// <summary>
    /// Flag indicating that the Account has hedging enabled.
    /// </summary>
    /// <value>Flag indicating that the Account has hedging enabled.</value>
    [DataMember(Name="hedgingEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hedgingEnabled")]
    public bool? HedgingEnabled { get; set; }

    /// <summary>
    /// The date/time of the last order that was filled for this account.
    /// </summary>
    /// <value>The date/time of the last order that was filled for this account.</value>
    [DataMember(Name="lastOrderFillTimestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastOrderFillTimestamp")]
    public string LastOrderFillTimestamp { get; set; }

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
    /// The ID of the last Transaction created for the Account.
    /// </summary>
    /// <value>The ID of the last Transaction created for the Account.</value>
    [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransactionID")]
    public string LastTransactionID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountSummary {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Balance: ").Append(Balance).Append("\n");
      sb.Append("  CreatedByUserID: ").Append(CreatedByUserID).Append("\n");
      sb.Append("  CreatedTime: ").Append(CreatedTime).Append("\n");
      sb.Append("  GuaranteedStopLossOrderMode: ").Append(GuaranteedStopLossOrderMode).Append("\n");
      sb.Append("  Pl: ").Append(Pl).Append("\n");
      sb.Append("  ResettablePL: ").Append(ResettablePL).Append("\n");
      sb.Append("  ResettablePLTime: ").Append(ResettablePLTime).Append("\n");
      sb.Append("  Financing: ").Append(Financing).Append("\n");
      sb.Append("  Commission: ").Append(Commission).Append("\n");
      sb.Append("  GuaranteedExecutionFees: ").Append(GuaranteedExecutionFees).Append("\n");
      sb.Append("  MarginRate: ").Append(MarginRate).Append("\n");
      sb.Append("  MarginCallEnterTime: ").Append(MarginCallEnterTime).Append("\n");
      sb.Append("  MarginCallExtensionCount: ").Append(MarginCallExtensionCount).Append("\n");
      sb.Append("  LastMarginCallExtensionTime: ").Append(LastMarginCallExtensionTime).Append("\n");
      sb.Append("  OpenTradeCount: ").Append(OpenTradeCount).Append("\n");
      sb.Append("  OpenPositionCount: ").Append(OpenPositionCount).Append("\n");
      sb.Append("  PendingOrderCount: ").Append(PendingOrderCount).Append("\n");
      sb.Append("  HedgingEnabled: ").Append(HedgingEnabled).Append("\n");
      sb.Append("  LastOrderFillTimestamp: ").Append(LastOrderFillTimestamp).Append("\n");
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
      sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
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
