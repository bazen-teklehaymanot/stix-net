using Newtonsoft.Json;

using StixNet.CommonTypes;

namespace StixNet.Base;

public abstract class STIXObject
{
    //required properties
    public string? Id { get; set; }
    public string? Type { get; set; }
    public string? SpecVersion { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }



    //Optional properties
    [JsonProperty("created_by_ref")]
    public string? CreatedByRef { get; set; }
    public string? Revoked { get; set; }
    public string? Labels { get; set; }
    public string? Confidence { get; set; }
    public string? Lang { get; set; }

    [JsonProperty("object_marking_refs")]
    public IEnumerable<string>? ObjectMarkingRefs { get; set; }
    [JsonProperty("granular_markings")]
    public string? GranularMarkings { get; set; }
    public string? Extensions { get; set; }

    [JsonProperty("external_references")]
    public IEnumerable<ExternalReference> ExternalReferences { get; set; }



    //not applicable
    public string? Defanged { get; set; }

    public STIXObject()
    {
        ExternalReferences = Enumerable.Empty<ExternalReference>();
    }

    public virtual string ToJson()
    => JsonConvert.SerializeObject(this);
}

