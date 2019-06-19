using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A GuaranteedStopLossOrderLevelRestriction represents the total position size that can exist within a given price window for Trades with guaranteed Stop Loss Orders attached for a specific Instrument.
  /// </summary>
  [DataContract]
  public class GuaranteedStopLossOrderLevelRestriction {
    /// <summary>
    /// Applies to Trades with a guaranteed Stop Loss Order attached for the specified Instrument. This is the total allowed Trade volume that can exist within the priceRange based on the trigger prices of the guaranteed Stop Loss Orders.
    /// </summary>
    /// <value>Applies to Trades with a guaranteed Stop Loss Order attached for the specified Instrument. This is the total allowed Trade volume that can exist within the priceRange based on the trigger prices of the guaranteed Stop Loss Orders.</value>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public string Volume { get; set; }

    /// <summary>
    /// The price range the volume applies to. This value is in price units.
    /// </summary>
    /// <value>The price range the volume applies to. This value is in price units.</value>
    [DataMember(Name="priceRange", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceRange")]
    public string PriceRange { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GuaranteedStopLossOrderLevelRestriction {\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
      sb.Append("  PriceRange: ").Append(PriceRange).Append("\n");
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
