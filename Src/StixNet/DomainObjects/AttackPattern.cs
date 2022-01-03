using Newtonsoft.Json;
using StixNet.Base;
using StixNet.CommonTypes;

namespace StixNet.Sdos;

public class AttackPattern: STIXObject
{
    [JsonProperty(Required = Required.Always)]
    public string Name { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string> Aliases { get; set; }
    [JsonProperty("kill_chain_phases")]
    public IEnumerable<KillChainPhase> KillChainPhases { get; set; }

    public AttackPattern()
    {
        Name = string.Empty;
        Aliases = Enumerable.Empty<string>();
        KillChainPhases = Enumerable.Empty<KillChainPhase>();
    }

}
