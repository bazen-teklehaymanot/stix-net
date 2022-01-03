using StixNet.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StixNet.Sdos;

public class ThreatActor : STIXObject
{
    //    name, description, threat_actor_types, aliases, first_seen, last_seen, roles, goals, 
    //sophistication, resource_level, primary_motivation, secondary_motivations, 
    //personal_motivations

    public string? Name { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string> ThreatActorTypes { get; set; } // list of open-vocab 
    public IEnumerable<string> Aliases { get; set; }
    public DateTime FirstSeen { get; set; }
    public DateTime LastSeen { get; set; }
    public IEnumerable<string> Roles { get; set; } // list of open-vocab
    public IEnumerable<string> Goals { get; set; } 
    public string? Sophistication { get; set; } // open-vocab
    public string? ResourceLevel { get; set; }  // open-vocab
    public string? PrimaryMotivation { get; set; } // open-vocab
    public IEnumerable<string> SecondaryMotivations { get; set; } // list of open vocab
    public IEnumerable<string> PersonalMotivations { get; set; } // list of open vocab



    public ThreatActor()
    {
        Aliases = new List<string>();
        ThreatActorTypes = new List<string>();
        Roles = new List<string>();
        Goals = new List<string>();
        SecondaryMotivations = new List<string>();
        PersonalMotivations = new List<string>();
    }
}
