using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// TrailingStopLossDetails specifies the details of a Trailing Stop Loss Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Trailing Stop Loss, or when a Trade&#39;s dependent Trailing Stop Loss Order is modified directly through the Trade.
  /// </summary>
  [DataContract]
  public class TrailingStopLossDetails {
    /// <summary>
    /// The distance (in price units) from the Trade's fill price that the Trailing Stop Loss Order will be triggered at.
    /// </summary>
    /// <value>The distance (in price units) from the Trade's fill price that the Trailing Stop Loss Order will be triggered at.</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public string Distance { get; set; }

    /// <summary>
    /// The time in force for the created Trailing Stop Loss Order. This may only be GTC, GTD or GFD.
    /// </summary>
    /// <value>The time in force for the created Trailing Stop Loss Order. This may only be GTC, GTD or GFD.</value>
    [DataMember(Name="timeInForce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeInForce")]
    public string TimeInForce { get; set; }

    /// <summary>
    /// The date when the Trailing Stop Loss Order will be cancelled on if timeInForce is GTD.
    /// </summary>
    /// <value>The date when the Trailing Stop Loss Order will be cancelled on if timeInForce is GTD.</value>
    [DataMember(Name="gtdTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gtdTime")]
    public string GtdTime { get; set; }

    /// <summary>
    /// Gets or Sets ClientExtensions
    /// </summary>
    [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientExtensions")]
    public ClientExtensions ClientExtensions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TrailingStopLossDetails {\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
      sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
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
