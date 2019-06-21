using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A representation of user information, as available to external (3rd party) clients.
  /// </summary>
  [DataContract]
  public class UserInfoExternal {
    /// <summary>
    /// The user's OANDA-assigned user ID.
    /// </summary>
    /// <value>The user's OANDA-assigned user ID.</value>
    [DataMember(Name="userID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userID")]
    public int? UserID { get; set; }

    /// <summary>
    /// The country that the user is based in.
    /// </summary>
    /// <value>The country that the user is based in.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Flag indicating if the the user's Accounts adhere to FIFO execution rules.
    /// </summary>
    /// <value>Flag indicating if the the user's Accounts adhere to FIFO execution rules.</value>
    [DataMember(Name="FIFO", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FIFO")]
    public bool? FIFO { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserInfoExternal {\n");
      sb.Append("  UserID: ").Append(UserID).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  FIFO: ").Append(FIFO).Append("\n");
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
