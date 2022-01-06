using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using StixNet.MetaObjects;
using StixNet.Schemas;
using StixNet.Sdos;
using StixNet.Sros;

internal class STIXObjectJsonConverter : JsonConverter<STIXObject>
{
    public override void WriteJson(JsonWriter writer, STIXObject? value, JsonSerializer serializer)
    {
        if (value is null)
            throw new ArgumentNullException(nameof(value));
        JToken t = JToken.FromObject(value);
        if (t.Type != JTokenType.Object)
        {
            t.WriteTo(writer);
        }
        else
        {
            JObject o = (JObject)t;
            o.WriteTo(writer);
        }
    }

    public override STIXObject ReadJson(JsonReader reader, Type objectType, STIXObject? existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        if (reader is null)
            throw new ArgumentNullException(nameof(reader));
        var jobject = JObject.Load(reader);
        var instance = GetInstance(jobject.Value<string>("type"));
        serializer.Populate(jobject.CreateReader(), instance);

        return instance;
    }


    private static STIXObject GetInstance(string type)
    {
        return type switch
        {
            //Domain objects
            STIXObjectTypes.DomainObject.AttackPattern => new AttackPattern(),
            STIXObjectTypes.DomainObject.Campaign => new Campaign(),
            STIXObjectTypes.DomainObject.CourseOfAction => new CourseOfAction(),
            STIXObjectTypes.DomainObject.Grouping => new Grouping(),
            STIXObjectTypes.DomainObject.Identity => new Identity(),
            STIXObjectTypes.DomainObject.Incident => new Incident(),
            STIXObjectTypes.DomainObject.Infrastructure => new Infrastructure(),
            STIXObjectTypes.DomainObject.IntrusionSet => new IntrusionSet(),
            STIXObjectTypes.DomainObject.Location => new Location(),
            STIXObjectTypes.DomainObject.Malware => new Malware(),
            STIXObjectTypes.DomainObject.MalwareAnalysis => new MalwareAnalysis(),
            STIXObjectTypes.DomainObject.Note => new Note(),
            STIXObjectTypes.DomainObject.ObservedData => new ObservedData(),
            STIXObjectTypes.DomainObject.Opinion => new Opinion(),
            STIXObjectTypes.DomainObject.Report => new Report(),
            STIXObjectTypes.DomainObject.ThreatActor => new ThreatActor(),
            STIXObjectTypes.DomainObject.Tool => new Tool(),
            STIXObjectTypes.DomainObject.Indicator => new Indicator(),
            STIXObjectTypes.DomainObject.Vulnerability => new Vulnerability(),

            //Relationship objects
            STIXObjectTypes.RelationshipObject.Relationship => new Relationship(),
            STIXObjectTypes.RelationshipObject.Sighting => new Sighting(),

            //Meta objects
            STIXObjectTypes.MetaObjects.LanguageContent => new LanguageContent(),
            STIXObjectTypes.MetaObjects.MarkingDefinition => new MarkingDefinition(),
            STIXObjectTypes.MetaObjects.ExtensionDefinition => new ExtensionDefinition(),



            _ => throw new NotImplementedException()
        };
    }

}
