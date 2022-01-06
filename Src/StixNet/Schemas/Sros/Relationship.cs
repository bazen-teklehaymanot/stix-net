using Newtonsoft.Json;

using StixNet.Schemas;

namespace StixNet.Sros;

public sealed class Relationship: STIXObject
{

    [JsonProperty("relationship_type", Required = Required.Always)]
    public string RelationshipType { get; set; }
    public string? Description { get; set; }
    /// <summary>
    /// identifier
    /// </summary>

    [JsonProperty("source_ref", Required = Required.Always)]
    public string SourceRef { get; set; }
    /// <summary>
    /// identifier
    /// </summary>
    [JsonProperty("target_ref", Required = Required.Always)]
    public string TargetRef { get; set; }

    [JsonProperty("start_time")]
    public DateTime StartTime { get; set; }
    [JsonProperty("stop_time")]
    public DateTime StopTime { get; set; }

    public Relationship()
    {
        SourceRef = string.Empty;
        TargetRef = string.Empty;
        RelationshipType = string.Empty;

    }
}
