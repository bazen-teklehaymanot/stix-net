using StixNet.Base;
using StixNet.CommonTypes;

namespace StixNet.MetaObjects;

public class MarkingDefinition: STIXObject
{
    public string? Name { get; set; }
    public string? DefinitionType { get; set; }
    public MarkingObject? Definition { get; set; } 
}
