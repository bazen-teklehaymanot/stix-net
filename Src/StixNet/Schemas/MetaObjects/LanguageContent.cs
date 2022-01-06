using StixNet.Schemas;

namespace StixNet.MetaObjects;

public class LanguageContent : STIXObject
{
    // object_ref, object_modified, contents
    public string? ObjectRef { get; set; }
    public DateTime ObjectModified { get; set; }
    public IDictionary<string, object> Contents { get; set; }

    public LanguageContent()
    {
        Contents = new Dictionary<string, object>();
    }
}
