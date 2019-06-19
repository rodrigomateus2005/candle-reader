using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A DailyFinancingTransaction represents the daily payment/collection of financing for an Account.
  /// </summary>
  [DataContract]
  public class DailyFinancingTransaction {
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
    /// The Type of the Transaction. Always set to \"DAILY_FINANCING\" for a DailyFinancingTransaction.
    /// </summary>
    /// <value>The Type of the Transaction. Always set to \"DAILY_FINANCING\" for a DailyFinancingTransaction.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The amount of financing paid/collected for the Account.
    /// </summary>
    /// <value>The amount of financing paid/collected for the Account.</value>
    [DataMember(Name="financing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financing")]
    public string Financing { get; set; }

    /// <summary>
    /// The Account's balance after daily financing.
    /// </summary>
    /// <value>The Account's balance after daily financing.</value>
    [DataMember(Name="accountBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountBalance")]
    public string AccountBalance { get; set; }

    /// <summary>
    /// The account financing mode at the time of the daily financing.
    /// </summary>
    /// <value>The account financing mode at the time of the daily financing.</value>
    [DataMember(Name="accountFinancingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountFinancingMode")]
    public string AccountFinancingMode { get; set; }

    /// <summary>
    /// The financing paid/collected for each Position in the Account.
    /// </summary>
    /// <value>The financing paid/collected for each Position in the Account.</value>
    [DataMember(Name="positionFinancings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "positionFinancings")]
    public List<PositionFinancing> PositionFinancings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DailyFinancingTransaction {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  UserID: ").Append(UserID).Append("\n");
      sb.Append("  AccountID: ").Append(AccountID).Append("\n");
      sb.Append("  BatchID: ").Append(BatchID).Append("\n");
      sb.Append("  RequestID: ").Append(RequestID).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Financing: ").Append(Financing).Append("\n");
      sb.Append("  AccountBalance: ").Append(AccountBalance).Append("\n");
      sb.Append("  AccountFinancingMode: ").Append(AccountFinancingMode).Append("\n");
      sb.Append("  PositionFinancings: ").Append(PositionFinancings).Append("\n");
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
