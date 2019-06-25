using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The price data (open, high, low, close) for the Candlestick representation.
  /// </summary>
  [DataContract]
  public class CandlestickData {
    /// <summary>
    /// The first (open) price in the time-range represented by the candlestick.
    /// </summary>
    /// <value>The first (open) price in the time-range represented by the candlestick.</value>
    [DataMember(Name="o", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "o")]
    public decimal O { get; set; }

    /// <summary>
    /// The highest price in the time-range represented by the candlestick.
    /// </summary>
    /// <value>The highest price in the time-range represented by the candlestick.</value>
    [DataMember(Name="h", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "h")]
    public decimal H { get; set; }

    /// <summary>
    /// The lowest price in the time-range represented by the candlestick.
    /// </summary>
    /// <value>The lowest price in the time-range represented by the candlestick.</value>
    [DataMember(Name="l", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "l")]
    public decimal L { get; set; }

    /// <summary>
    /// The last (closing) price in the time-range represented by the candlestick.
    /// </summary>
    /// <value>The last (closing) price in the time-range represented by the candlestick.</value>
    [DataMember(Name="c", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "c")]
    public decimal C { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CandlestickData {\n");
      sb.Append("  O: ").Append(O).Append("\n");
      sb.Append("  H: ").Append(H).Append("\n");
      sb.Append("  L: ").Append(L).Append("\n");
      sb.Append("  C: ").Append(C).Append("\n");
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
