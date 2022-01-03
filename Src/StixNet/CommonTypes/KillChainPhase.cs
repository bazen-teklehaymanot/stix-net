using Newtonsoft.Json;

namespace StixNet.CommonTypes;

public class KillChainPhase
{
    [JsonProperty("kill_chain_name", Required = Required.Always)]
    public string KillChainName { get; set; }


    [JsonProperty("phase_name", Required = Required.Always)]
    public string PhaseName { get; set; }

    public KillChainPhase()
    {
        PhaseName = string.Empty;
        KillChainName = string.Empty;
    }
}
