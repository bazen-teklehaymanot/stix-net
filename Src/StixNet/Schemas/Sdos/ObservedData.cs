using StixNet.Schemas;

namespace StixNet.Sdos;

public class ObservedData: STIXObject
{
    // first_observed, last_observed, number_observed, objects, object_refs
    public DateTime FirstObserver { get; set; }
    public DateTime LastObserver { get; set; }
    public int NumberObserved { get; set; }
    [Obsolete]
    public IEnumerable<string> Objects { get; set; } // observable-container
    public IEnumerable<string> ObjectRefs { get; set; } //list of type identifier

    public ObservedData()
    {
        Objects = new List<string>();
        ObjectRefs = new List<string>();
    }
}
