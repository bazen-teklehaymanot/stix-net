using Newtonsoft.Json;

using StixNet.Schemas;

namespace StixNet.Sdos;

public class Campaign: STIXObject
{
    [JsonProperty(Required = Required.Always)]
    public string Name { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string> Aliases { get; set; }
    [JsonProperty("first_seen")]
    public DateTime FirstSeen { get; set; }

    [JsonProperty("last_seen")]
    public DateTime LastSeen { get; set; }
    public string? Objective { get; set; }

    public Campaign()
    {
        Aliases = Enumerable.Empty<string>();
    }
}

