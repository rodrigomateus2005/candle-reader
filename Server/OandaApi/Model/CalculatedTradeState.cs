using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The dynamic (calculated) state of an open Trade
  /// </summary>
  [DataContract]
  public class CalculatedTradeState {
    /// <summary>
    /// The Trade's ID.
    /// </summary>
    /// <value>The Trade's ID.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The Trade's unrealized profit/loss.
    /// </summary>
    /// <value>The Trade's unrealized profit/loss.</value>
    [DataMember(Name="unrealizedPL", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unrealizedPL")]
    public string UnrealizedPL { get; set; }

    /// <summary>
    /// Margin currently used by the Trade.
    /// </summary>
    /// <value>Margin currently used by the Trade.</value>
    [DataMember(Name="marginUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginUsed")]
    public string MarginUsed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CalculatedTradeState {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  UnrealizedPL: ").Append(UnrealizedPL).Append("\n");
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
