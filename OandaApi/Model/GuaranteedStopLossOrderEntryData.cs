using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Details required by clients creating a Guaranteed Stop Loss Order
  /// </summary>
  [DataContract]
  public class GuaranteedStopLossOrderEntryData {
    /// <summary>
    /// The minimum distance allowed between the Trade's fill price and the configured price for guaranteed Stop Loss Orders created for this instrument. Specified in price units.
    /// </summary>
    /// <value>The minimum distance allowed between the Trade's fill price and the configured price for guaranteed Stop Loss Orders created for this instrument. Specified in price units.</value>
    [DataMember(Name="minimumDistance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumDistance")]
    public string MinimumDistance { get; set; }

    /// <summary>
    /// The amount that is charged to the account if a guaranteed Stop Loss Order is triggered and filled. The value is in price units and is charged for each unit of the Trade.
    /// </summary>
    /// <value>The amount that is charged to the account if a guaranteed Stop Loss Order is triggered and filled. The value is in price units and is charged for each unit of the Trade.</value>
    [DataMember(Name="premium", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "premium")]
    public string Premium { get; set; }

    /// <summary>
    /// Gets or Sets LevelRestriction
    /// </summary>
    [DataMember(Name="levelRestriction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "levelRestriction")]
    public GuaranteedStopLossOrderLevelRestriction LevelRestriction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GuaranteedStopLossOrderEntryData {\n");
      sb.Append("  MinimumDistance: ").Append(MinimumDistance).Append("\n");
      sb.Append("  Premium: ").Append(Premium).Append("\n");
      sb.Append("  LevelRestriction: ").Append(LevelRestriction).Append("\n");
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
