using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An InstrumentCommission represents an instrument-specific commission
  /// </summary>
  [DataContract]
  public class InstrumentCommission {
    /// <summary>
    /// The commission amount (in the Account's home currency) charged per unitsTraded of the instrument
    /// </summary>
    /// <value>The commission amount (in the Account's home currency) charged per unitsTraded of the instrument</value>
    [DataMember(Name="commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commission")]
    public string Commission { get; set; }

    /// <summary>
    /// The number of units traded that the commission amount is based on.
    /// </summary>
    /// <value>The number of units traded that the commission amount is based on.</value>
    [DataMember(Name="unitsTraded", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitsTraded")]
    public string UnitsTraded { get; set; }

    /// <summary>
    /// The minimum commission amount (in the Account's home currency) that is charged when an Order is filled for this instrument.
    /// </summary>
    /// <value>The minimum commission amount (in the Account's home currency) that is charged when an Order is filled for this instrument.</value>
    [DataMember(Name="minimumCommission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumCommission")]
    public string MinimumCommission { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InstrumentCommission {\n");
      sb.Append("  Commission: ").Append(Commission).Append("\n");
      sb.Append("  UnitsTraded: ").Append(UnitsTraded).Append("\n");
      sb.Append("  MinimumCommission: ").Append(MinimumCommission).Append("\n");
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
