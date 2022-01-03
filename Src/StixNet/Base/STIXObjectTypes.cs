namespace StixNet.Base;

internal static class STIXObjectTypes
{
    public static class DomainObject
    {
        public const string AttackPattern = "attack-pattern";
        public const string Campaign = "campaign";
        public const string CourseOfAction = "course-of-action";
        public const string Grouping = "grouping";
        public const string Identity = "identity";
        public const string Incident = "incident";
        public const string Indicator = "indicator";
        public const string Infrastructure = "infrastructure";
        public const string IntrusionSet = "intrusion-set";
        public const string Location = "location";
        public const string Malware = "malware";
        public const string MalwareAnalysis = "malware-analysis";
        public const string Note = "note";
        public const string ObservedData = "observed-data";
        public const string Opinion = "opinion";
        public const string Report = "report";
        public const string ThreatActor = "threat-actor";
        public const string Tool = "tool";
        public const string Vulnerability = "vulnerability";
    }

    public static class RelationshipObject
    {
        public const string Relationship = "relationship";
        public const string Sighting = "sighting";
    }

    public static class CyberObservableObject
    {

    }

    public static class MetaObjects
    {
        public const string ExtensionDefinition = "extension-definition";
        public const string LanguageContent = "language-content";
        public const string MarkingDefinition = "marking-definition";
    }

    public static class BundleObject 
    {
        public const string Bundle = "bundle";
    }


}
