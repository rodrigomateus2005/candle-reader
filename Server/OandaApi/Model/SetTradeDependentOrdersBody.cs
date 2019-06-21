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
  public class SetTradeDependentOrdersBody {
    /// <summary>
    /// Gets or Sets TakeProfit
    /// </summary>
    [DataMember(Name="takeProfit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "takeProfit")]
    public TakeProfitDetails TakeProfit { get; set; }

    /// <summary>
    /// Gets or Sets StopLoss
    /// </summary>
    [DataMember(Name="stopLoss", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stopLoss")]
    public StopLossDetails StopLoss { get; set; }

    /// <summary>
    /// Gets or Sets TrailingStopLoss
    /// </summary>
    [DataMember(Name="trailingStopLoss", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trailingStopLoss")]
    public TrailingStopLossDetails TrailingStopLoss { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SetTradeDependentOrdersBody {\n");
      sb.Append("  TakeProfit: ").Append(TakeProfit).Append("\n");
      sb.Append("  StopLoss: ").Append(StopLoss).Append("\n");
      sb.Append("  TrailingStopLoss: ").Append(TrailingStopLoss).Append("\n");
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
