using Newtonsoft.Json;

using StixNet.Base;

namespace StixNet.Sros;

public class Sighting: STIXObject
{
    public int Count { get; set; }
    public string? Description { get; set; }
    [JsonProperty("first_seen")]
    public DateTime FirstSeen { get; set; }
    [JsonProperty("last_seen")]
    public DateTime LastSeen { get; set; }
    /// <summary>
    /// identifier
    /// </summary>
    [JsonProperty("sighting_of_ref")]
    public string SightingOfRef { get; set; }
    /// <summary>
    /// identifier
    /// </summary>
    [JsonProperty("observed_data_refs")]
    public IEnumerable<string> ObservedDataRefs { get; set; }
    /// <summary>
    /// identifier
    /// </summary>
    [JsonProperty("where_sighted_refs")]
    public IEnumerable<string> WhereSightedRefs { get; set; }
    public bool Summary { get; set; }


    public Sighting()
    {
        SightingOfRef = string.Empty;
        ObservedDataRefs = Enumerable.Empty<string>();
        WhereSightedRefs = Enumerable.Empty<string>();
    }
}

