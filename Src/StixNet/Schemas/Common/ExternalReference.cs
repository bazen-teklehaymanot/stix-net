using Newtonsoft.Json;

namespace StixNet.Schemas.Common;

public sealed class ExternalReference
{
    [JsonProperty("source_name", Required = Required.Always)]
    public string SourceName { get; set; }
    public string? Description { get; set; }
    public string? Url { get; set; }
    public Dictionary<string, string> Hashes { get; set; }
    [JsonProperty("external_id")]
    public string? ExternalId { get; set; }


    public ExternalReference()
    {
        SourceName = string.Empty;
        Hashes = new Dictionary<string, string>();
    }
}

