using Newtonsoft.Json;
using StixNet.Schemas;
using StixNet.Schemas.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StixNet.Sdos;
public class Grouping: STIXObject
{
    public string? Name { get; set; }
    public string? Description { get; set; }

    /// <summary>
    /// open-vocab
    /// </summary>
    [JsonProperty(Required = Required.Always)]
    public string Context { get; set; }
    /// <summary>
    /// identifier
    /// </summary>
    public IEnumerable<string> ObjectRefs { get; set; } 

    public Grouping()
    {
        Context = string.Empty;
        ObjectRefs = Enumerable.Empty<string>();
    }
}
