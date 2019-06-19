using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// QuoteHomeConversionFactors represents the factors that can be used used to convert quantities of a Price&#39;s Instrument&#39;s quote currency into the Account&#39;s home currency.
  /// </summary>
  [DataContract]
  public class QuoteHomeConversionFactors {
    /// <summary>
    /// The factor used to convert a positive amount of the Price's Instrument's quote currency into a positive amount of the Account's home currency.  Conversion is performed by multiplying the quote units by the conversion factor.
    /// </summary>
    /// <value>The factor used to convert a positive amount of the Price's Instrument's quote currency into a positive amount of the Account's home currency.  Conversion is performed by multiplying the quote units by the conversion factor.</value>
    [DataMember(Name="positiveUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "positiveUnits")]
    public string PositiveUnits { get; set; }

    /// <summary>
    /// The factor used to convert a negative amount of the Price's Instrument's quote currency into a negative amount of the Account's home currency.  Conversion is performed by multiplying the quote units by the conversion factor.
    /// </summary>
    /// <value>The factor used to convert a negative amount of the Price's Instrument's quote currency into a negative amount of the Account's home currency.  Conversion is performed by multiplying the quote units by the conversion factor.</value>
    [DataMember(Name="negativeUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "negativeUnits")]
    public string NegativeUnits { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuoteHomeConversionFactors {\n");
      sb.Append("  PositiveUnits: ").Append(PositiveUnits).Append("\n");
      sb.Append("  NegativeUnits: ").Append(NegativeUnits).Append("\n");
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
