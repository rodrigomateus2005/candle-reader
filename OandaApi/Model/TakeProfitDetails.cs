using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// TakeProfitDetails specifies the details of a Take Profit Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Take Profit, or when a Trade&#39;s dependent Take Profit Order is modified directly through the Trade.
  /// </summary>
  [DataContract]
  public class TakeProfitDetails {
    /// <summary>
    /// The price that the Take Profit Order will be triggered at. Only one of the price and distance fields may be specified.
    /// </summary>
    /// <value>The price that the Take Profit Order will be triggered at. Only one of the price and distance fields may be specified.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// The time in force for the created Take Profit Order. This may only be GTC, GTD or GFD.
    /// </summary>
    /// <value>The time in force for the created Take Profit Order. This may only be GTC, GTD or GFD.</value>
    [DataMember(Name="timeInForce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeInForce")]
    public string TimeInForce { get; set; }

    /// <summary>
    /// The date when the Take Profit Order will be cancelled on if timeInForce is GTD.
    /// </summary>
    /// <value>The date when the Take Profit Order will be cancelled on if timeInForce is GTD.</value>
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
      sb.Append("class TakeProfitDetails {\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
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
