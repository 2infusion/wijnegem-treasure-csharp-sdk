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
  public class Map {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Start
    /// </summary>
    [DataMember(Name="start", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start")]
    public string Start { get; set; }

    /// <summary>
    /// Gets or Sets End
    /// </summary>
    [DataMember(Name="end", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end")]
    public string End { get; set; }

    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public string Active { get; set; }

    /// <summary>
    /// Gets or Sets RoundInterval
    /// </summary>
    [DataMember(Name="roundInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roundInterval")]
    public string RoundInterval { get; set; }

    /// <summary>
    /// Gets or Sets ClosedtTreasures
    /// </summary>
    [DataMember(Name="closedtTreasures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "closedtTreasures")]
    public List<Treasure> ClosedtTreasures { get; set; }

    /// <summary>
    /// Gets or Sets OpenedTreasure
    /// </summary>
    [DataMember(Name="openedTreasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openedTreasure")]
    public List<OpenTreasure> OpenedTreasure { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Map {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Start: ").Append(Start).Append("\n");
      sb.Append("  End: ").Append(End).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  RoundInterval: ").Append(RoundInterval).Append("\n");
      sb.Append("  ClosedtTreasures: ").Append(ClosedtTreasures).Append("\n");
      sb.Append("  OpenedTreasure: ").Append(OpenedTreasure).Append("\n");
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
