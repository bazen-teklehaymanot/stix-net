using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using StixNet.Base;
using StixNet.MetaObjects;
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


    private STIXObject GetInstance(string type)
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


    private STIXObject CastToStrongType(object value)
    {
        var type = (value as Dictionary<string, object>)?["type"] ?? new InvalidDataException("Invalid STIX object");
        return type switch
        {
            //Domain objects
            STIXObjectTypes.DomainObject.AttackPattern => (AttackPattern)value,
            STIXObjectTypes.DomainObject.Campaign => (Campaign)value,
            STIXObjectTypes.DomainObject.CourseOfAction => (CourseOfAction)value,
            STIXObjectTypes.DomainObject.Grouping => (Grouping)value,
            STIXObjectTypes.DomainObject.Identity => (Identity)value,
            STIXObjectTypes.DomainObject.Incident => (Incident)value,
            STIXObjectTypes.DomainObject.Infrastructure => (Infrastructure)value,
            STIXObjectTypes.DomainObject.IntrusionSet => (IntrusionSet)value,
            STIXObjectTypes.DomainObject.Location => (Location)value,
            STIXObjectTypes.DomainObject.Malware => (Malware)value,
            STIXObjectTypes.DomainObject.MalwareAnalysis => (MalwareAnalysis)value,
            STIXObjectTypes.DomainObject.Note => (Note)value,
            STIXObjectTypes.DomainObject.ObservedData => (ObservedData)value,
            STIXObjectTypes.DomainObject.Opinion => (Opinion)value,
            STIXObjectTypes.DomainObject.Report => (Report)value,
            STIXObjectTypes.DomainObject.ThreatActor => (ThreatActor)value,
            STIXObjectTypes.DomainObject.Tool => (Tool)value,
            STIXObjectTypes.DomainObject.Indicator => (Indicator)value,
            STIXObjectTypes.DomainObject.Vulnerability => (Vulnerability)value,

            //Relationship objects
            STIXObjectTypes.RelationshipObject.Relationship => (Relationship)value,
            STIXObjectTypes.RelationshipObject.Sighting => (Sighting)value,

            //Meta objects
            STIXObjectTypes.MetaObjects.LanguageContent => (LanguageContent)value,
            STIXObjectTypes.MetaObjects.MarkingDefinition => (MarkingDefinition)value,
            STIXObjectTypes.MetaObjects.ExtensionDefinition => (ExtensionDefinition)value,



            _ => throw new NotImplementedException()
        };
    }
}
