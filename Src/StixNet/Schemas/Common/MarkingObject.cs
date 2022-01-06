using Newtonsoft.Json;

namespace StixNet.Schemas.Common;

public class MarkingObject
{

}


public class StatementMarkingObject : MarkingObject
{
    [JsonProperty(Required = Required.Always)]
    public string Statement { get; set; }
    public StatementMarkingObject()
    {
        Statement = string.Empty;
    }
}



public class TLPMarkingObject : MarkingObject
{
    [JsonProperty(Required = Required.Always)]
    public string Tlp { get; set; }
    public TLPMarkingObject()
    {
        Tlp = string.Empty;
    }
}