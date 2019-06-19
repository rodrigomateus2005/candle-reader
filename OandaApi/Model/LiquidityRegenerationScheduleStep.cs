using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A liquidity regeneration schedule Step indicates the amount of bid and ask liquidity that is used by the Account at a certain time. These amounts will only change at the timestamp of the following step.
  /// </summary>
  [DataContract]
  public class LiquidityRegenerationScheduleStep {
    /// <summary>
    /// The timestamp of the schedule step.
    /// </summary>
    /// <value>The timestamp of the schedule step.</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public string Timestamp { get; set; }

    /// <summary>
    /// The amount of bid liquidity used at this step in the schedule.
    /// </summary>
    /// <value>The amount of bid liquidity used at this step in the schedule.</value>
    [DataMember(Name="bidLiquidityUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bidLiquidityUsed")]
    public string BidLiquidityUsed { get; set; }

    /// <summary>
    /// The amount of ask liquidity used at this step in the schedule.
    /// </summary>
    /// <value>The amount of ask liquidity used at this step in the schedule.</value>
    [DataMember(Name="askLiquidityUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "askLiquidityUsed")]
    public string AskLiquidityUsed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LiquidityRegenerationScheduleStep {\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  BidLiquidityUsed: ").Append(BidLiquidityUsed).Append("\n");
      sb.Append("  AskLiquidityUsed: ").Append(AskLiquidityUsed).Append("\n");
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
