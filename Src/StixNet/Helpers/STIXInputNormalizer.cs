using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StixNet.Helpers;

internal sealed class STIXInputNormalizer
{
    public string Stix { get; set; }
    public string Json { get; set; }
    public STIXInputNormalizer(string stixInput)
    {
        Stix = stixInput;
        Json = Normalize(stixInput);
    }

    private string Normalize(string stixInput) 
    {
        var pattern = "(?<jsonKey>\"pattern\")(\\s*:\\s*\"\\s*)(?<jsonValue>.*)(\")";
        return Regex.Replace(stixInput, pattern, HandleMatchEvaluation);
    }
    private string HandleMatchEvaluation(Match match)
    {
        var res = match.Value;
        var jsonValue = match.Groups["jsonValue"];
        if (jsonValue != null) 
        {
            res = res.Replace(jsonValue.Value, jsonValue.Value.Replace("\"", "\\\""));
        }
        return res;
    }
}
