using StixNet.Schemas;
using StixNet.Schemas.Common;

namespace StixNet.MetaObjects;

public class MarkingDefinition: STIXObject
{
    public string? Name { get; set; }
    public string? DefinitionType { get; set; }
    public MarkingObject? Definition { get; set; } 
}
