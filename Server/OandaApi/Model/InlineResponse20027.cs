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
  public class InlineResponse20027 {
    /// <summary>
    /// The list of Price objects requested.
    /// </summary>
    /// <value>The list of Price objects requested.</value>
    [DataMember(Name="prices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prices")]
    public List<ClientPrice> Prices { get; set; }

    /// <summary>
    /// The list of home currency conversion factors requested. This field will only be present if includeHomeConversions was set to true in the request.
    /// </summary>
    /// <value>The list of home currency conversion factors requested. This field will only be present if includeHomeConversions was set to true in the request.</value>
    [DataMember(Name="homeConversions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "homeConversions")]
    public List<HomeConversions> HomeConversions { get; set; }

    /// <summary>
    /// The DateTime value to use for the \"since\" parameter in the next poll request.
    /// </summary>
    /// <value>The DateTime value to use for the \"since\" parameter in the next poll request.</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public string Time { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse20027 {\n");
      sb.Append("  Prices: ").Append(Prices).Append("\n");
      sb.Append("  HomeConversions: ").Append(HomeConversions).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
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
