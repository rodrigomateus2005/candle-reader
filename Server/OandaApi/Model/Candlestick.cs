using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The Candlestick representation
  /// </summary>
  [DataContract]
  public class Candlestick {
    /// <summary>
    /// The start time of the candlestick
    /// </summary>
    /// <value>The start time of the candlestick</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public string Time { get; set; }

    /// <summary>
    /// Gets or Sets Bid
    /// </summary>
    [DataMember(Name="bid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bid")]
    public CandlestickData Bid { get; set; }

    /// <summary>
    /// Gets or Sets Ask
    /// </summary>
    [DataMember(Name="ask", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ask")]
    public CandlestickData Ask { get; set; }

    /// <summary>
    /// Gets or Sets Mid
    /// </summary>
    [DataMember(Name="mid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mid")]
    public CandlestickData Mid { get; set; }

    /// <summary>
    /// The number of prices created during the time-range represented by the candlestick.
    /// </summary>
    /// <value>The number of prices created during the time-range represented by the candlestick.</value>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public int? Volume { get; set; }

    /// <summary>
    /// A flag indicating if the candlestick is complete. A complete candlestick is one whose ending time is not in the future.
    /// </summary>
    /// <value>A flag indicating if the candlestick is complete. A complete candlestick is one whose ending time is not in the future.</value>
    [DataMember(Name="complete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "complete")]
    public bool? Complete { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Candlestick {\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  Bid: ").Append(Bid).Append("\n");
      sb.Append("  Ask: ").Append(Ask).Append("\n");
      sb.Append("  Mid: ").Append(Mid).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
      sb.Append("  Complete: ").Append(Complete).Append("\n");
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
