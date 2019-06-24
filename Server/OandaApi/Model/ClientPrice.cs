using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The specification of an Account-specific Price.
  /// </summary>
  [DataContract]
  public class ClientPrice {
    /// <summary>
    /// The string \"PRICE\". Used to identify the a Price object when found in a stream.
    /// </summary>
    /// <value>The string \"PRICE\". Used to identify the a Price object when found in a stream.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The Price's Instrument.
    /// </summary>
    /// <value>The Price's Instrument.</value>
    [DataMember(Name="instrument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instrument")]
    public string Instrument { get; set; }

    /// <summary>
    /// The date/time when the Price was created
    /// </summary>
    /// <value>The date/time when the Price was created</value>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public System.DateTime Time { get; set; }

    /// <summary>
    /// The status of the Price.
    /// </summary>
    /// <value>The status of the Price.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Flag indicating if the Price is tradeable or not
    /// </summary>
    /// <value>Flag indicating if the Price is tradeable or not</value>
    [DataMember(Name="tradeable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeable")]
    public bool? Tradeable { get; set; }

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
    /// The closeout bid Price. This Price is used when a bid is required to closeout a Position (margin closeout or manual) yet there is no bid liquidity. The closeout bid is never used to open a new position.
    /// </summary>
    /// <value>The closeout bid Price. This Price is used when a bid is required to closeout a Position (margin closeout or manual) yet there is no bid liquidity. The closeout bid is never used to open a new position.</value>
    [DataMember(Name="closeoutBid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closeoutBid")]
    public decimal CloseoutBid { get; set; }

    /// <summary>
    /// The closeout ask Price. This Price is used when a ask is required to closeout a Position (margin closeout or manual) yet there is no ask liquidity. The closeout ask is never used to open a new position.
    /// </summary>
    /// <value>The closeout ask Price. This Price is used when a ask is required to closeout a Position (margin closeout or manual) yet there is no ask liquidity. The closeout ask is never used to open a new position.</value>
    [DataMember(Name="closeoutAsk", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closeoutAsk")]
    public decimal CloseoutAsk { get; set; }

    /// <summary>
    /// Gets or Sets QuoteHomeConversionFactors
    /// </summary>
    [DataMember(Name="quoteHomeConversionFactors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quoteHomeConversionFactors")]
    public QuoteHomeConversionFactors QuoteHomeConversionFactors { get; set; }

    /// <summary>
    /// Gets or Sets UnitsAvailable
    /// </summary>
    [DataMember(Name="unitsAvailable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitsAvailable")]
    public UnitsAvailable UnitsAvailable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClientPrice {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Instrument: ").Append(Instrument).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Tradeable: ").Append(Tradeable).Append("\n");
      sb.Append("  Bids: ").Append(Bids).Append("\n");
      sb.Append("  Asks: ").Append(Asks).Append("\n");
      sb.Append("  CloseoutBid: ").Append(CloseoutBid).Append("\n");
      sb.Append("  CloseoutAsk: ").Append(CloseoutAsk).Append("\n");
      sb.Append("  QuoteHomeConversionFactors: ").Append(QuoteHomeConversionFactors).Append("\n");
      sb.Append("  UnitsAvailable: ").Append(UnitsAvailable).Append("\n");
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
