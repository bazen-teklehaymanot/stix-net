using Newtonsoft.Json;
using StixNet.Schemas;
using StixNet.Schemas.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StixNet.Sdos;
public class Identity: STIXObject
{
    [JsonProperty(Required = Required.Always)]
    public string Name { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string> Roles { get; set; }
    /// <summary>
    /// open-vocab
    /// </summary>
    [JsonProperty("identity_class")]

    public string? IdentityClass { get; set; }
    /// <summary>
    /// open-vocab
    /// </summary>
    public IEnumerable<string> Sectors { get; set; }
    [JsonProperty("contact_information")]
    public string? ContactInformation { get; set; }

    public Identity()
    {
        Name = string.Empty;
        Roles = Enumerable.Empty<string>();
        Sectors = Enumerable.Empty<string>();
    }
}

