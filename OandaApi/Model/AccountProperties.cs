using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Properties related to an Account.
  /// </summary>
  [DataContract]
  public class AccountProperties {
    /// <summary>
    /// The Account's identifier
    /// </summary>
    /// <value>The Account's identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The Account's associated MT4 Account ID. This field will not be present if the Account is not an MT4 account.
    /// </summary>
    /// <value>The Account's associated MT4 Account ID. This field will not be present if the Account is not an MT4 account.</value>
    [DataMember(Name="mt4AccountID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mt4AccountID")]
    public int? Mt4AccountID { get; set; }

    /// <summary>
    /// The Account's tags
    /// </summary>
    /// <value>The Account's tags</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountProperties {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Mt4AccountID: ").Append(Mt4AccountID).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
