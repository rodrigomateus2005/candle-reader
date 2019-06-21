using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The Price representation
  /// </summary>
  [DataContract]
  public class Price {
    /// <summary>
    /// The Price's Instrument.
    /// </summary>
    /// <value>The Price's Instrument.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// Flag indicating if the Price is tradeable or not
    /// </summary>
    /// <value>Flag indicating if the Price is tradeable or not</value>
    [DataMember(Name="tradeable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeable")]
    public bool? Tradeable { get; set; }

    /// <summary>
    /// The date/time when the Price was created.
    /// </summary>
    /// <value>The date/time when the Price was created.</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public string Timestamp { get; set; }

    /// <summary>
    /// The base bid price as calculated by pricing.
    /// </summary>
    /// <value>The base bid price as calculated by pricing.</value>
    [DataMember(Name="baseBid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseBid")]
    public string BaseBid { get; set; }

    /// <summary>
    /// The base ask price as calculated by pricing.
    /// </summary>
    /// <value>The base ask price as calculated by pricing.</value>
    [DataMember(Name="baseAsk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseAsk")]
    public string BaseAsk { get; set; }

    /// <summary>
    /// The list of prices and liquidity available on the Instrument's bid side. It is possible for this list to be empty if there is no bid liquidity currently available for the Instrument in the Account.
    /// </summary>
    /// <value>The list of prices and liquidity available on the Instrument's bid side. It is possible for this list to be empty if there is no bid liquidity currently available for the Instrument in the Account.</value>
    [DataMember(Name="bids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bids")]
    public List<PriceBucket> Bids { get; set; }

    /// <summary>
    /// The list of prices and liquidity available on the Instrument's ask side. It is possible for this list to be empty if there is no ask liquidity currently available for the Instrument in the Account.
    /// </summary>
    /// <value>The list of prices and liquidity available on the Instrument's ask side. It is possible for this list to be empty if there is no ask liquidity currently available for the Instrument in the Account.</value>
    [DataMember(Name="asks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "asks")]
    public List<PriceBucket> Asks { get; set; }

    /// <summary>
    /// The closeout bid price. This price is used when a bid is required to closeout a Position (margin closeout or manual) yet there is no bid liquidity. The closeout bid is never used to open a new position.
    /// </summary>
    /// <value>The closeout bid price. This price is used when a bid is required to closeout a Position (margin closeout or manual) yet there is no bid liquidity. The closeout bid is never used to open a new position.</value>
    [DataMember(Name="closeoutBid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closeoutBid")]
    public string CloseoutBid { get; set; }

    /// <summary>
    /// The closeout ask price. This price is used when an ask is required to closeout a Position (margin closeout or manual) yet there is no ask liquidity. The closeout ask is never used to open a new position.
    /// </summary>
    /// <value>The closeout ask price. This price is used when an ask is required to closeout a Position (margin closeout or manual) yet there is no ask liquidity. The closeout ask is never used to open a new position.</value>
    [DataMember(Name="closeoutAsk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closeoutAsk")]
    public string CloseoutAsk { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Price {\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Tradeable: ").Append(Tradeable).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  BaseBid: ").Append(BaseBid).Append("\n");
      sb.Append("  BaseAsk: ").Append(BaseAsk).Append("\n");
      sb.Append("  Bids: ").Append(Bids).Append("\n");
      sb.Append("  Asks: ").Append(Asks).Append("\n");
      sb.Append("  CloseoutBid: ").Append(CloseoutBid).Append("\n");
      sb.Append("  CloseoutAsk: ").Append(CloseoutAsk).Append("\n");
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
