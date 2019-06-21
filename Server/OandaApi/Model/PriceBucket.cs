using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A Price Bucket represents a price available for an amount of liquidity
  /// </summary>
  [DataContract]
  public class PriceBucket {
    /// <summary>
    /// The Price offered by the PriceBucket
    /// </summary>
    /// <value>The Price offered by the PriceBucket</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// The amount of liquidity offered by the PriceBucket
    /// </summary>
    /// <value>The amount of liquidity offered by the PriceBucket</value>
    [DataMember(Name="liquidity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "liquidity")]
    public int? Liquidity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PriceBucket {\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Liquidity: ").Append(Liquidity).Append("\n");
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
