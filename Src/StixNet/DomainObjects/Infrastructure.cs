using Newtonsoft.Json;
using StixNet.Base;
using StixNet.CommonTypes;

namespace StixNet.Sdos;

public class Infrastructure: STIXObject
{
    // name, description, infrastructure_types, aliases, kill_chain_phases, first_seen, 
    // last_seen

    public string? Name { get; set; }
    public DateTime LastSeen { get; set; }
    public DateTime FirstSeen { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string> Aliases { get; set; }
    /// <summary>
    /// open-vocab
    /// </summary>
    [JsonProperty("infrastructure_types")]
    public IEnumerable<string> InfrastructureTypes { get; set; }
    [JsonProperty("kill_chain_phases")]
    public IEnumerable<KillChainPhase> KillChainPhases { get; set; }

    public Infrastructure()
    {
        Aliases = new List<string>();
        KillChainPhases = Enumerable.Empty<KillChainPhase>();
        InfrastructureTypes = Enumerable.Empty<string>();
    }
}

