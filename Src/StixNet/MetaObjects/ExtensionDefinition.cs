using StixNet.Base;

namespace StixNet.MetaObjects;

public sealed class ExtensionDefinition : STIXObject
{
    public string? Name { get; set; }
    public string? Schema { get; set; }
    public string? Version { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string> ExtensionTypes { get; set; }
    public IEnumerable<string> ExtensionProperties { get; set; }

    public ExtensionDefinition()
    {
        ExtensionTypes = new List<string>();
        ExtensionProperties = new List<string>();
    }
}

