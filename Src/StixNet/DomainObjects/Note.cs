using StixNet.Base;

namespace StixNet.Sdos;

public class Note: STIXObject
{
    // abstract, content, authors, object_refs
    public string? Abstract { get; set; }
    public string? Content { get; set; }
    public IEnumerable<string> Authors { get; set; }
    public IEnumerable<string> ObjectRefs { get; set; } // list of identifiers

    public Note()
    {
        Authors = new List<string>();
        ObjectRefs = new List<string>();
    }
}

