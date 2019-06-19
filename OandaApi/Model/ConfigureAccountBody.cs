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
  public class ConfigureAccountBody {
    /// <summary>
    /// Client-defined alias (name) for the Account
    /// </summary>
    /// <value>Client-defined alias (name) for the Account</value>
    [DataMember(Name="alias", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "alias")]
    public string Alias { get; set; }

    /// <summary>
    /// The string representation of a decimal number.
    /// </summary>
    /// <value>The string representation of a decimal number.</value>
    [DataMember(Name="marginRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginRate")]
    public string MarginRate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ConfigureAccountBody {\n");
      sb.Append("  Alias: ").Append(Alias).Append("\n");
      sb.Append("  MarginRate: ").Append(MarginRate).Append("\n");
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
