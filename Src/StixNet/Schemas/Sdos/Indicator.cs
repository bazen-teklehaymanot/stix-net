using Newtonsoft.Json;

using StixNet.Schemas;
using StixNet.Schemas.Common;

namespace StixNet.Sdos;

public class Indicator: STIXObject
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    /// <summary>
    /// open-vocab
    /// </summary>
    [JsonProperty("indicator_types")]
    public IEnumerable<string> IndicatorTypes { get; set; }
    public string Pattern { get; set; }
    /// <summary>
    /// open-vocab
    /// </summary>
    public string PatternType { get; set; }
    [JsonProperty("pattern_version")]
    public string? PatternVersion { get; set; }
    [JsonProperty("valid_from")]
    public DateTime ValidFrom { get; set; }
    [JsonProperty("valid_until")]
    public DateTime ValidUntil { get; set; }
    [JsonProperty("kill_chain_phases")]
    public IEnumerable<KillChainPhase> KillChainPhases { get; set; } // list of type kill-chainphase

    public Indicator()
    {
        IndicatorTypes = Enumerable.Empty<string>();
        KillChainPhases = Enumerable.Empty<KillChainPhase>();
    }
}

