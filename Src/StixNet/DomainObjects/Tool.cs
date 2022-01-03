using StixNet.Base;

namespace StixNet.Sdos;

public class Tool: STIXObject
{
    // name, description, tool_types, aliases, kill_chain_phases, tool_version
    public string? Name { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string> ToolTypes { get; set; } // list of open vocabs 
    public IEnumerable<string> Aliases { get; set; }   
    public IEnumerable<string> KillChainPhases { get; set; } //list of kill chain phases
    public string? ToolVersion { get; set; } 


    public Tool()
    {
        Aliases = new List<string>();
        ToolTypes = new List<string>();
        KillChainPhases = new List<string>();
    }
}
