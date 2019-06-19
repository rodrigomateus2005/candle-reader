using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An OrderIdentifier is used to refer to an Order, and contains both the OrderID and the ClientOrderID.
  /// </summary>
  [DataContract]
  public class OrderIdentifier {
    /// <summary>
    /// The OANDA-assigned Order ID
    /// </summary>
    /// <value>The OANDA-assigned Order ID</value>
    [DataMember(Name="orderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orderID")]
    public string OrderID { get; set; }

    /// <summary>
    /// The client-provided client Order ID
    /// </summary>
    /// <value>The client-provided client Order ID</value>
    [DataMember(Name="clientOrderID", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientOrderID")]
    public string ClientOrderID { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderIdentifier {\n");
      sb.Append("  OrderID: ").Append(OrderID).Append("\n");
      sb.Append("  ClientOrderID: ").Append(ClientOrderID).Append("\n");
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
