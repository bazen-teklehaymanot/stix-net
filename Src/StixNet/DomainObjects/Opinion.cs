using StixNet.Base;

namespace StixNet.Sdos;

public class Opinion: STIXObject
{
    public string? Opinoin { get; set; } // opinion-enum
    public string? Explanation { get; set; }
    public IEnumerable<string> Authors { get; set; }
    public IEnumerable<string> ObjectRefs { get; set; } // list of type identifier

    public Opinion()
    {
        Authors = new List<string>();
        ObjectRefs = new List<string>();
    }
}
