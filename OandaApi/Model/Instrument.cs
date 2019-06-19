using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Full specification of an Instrument.
  /// </summary>
  [DataContract]
  public class Instrument {
    /// <summary>
    /// The name of the Instrument
    /// </summary>
    /// <value>The name of the Instrument</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The type of the Instrument
    /// </summary>
    /// <value>The type of the Instrument</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The display name of the Instrument
    /// </summary>
    /// <value>The display name of the Instrument</value>
    [DataMember(Name="displayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// The location of the \"pip\" for this instrument. The decimal position of the pip in this Instrument's price can be found at 10 ^ pipLocation (e.g. -4 pipLocation results in a decimal pip position of 10 ^ -4 = 0.0001).
    /// </summary>
    /// <value>The location of the \"pip\" for this instrument. The decimal position of the pip in this Instrument's price can be found at 10 ^ pipLocation (e.g. -4 pipLocation results in a decimal pip position of 10 ^ -4 = 0.0001).</value>
    [DataMember(Name="pipLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pipLocation")]
    public int? PipLocation { get; set; }

    /// <summary>
    /// The number of decimal places that should be used to display prices for this instrument. (e.g. a displayPrecision of 5 would result in a price of \"1\" being displayed as \"1.00000\")
    /// </summary>
    /// <value>The number of decimal places that should be used to display prices for this instrument. (e.g. a displayPrecision of 5 would result in a price of \"1\" being displayed as \"1.00000\")</value>
    [DataMember(Name="displayPrecision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayPrecision")]
    public int? DisplayPrecision { get; set; }

    /// <summary>
    /// The amount of decimal places that may be provided when specifying the number of units traded for this instrument.
    /// </summary>
    /// <value>The amount of decimal places that may be provided when specifying the number of units traded for this instrument.</value>
    [DataMember(Name="tradeUnitsPrecision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tradeUnitsPrecision")]
    public int? TradeUnitsPrecision { get; set; }

    /// <summary>
    /// The smallest number of units allowed to be traded for this instrument.
    /// </summary>
    /// <value>The smallest number of units allowed to be traded for this instrument.</value>
    [DataMember(Name="minimumTradeSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumTradeSize")]
    public string MinimumTradeSize { get; set; }

    /// <summary>
    /// The maximum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units.
    /// </summary>
    /// <value>The maximum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units.</value>
    [DataMember(Name="maximumTrailingStopDistance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumTrailingStopDistance")]
    public string MaximumTrailingStopDistance { get; set; }

    /// <summary>
    /// The minimum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units.
    /// </summary>
    /// <value>The minimum trailing stop distance allowed for a trailing stop loss created for this instrument. Specified in price units.</value>
    [DataMember(Name="minimumTrailingStopDistance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimumTrailingStopDistance")]
    public string MinimumTrailingStopDistance { get; set; }

    /// <summary>
    /// The maximum position size allowed for this instrument. Specified in units.
    /// </summary>
    /// <value>The maximum position size allowed for this instrument. Specified in units.</value>
    [DataMember(Name="maximumPositionSize", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumPositionSize")]
    public string MaximumPositionSize { get; set; }

    /// <summary>
    /// The maximum units allowed for an Order placed for this instrument. Specified in units.
    /// </summary>
    /// <value>The maximum units allowed for an Order placed for this instrument. Specified in units.</value>
    [DataMember(Name="maximumOrderUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maximumOrderUnits")]
    public string MaximumOrderUnits { get; set; }

    /// <summary>
    /// The margin rate for this instrument.
    /// </summary>
    /// <value>The margin rate for this instrument.</value>
    [DataMember(Name="marginRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marginRate")]
    public string MarginRate { get; set; }

    /// <summary>
    /// Gets or Sets Commission
    /// </summary>
    [DataMember(Name="commission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commission")]
    public InstrumentCommission Commission { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Instrument {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  PipLocation: ").Append(PipLocation).Append("\n");
      sb.Append("  DisplayPrecision: ").Append(DisplayPrecision).Append("\n");
      sb.Append("  TradeUnitsPrecision: ").Append(TradeUnitsPrecision).Append("\n");
      sb.Append("  MinimumTradeSize: ").Append(MinimumTradeSize).Append("\n");
      sb.Append("  MaximumTrailingStopDistance: ").Append(MaximumTrailingStopDistance).Append("\n");
      sb.Append("  MinimumTrailingStopDistance: ").Append(MinimumTrailingStopDistance).Append("\n");
      sb.Append("  MaximumPositionSize: ").Append(MaximumPositionSize).Append("\n");
      sb.Append("  MaximumOrderUnits: ").Append(MaximumOrderUnits).Append("\n");
      sb.Append("  MarginRate: ").Append(MarginRate).Append("\n");
      sb.Append("  Commission: ").Append(Commission).Append("\n");
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
