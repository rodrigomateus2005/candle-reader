using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// HomeConversions represents the factors to use to convert quantities of a given currency into the Account&#39;s home currency. The conversion factor depends on the scenario the conversion is required for.
  /// </summary>
  [DataContract]
  public class HomeConversions {
    /// <summary>
    /// The currency to be converted into the home currency.
    /// </summary>
    /// <value>The currency to be converted into the home currency.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// The factor used to convert any gains for an Account in the specified currency into the Account's home currency. This would include positive realized P/L and positive financing amounts. Conversion is performed by multiplying the positive P/L by the conversion factor.
    /// </summary>
    /// <value>The factor used to convert any gains for an Account in the specified currency into the Account's home currency. This would include positive realized P/L and positive financing amounts. Conversion is performed by multiplying the positive P/L by the conversion factor.</value>
    [DataMember(Name="accountGain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountGain")]
    public string AccountGain { get; set; }

    /// <summary>
    /// The string representation of a decimal number.
    /// </summary>
    /// <value>The string representation of a decimal number.</value>
    [DataMember(Name="accountLoss", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountLoss")]
    public string AccountLoss { get; set; }

    /// <summary>
    /// The factor used to convert a Position or Trade Value in the specified currency into the Account's home currency. Conversion is performed by multiplying the Position or Trade Value by the conversion factor.
    /// </summary>
    /// <value>The factor used to convert a Position or Trade Value in the specified currency into the Account's home currency. Conversion is performed by multiplying the Position or Trade Value by the conversion factor.</value>
    [DataMember(Name="positionValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "positionValue")]
    public string PositionValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HomeConversions {\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  AccountGain: ").Append(AccountGain).Append("\n");
      sb.Append("  AccountLoss: ").Append(AccountLoss).Append("\n");
      sb.Append("  PositionValue: ").Append(PositionValue).Append("\n");
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
