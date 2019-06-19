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
  public class ClosePositionBody {
    /// <summary>
    /// Indication of how much of the long Position to closeout. Either the string \"ALL\", the string \"NONE\", or a DecimalNumber representing how many units of the long position to close using a PositionCloseout MarketOrder. The units specified must always be positive.
    /// </summary>
    /// <value>Indication of how much of the long Position to closeout. Either the string \"ALL\", the string \"NONE\", or a DecimalNumber representing how many units of the long position to close using a PositionCloseout MarketOrder. The units specified must always be positive.</value>
    [DataMember(Name="longUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longUnits")]
    public string LongUnits { get; set; }

    /// <summary>
    /// Gets or Sets LongClientExtensions
    /// </summary>
    [DataMember(Name="longClientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longClientExtensions")]
    public ClientExtensions LongClientExtensions { get; set; }

    /// <summary>
    /// Indication of how much of the short Position to closeout. Either the string \"ALL\", the string \"NONE\", or a DecimalNumber representing how many units of the short position to close using a PositionCloseout MarketOrder. The units specified must always be positive.
    /// </summary>
    /// <value>Indication of how much of the short Position to closeout. Either the string \"ALL\", the string \"NONE\", or a DecimalNumber representing how many units of the short position to close using a PositionCloseout MarketOrder. The units specified must always be positive.</value>
    [DataMember(Name="shortUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortUnits")]
    public string ShortUnits { get; set; }

    /// <summary>
    /// Gets or Sets ShortClientExtensions
    /// </summary>
    [DataMember(Name="shortClientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortClientExtensions")]
    public ClientExtensions ShortClientExtensions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClosePositionBody {\n");
      sb.Append("  LongUnits: ").Append(LongUnits).Append("\n");
      sb.Append("  LongClientExtensions: ").Append(LongClientExtensions).Append("\n");
      sb.Append("  ShortUnits: ").Append(ShortUnits).Append("\n");
      sb.Append("  ShortClientExtensions: ").Append(ShortClientExtensions).Append("\n");
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
