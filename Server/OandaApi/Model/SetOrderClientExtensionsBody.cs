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
  public class SetOrderClientExtensionsBody {
    /// <summary>
    /// Gets or Sets ClientExtensions
    /// </summary>
    [DataMember(Name="clientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientExtensions")]
    public ClientExtensions ClientExtensions { get; set; }

    /// <summary>
    /// Gets or Sets TradeClientExtensions
    /// </summary>
    [DataMember(Name="tradeClientExtensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeClientExtensions")]
    public ClientExtensions TradeClientExtensions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SetOrderClientExtensionsBody {\n");
      sb.Append("  ClientExtensions: ").Append(ClientExtensions).Append("\n");
      sb.Append("  TradeClientExtensions: ").Append(TradeClientExtensions).Append("\n");
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
