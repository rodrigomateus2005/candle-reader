using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The order book data for a partition of the instrument&#39;s prices.
  /// </summary>
  [DataContract]
  public class OrderBookBucket {
    /// <summary>
    /// The lowest price (inclusive) covered by the bucket. The bucket covers the price range from the price to price + the order book's bucketWidth.
    /// </summary>
    /// <value>The lowest price (inclusive) covered by the bucket. The bucket covers the price range from the price to price + the order book's bucketWidth.</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// The percentage of the total number of orders represented by the long orders found in this bucket.
    /// </summary>
    /// <value>The percentage of the total number of orders represented by the long orders found in this bucket.</value>
    [DataMember(Name="longCountPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longCountPercent")]
    public string LongCountPercent { get; set; }

    /// <summary>
    /// The percentage of the total number of orders represented by the short orders found in this bucket.
    /// </summary>
    /// <value>The percentage of the total number of orders represented by the short orders found in this bucket.</value>
    [DataMember(Name="shortCountPercent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shortCountPercent")]
    public string ShortCountPercent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderBookBucket {\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  LongCountPercent: ").Append(LongCountPercent).Append("\n");
      sb.Append("  ShortCountPercent: ").Append(ShortCountPercent).Append("\n");
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
