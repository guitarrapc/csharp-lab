using System.Text.Json.Serialization;

namespace Serialization.Core;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(HyperClass))]
[JsonSerializable(typeof(MyClass))]
[JsonSerializable(typeof(NestClass))]
[JsonSerializable(typeof(Primitives))]
public partial class SourceGenerationJsonSerializerContext : JsonSerializerContext
{
}
