using Newtonsoft.Json;

using StixNet.Schemas;
using StixNet.Schemas.Common;
using StixNet.Helpers;

namespace StixNet;

public static class STIXObjectParser
{
    public static STIXObject? ParseSTIXObject(string jsonStr) 
    {
        return JsonConvert.DeserializeObject<STIXObject>(jsonStr, new STIXObjectJsonConverter());
    }
    public static BundleObject? ParseBundleObject(string jsonString) 
    {
        return JsonConvert.DeserializeObject<BundleObject>(jsonString, new BundleObjectJsonConverter());
    }
    public static bool TryParseSTIXObject(string jsonStr,out STIXObject res) 
    {
        res = null;
        try
        {
            res = ParseSTIXObject(ToValidJson(jsonStr));
            if(res is null)
                return false;
            return true;
        }
        catch 
        {
            return false;
        }
    }
    public static bool TryParseBundleObject( string jsonStr,out BundleObject res) 
    {
        res = null;
        try
        {
            res = ParseBundleObject(ToValidJson(jsonStr));
            if(res is null)
                return false;
            return true;
        }
        catch 
        {
            return false;
        }
    }

    private static string ToValidJson(string stix) 
    {
        return new STIXInputNormalizer(stix).Json;
    }
}
