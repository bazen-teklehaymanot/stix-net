using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using StixNet.Base;

namespace StixNet.Helpers
{
    internal class BundleObjectJsonConverter: JsonConverter<BundleObject>
    {
        public override void WriteJson(JsonWriter writer, BundleObject? value, JsonSerializer serializer)
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

        public override BundleObject ReadJson(JsonReader reader, Type objectType, BundleObject? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (reader is null)
                throw new ArgumentNullException(nameof(reader));
            var jobject = JObject.Load(reader);
            var objects = jobject["objects"];
            var stixobjects = JsonConvert.DeserializeObject<IEnumerable<STIXObject>>(objects.ToString(),new STIXObjectJsonConverter()) ?? Enumerable.Empty<STIXObject>();
            return new BundleObject
            {
                Id = jobject.Value<string>("id"),
                Type = jobject.Value<string>("type"),
                Objects = stixobjects
            };
        }
    }
}
