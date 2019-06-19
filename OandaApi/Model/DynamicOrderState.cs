using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The dynamic state of an Order. This is only relevant to TrailingStopLoss Orders, as no other Order type has dynamic state.
  /// </summary>
  [DataContract]
  public class DynamicOrderState {
    /// <summary>
    /// The Order's ID.
    /// </summary>
    /// <value>The Order's ID.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The Order's calculated trailing stop value.
    /// </summary>
    /// <value>The Order's calculated trailing stop value.</value>
    [DataMember(Name="trailingStopValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trailingStopValue")]
    public string TrailingStopValue { get; set; }

    /// <summary>
    /// The distance between the Trailing Stop Loss Order's trailingStopValue and the current Market Price. This represents the distance (in price units) of the Order from a triggering price. If the distance could not be determined, this value will not be set.
    /// </summary>
    /// <value>The distance between the Trailing Stop Loss Order's trailingStopValue and the current Market Price. This represents the distance (in price units) of the Order from a triggering price. If the distance could not be determined, this value will not be set.</value>
    [DataMember(Name="triggerDistance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "triggerDistance")]
    public string TriggerDistance { get; set; }

    /// <summary>
    /// True if an exact trigger distance could be calculated. If false, it means the provided trigger distance is a best estimate. If the distance could not be determined, this value will not be set.
    /// </summary>
    /// <value>True if an exact trigger distance could be calculated. If false, it means the provided trigger distance is a best estimate. If the distance could not be determined, this value will not be set.</value>
    [DataMember(Name="isTriggerDistanceExact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isTriggerDistanceExact")]
    public bool? IsTriggerDistanceExact { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DynamicOrderState {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  TrailingStopValue: ").Append(TrailingStopValue).Append("\n");
      sb.Append("  TriggerDistance: ").Append(TriggerDistance).Append("\n");
      sb.Append("  IsTriggerDistanceExact: ").Append(IsTriggerDistanceExact).Append("\n");
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
