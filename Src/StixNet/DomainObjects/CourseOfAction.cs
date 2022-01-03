using Newtonsoft.Json;
using StixNet.Base;

namespace StixNet.Sdos;

public class CourseOfAction: STIXObject
{
    [JsonProperty(Required = Required.Always)]
    public string Name { get; set; }
    public string? Description { get; set; }
    public string? Action { get; set; } // RESERVED

    public CourseOfAction()
    {
        Name = string.Empty;
    }
}

