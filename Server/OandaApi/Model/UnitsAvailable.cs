using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Representation of how many units of an Instrument are available to be traded by an Order depending on its postionFill option.
  /// </summary>
  [DataContract]
  public class UnitsAvailable {
    /// <summary>
    /// Gets or Sets Default
    /// </summary>
    [DataMember(Name="default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default")]
    public UnitsAvailableDetails Default { get; set; }

    /// <summary>
    /// Gets or Sets ReduceFirst
    /// </summary>
    [DataMember(Name="reduceFirst", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reduceFirst")]
    public UnitsAvailableDetails ReduceFirst { get; set; }

    /// <summary>
    /// Gets or Sets ReduceOnly
    /// </summary>
    [DataMember(Name="reduceOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reduceOnly")]
    public UnitsAvailableDetails ReduceOnly { get; set; }

    /// <summary>
    /// Gets or Sets OpenOnly
    /// </summary>
    [DataMember(Name="openOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openOnly")]
    public UnitsAvailableDetails OpenOnly { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UnitsAvailable {\n");
      sb.Append("  Default: ").Append(Default).Append("\n");
      sb.Append("  ReduceFirst: ").Append(ReduceFirst).Append("\n");
      sb.Append("  ReduceOnly: ").Append(ReduceOnly).Append("\n");
      sb.Append("  OpenOnly: ").Append(OpenOnly).Append("\n");
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
