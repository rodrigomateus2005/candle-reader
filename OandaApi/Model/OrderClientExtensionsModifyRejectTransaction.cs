using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A OrderClientExtensionsModifyRejectTransaction represents the rejection of the modification of an Order&#39;s Client Extensions.
  /// </summary>
  [DataContract]
  public class OrderClientExtensionsModifyRejectTransaction {
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
    /// The Type of the Transaction. Always set to \"ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT\" for a OrderClientExtensionsModifyRejectTransaction.
    /// </summary>
    /// <value>The Type of the Transaction. Always set to \"ORDER_CLIENT_EXTENSIONS_MODIFY_REJECT\" for a OrderClientExtensionsModifyRejectTransaction.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The ID of the Order who's client extensions are to be modified.
    /// </summary>
    /// <value>The ID of the Order who's client extensions are to be modified.</value>
    [DataMember(Name="orderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderID")]
    public string OrderID { get; set; }

    /// <summary>
    /// The original Client ID of the Order who's client extensions are to be modified.
    /// </summary>
    /// <value>The original Client ID of the Order who's client extensions are to be modified.</value>
    [DataMember(Name="clientOrderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientOrderID")]
    public string ClientOrderID { get; set; }

    /// <summary>
    /// Gets or Sets ClientExtensionsModify
    /// </summary>
    [DataMember(Name="clientExtensionsModify", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientExtensionsModify")]
    public ClientExtensions ClientExtensionsModify { get; set; }

    /// <summary>
    /// Gets or Sets TradeClientExtensionsModify
    /// </summary>
    [DataMember(Name="tradeClientExtensionsModify", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeClientExtensionsModify")]
    public ClientExtensions TradeClientExtensionsModify { get; set; }

    /// <summary>
    /// The reason that the Reject Transaction was created
    /// </summary>
    /// <value>The reason that the Reject Transaction was created</value>
    [DataMember(Name="rejectReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rejectReason")]
    public string RejectReason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderClientExtensionsModifyRejectTransaction {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  UserID: ").Append(UserID).Append("\n");
      sb.Append("  AccountID: ").Append(AccountID).Append("\n");
      sb.Append("  BatchID: ").Append(BatchID).Append("\n");
      sb.Append("  RequestID: ").Append(RequestID).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  OrderID: ").Append(OrderID).Append("\n");
      sb.Append("  ClientOrderID: ").Append(ClientOrderID).Append("\n");
      sb.Append("  ClientExtensionsModify: ").Append(ClientExtensionsModify).Append("\n");
      sb.Append("  TradeClientExtensionsModify: ").Append(TradeClientExtensionsModify).Append("\n");
      sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
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
