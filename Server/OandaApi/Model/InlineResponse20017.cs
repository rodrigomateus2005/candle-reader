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
  public class InlineResponse20017 {
    /// <summary>
    /// Gets or Sets Account
    /// </summary>
    [DataMember(Name="account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "account")]
    public AccountSummary Account { get; set; }

    /// <summary>
    /// The ID of the most recent Transaction created for the Account.
    /// </summary>
    /// <value>The ID of the most recent Transaction created for the Account.</value>
    [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransactionID")]
    public string LastTransactionID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse20017 {\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
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
