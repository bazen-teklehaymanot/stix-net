using StixNet.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StixNet.Sdos;

public class Report: STIXObject
{
    // name, description, report_types, published, object_refs
    public string? Name { get; set; }
    public DateTime Published { get; set; }
    public string? Description { get; set; }
    public IEnumerable<string> ObjectRefs { get; set; } // list of identifier
    public IEnumerable<string> ReportTypes { get; set; } // list of open-vocab

    public Report()
    {
        ObjectRefs = new List<string>();
        ReportTypes = new List<string>();
    }
}
