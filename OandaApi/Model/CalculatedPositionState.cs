using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The dynamic (calculated) state of a Position
  /// </summary>
  [DataContract]
  public class CalculatedPositionState {
    /// <summary>
    /// The Position's Instrument.
    /// </summary>
    /// <value>The Position's Instrument.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// The Position's net unrealized profit/loss
    /// </summary>
    /// <value>The Position's net unrealized profit/loss</value>
    [DataMember(Name="netUnrealizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "netUnrealizedPL")]
    public string NetUnrealizedPL { get; set; }

    /// <summary>
    /// The unrealized profit/loss of the Position's long open Trades
    /// </summary>
    /// <value>The unrealized profit/loss of the Position's long open Trades</value>
    [DataMember(Name="longUnrealizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longUnrealizedPL")]
    public string LongUnrealizedPL { get; set; }

    /// <summary>
    /// The unrealized profit/loss of the Position's short open Trades
    /// </summary>
    /// <value>The unrealized profit/loss of the Position's short open Trades</value>
    [DataMember(Name="shortUnrealizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortUnrealizedPL")]
    public string ShortUnrealizedPL { get; set; }

    /// <summary>
    /// Margin currently used by the Position.
    /// </summary>
    /// <value>Margin currently used by the Position.</value>
    [DataMember(Name="marginUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginUsed")]
    public string MarginUsed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CalculatedPositionState {\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  NetUnrealizedPL: ").Append(NetUnrealizedPL).Append("\n");
      sb.Append("  LongUnrealizedPL: ").Append(LongUnrealizedPL).Append("\n");
      sb.Append("  ShortUnrealizedPL: ").Append(ShortUnrealizedPL).Append("\n");
      sb.Append("  MarginUsed: ").Append(MarginUsed).Append("\n");
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
