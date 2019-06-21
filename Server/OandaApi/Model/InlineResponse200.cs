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
  public class InlineResponse200 {
    /// <summary>
    /// The instrument whose Prices are represented by the candlesticks.
    /// </summary>
    /// <value>The instrument whose Prices are represented by the candlesticks.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// The granularity of the candlesticks provided.
    /// </summary>
    /// <value>The granularity of the candlesticks provided.</value>
    [DataMember(Name="granularity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "granularity")]
    public string Granularity { get; set; }

    /// <summary>
    /// The list of candlesticks that satisfy the request.
    /// </summary>
    /// <value>The list of candlesticks that satisfy the request.</value>
    [DataMember(Name="candles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "candles")]
    public List<Candlestick> Candles { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse200 {\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Granularity: ").Append(Granularity).Append("\n");
      sb.Append("  Candles: ").Append(Candles).Append("\n");
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
