using System.Text.Json.Serialization.Metadata;

namespace Serialization.Core;

public static class SerializerAccessor
{
    // System.Text.Json
    public static string SerializeSystemTextJson<T>(T item, JsonTypeInfo<T> context)
    {
        return System.Text.Json.JsonSerializer.Serialize<T>(item, context);
    }
    public static T? DeserializeSystemTextJson<T>(string utf8json, JsonTypeInfo<T> context)
    {
        return System.Text.Json.JsonSerializer.Deserialize<T>(utf8json, context);
    }
}
