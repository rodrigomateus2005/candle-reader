using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A TransactionHeartbeat object is injected into the Transaction stream to ensure that the HTTP connection remains active.
  /// </summary>
  [DataContract]
  public class TransactionHeartbeat {
    /// <summary>
    /// The string \"HEARTBEAT\"
    /// </summary>
    /// <value>The string \"HEARTBEAT\"</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The ID of the most recent Transaction created for the Account
    /// </summary>
    /// <value>The ID of the most recent Transaction created for the Account</value>
    [DataMember(Name="lastTransactionID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastTransactionID")]
    public string LastTransactionID { get; set; }

    /// <summary>
    /// The date/time when the TransactionHeartbeat was created.
    /// </summary>
    /// <value>The date/time when the TransactionHeartbeat was created.</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public string Time { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransactionHeartbeat {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  LastTransactionID: ").Append(LastTransactionID).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
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
