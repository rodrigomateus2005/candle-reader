using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class InlineResponse4045 {
    /// <summary>
    /// Gets or Sets OrderCancelRejectTransaction
    /// </summary>
    [DataMember(Name="orderCancelRejectTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderCancelRejectTransaction")]
    public OrderCancelRejectTransaction OrderCancelRejectTransaction { get; set; }

    /// <summary>
    /// The IDs of all Transactions that were created while satisfying the request. Only present if the Account exists.
    /// </summary>
    /// <value>The IDs of all Transactions that were created while satisfying the request. Only present if the Account exists.</value>
    [DataMember(Name="relatedTransactionIDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relatedTransactionIDs")]
    public List<string> RelatedTransactionIDs { get; set; }

    /// <summary>
    /// The ID of the most recent Transaction created for the Account. Only present if the Account exists.
    /// </summary>
    /// <value>The ID of the most recent Transaction created for the Account. Only present if the Account exists.</value>
    [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransactionID")]
    public string LastTransactionID { get; set; }

    /// <summary>
    /// The code of the error that has occurred. This field may not be returned for some errors.
    /// </summary>
    /// <value>The code of the error that has occurred. This field may not be returned for some errors.</value>
    [DataMember(Name="errorCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorCode")]
    public string ErrorCode { get; set; }

    /// <summary>
    /// The human-readable description of the error that has occurred.
    /// </summary>
    /// <value>The human-readable description of the error that has occurred.</value>
    [DataMember(Name="errorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorMessage")]
    public string ErrorMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse4045 {\n");
      sb.Append("  OrderCancelRejectTransaction: ").Append(OrderCancelRejectTransaction).Append("\n");
      sb.Append("  RelatedTransactionIDs: ").Append(RelatedTransactionIDs).Append("\n");
      sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
      sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
