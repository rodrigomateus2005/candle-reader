using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// StopLossDetails specifies the details of a Stop Loss Order to be created on behalf of a client. This may happen when an Order is filled that opens a Trade requiring a Stop Loss, or when a Trade&#39;s dependent Stop Loss Order is modified directly through the Trade.
  /// </summary>
  [DataContract]
  public class StopLossDetails {
    /// <summary>
    /// The price that the Stop Loss Order will be triggered at. Only one of the price and distance fields may be specified.
    /// </summary>
    /// <value>The price that the Stop Loss Order will be triggered at. Only one of the price and distance fields may be specified.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// Specifies the distance (in price units) from the Trade's open price to use as the Stop Loss Order price. Only one of the distance and price fields may be specified.
    /// </summary>
    /// <value>Specifies the distance (in price units) from the Trade's open price to use as the Stop Loss Order price. Only one of the distance and price fields may be specified.</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public string Distance { get; set; }

    /// <summary>
    /// The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD.
    /// </summary>
    /// <value>The time in force for the created Stop Loss Order. This may only be GTC, GTD or GFD.</value>
    [DataMember(Name="timeInForce", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timeInForce")]
    public string TimeInForce { get; set; }

    /// <summary>
    /// The date when the Stop Loss Order will be cancelled on if timeInForce is GTD.
    /// </summary>
    /// <value>The date when the Stop Loss Order will be cancelled on if timeInForce is GTD.</value>
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
    /// Flag indicating that the price for the Stop Loss Order is guaranteed. The default value depends on the GuaranteedStopLossOrderMode of the account, if it is REQUIRED, the default will be true, for DISABLED or ENABLED the default is false.
    /// </summary>
    /// <value>Flag indicating that the price for the Stop Loss Order is guaranteed. The default value depends on the GuaranteedStopLossOrderMode of the account, if it is REQUIRED, the default will be true, for DISABLED or ENABLED the default is false.</value>
    [DataMember(Name="guaranteed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "guaranteed")]
    public bool? Guaranteed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StopLossDetails {\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  TimeInForce: ").Append(TimeInForce).Append("\n");
      sb.Append("  GtdTime: ").Append(GtdTime).Append("\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
      sb.Append("  Guaranteed: ").Append(Guaranteed).Append("\n");
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
