using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// OpenTradeFinancing is used to pay/collect daily financing charge for a Position within an Account
  /// </summary>
  [DataContract]
  public class PositionFinancing {
    /// <summary>
    /// The instrument of the Position that financing is being paid/collected for.
    /// </summary>
    /// <value>The instrument of the Position that financing is being paid/collected for.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// The amount of financing paid/collected for the Position.
    /// </summary>
    /// <value>The amount of financing paid/collected for the Position.</value>
    [DataMember(Name="financing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financing")]
    public string Financing { get; set; }

    /// <summary>
    /// The financing paid/collecte for each open Trade within the Position.
    /// </summary>
    /// <value>The financing paid/collecte for each open Trade within the Position.</value>
    [DataMember(Name="openTradeFinancings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openTradeFinancings")]
    public List<OpenTradeFinancing> OpenTradeFinancings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PositionFinancing {\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Financing: ").Append(Financing).Append("\n");
      sb.Append("  OpenTradeFinancings: ").Append(OpenTradeFinancings).Append("\n");
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
