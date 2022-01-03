using StixNet.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
