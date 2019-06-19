using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The representation of an instrument&#39;s order book at a point in time
  /// </summary>
  [DataContract]
  public class OrderBook {
    /// <summary>
    /// The order book's instrument
    /// </summary>
    /// <value>The order book's instrument</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// The time when the order book snapshot was created.
    /// </summary>
    /// <value>The time when the order book snapshot was created.</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public string Time { get; set; }

    /// <summary>
    /// The price (midpoint) for the order book's instrument at the time of the order book snapshot
    /// </summary>
    /// <value>The price (midpoint) for the order book's instrument at the time of the order book snapshot</value>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public string Price { get; set; }

    /// <summary>
    /// The price width for each bucket. Each bucket covers the price range from the bucket's price to the bucket's price + bucketWidth.
    /// </summary>
    /// <value>The price width for each bucket. Each bucket covers the price range from the bucket's price to the bucket's price + bucketWidth.</value>
    [DataMember(Name="bucketWidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bucketWidth")]
    public string BucketWidth { get; set; }

    /// <summary>
    /// The partitioned order book, divided into buckets using a default bucket width. These buckets are only provided for price ranges which actually contain order or position data.
    /// </summary>
    /// <value>The partitioned order book, divided into buckets using a default bucket width. These buckets are only provided for price ranges which actually contain order or position data.</value>
    [DataMember(Name="buckets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buckets")]
    public List<OrderBookBucket> Buckets { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderBook {\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  BucketWidth: ").Append(BucketWidth).Append("\n");
      sb.Append("  Buckets: ").Append(Buckets).Append("\n");
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
