using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A MarketOrderPositionCloseout specifies the extensions to a Market Order when it has been created to closeout a specific Position.
  /// </summary>
  [DataContract]
  public class MarketOrderPositionCloseout {
    /// <summary>
    /// The instrument of the Position being closed out.
    /// </summary>
    /// <value>The instrument of the Position being closed out.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// Indication of how much of the Position to close. Either \"ALL\", or a DecimalNumber reflection a partial close of the Trade. The DecimalNumber must always be positive, and represent a number that doesn't exceed the absolute size of the Position.
    /// </summary>
    /// <value>Indication of how much of the Position to close. Either \"ALL\", or a DecimalNumber reflection a partial close of the Trade. The DecimalNumber must always be positive, and represent a number that doesn't exceed the absolute size of the Position.</value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public string Units { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketOrderPositionCloseout {\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
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
