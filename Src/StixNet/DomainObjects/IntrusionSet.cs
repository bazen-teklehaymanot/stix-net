using StixNet.Base;

namespace StixNet.Sdos;
public class IntrusionSet : STIXObject
{
    //name, description, aliases, first_seen, last_seen, goals, resource_level, 
    //primary_motivation, secondary_motivations
    public string? Name { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string> Aliases { get; set; }
    public DateTime FirstSeen { get; set; }
    public DateTime LastSeen { get; set; }
    public IEnumerable<string> Goals { get; set; }
    public string? ResourceLevel { get; set; } // open-vocab
    public string? PrimaryMotivation { get; set; } // open-vocab
    public IEnumerable<string> SecondaryMotivations { get; set; } // list open-vocab


    public IntrusionSet()
    {
        Goals = new List<string>();
        Aliases = new List<string>();
        SecondaryMotivations = new List<string>();  
    }
}
