using Newtonsoft.Json;
using StixNet.Schemas;

namespace StixNet.Sdos;

public class Incident: STIXObject
{
    [JsonProperty(Required = Required.Always)]
    public string Name { get; set; }
    public string? Description { get; set; }

    public Incident()
    {
        Name = string.Empty;
    }
}

