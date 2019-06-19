using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Representation of many units of an Instrument are available to be traded for both long and short Orders.
  /// </summary>
  [DataContract]
  public class UnitsAvailableDetails {
    /// <summary>
    /// The units available for long Orders.
    /// </summary>
    /// <value>The units available for long Orders.</value>
    [DataMember(Name="long", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "long")]
    public string Long { get; set; }

    /// <summary>
    /// The units available for short Orders.
    /// </summary>
    /// <value>The units available for short Orders.</value>
    [DataMember(Name="short", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "short")]
    public string Short { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnitsAvailableDetails {\n");
      sb.Append("  Long: ").Append(Long).Append("\n");
      sb.Append("  Short: ").Append(Short).Append("\n");
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
