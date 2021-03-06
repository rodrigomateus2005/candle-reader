using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// OpenTradeFinancing is used to pay/collect daily financing charge for an open Trade within an Account
  /// </summary>
  [DataContract]
  public class OpenTradeFinancing {
    /// <summary>
    /// The ID of the Trade that financing is being paid/collected for.
    /// </summary>
    /// <value>The ID of the Trade that financing is being paid/collected for.</value>
    [DataMember(Name="tradeID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeID")]
    public string TradeID { get; set; }

    /// <summary>
    /// The amount of financing paid/collected for the Trade.
    /// </summary>
    /// <value>The amount of financing paid/collected for the Trade.</value>
    [DataMember(Name="financing", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "financing")]
    public string Financing { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OpenTradeFinancing {\n");
      sb.Append("  TradeID: ").Append(TradeID).Append("\n");
      sb.Append("  Financing: ").Append(Financing).Append("\n");
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
