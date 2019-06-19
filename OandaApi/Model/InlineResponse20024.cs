using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The response body for the Transaction Stream uses chunked transfer encoding.  Each chunk contains Transaction and/or TransactionHeartbeat objects encoded as JSON.  Each JSON object is serialized into a single line of text, and multiple objects found in the same chunk are separated by newlines. TransactionHeartbeats are sent every 5 seconds.
  /// </summary>
  [DataContract]
  public class InlineResponse20024 {
    /// <summary>
    /// Gets or Sets Transaction
    /// </summary>
    [DataMember(Name="transaction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transaction")]
    public Transaction Transaction { get; set; }

    /// <summary>
    /// Gets or Sets Heartbeat
    /// </summary>
    [DataMember(Name="heartbeat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "heartbeat")]
    public TransactionHeartbeat Heartbeat { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse20024 {\n");
      sb.Append("  Transaction: ").Append(Transaction).Append("\n");
      sb.Append("  Heartbeat: ").Append(Heartbeat).Append("\n");
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
