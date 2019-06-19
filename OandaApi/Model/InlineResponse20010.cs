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
  public class InlineResponse20010 {
    /// <summary>
    /// The Account's list of open Trades
    /// </summary>
    /// <value>The Account's list of open Trades</value>
    [DataMember(Name="trades", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trades")]
    public List<Trade> Trades { get; set; }

    /// <summary>
    /// The ID of the most recent Transaction created for the Account
    /// </summary>
    /// <value>The ID of the most recent Transaction created for the Account</value>
    [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransactionID")]
    public string LastTransactionID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse20010 {\n");
      sb.Append("  Trades: ").Append(Trades).Append("\n");
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
