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
  public class InlineResponse4001 {
    /// <summary>
    /// Gets or Sets LongOrderRejectTransaction
    /// </summary>
    [DataMember(Name="longOrderRejectTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longOrderRejectTransaction")]
    public MarketOrderRejectTransaction LongOrderRejectTransaction { get; set; }

    /// <summary>
    /// Gets or Sets ShortOrderRejectTransaction
    /// </summary>
    [DataMember(Name="shortOrderRejectTransaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortOrderRejectTransaction")]
    public MarketOrderRejectTransaction ShortOrderRejectTransaction { get; set; }

    /// <summary>
    /// The IDs of all Transactions that were created while satisfying the request.
    /// </summary>
    /// <value>The IDs of all Transactions that were created while satisfying the request.</value>
    [DataMember(Name="relatedTransactionIDs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "relatedTransactionIDs")]
    public List<string> RelatedTransactionIDs { get; set; }

    /// <summary>
    /// The ID of the most recent Transaction created for the Account
    /// </summary>
    /// <value>The ID of the most recent Transaction created for the Account</value>
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
      sb.Append("class InlineResponse4001 {\n");
      sb.Append("  LongOrderRejectTransaction: ").Append(LongOrderRejectTransaction).Append("\n");
      sb.Append("  ShortOrderRejectTransaction: ").Append(ShortOrderRejectTransaction).Append("\n");
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
