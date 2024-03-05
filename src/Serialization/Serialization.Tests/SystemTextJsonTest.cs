using Serialization.Core;
using System.Text.Json;

namespace Serialization.Tests;

public class SystemTextJsonTest
{
    [Fact]
    public void SourceGeneratorSerializeDeserializeTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var serialized = SerializerAccessor.SerializeSystemTextJson(item, SourceGenerationJsonSerializerContext.Default.HyperClass);
            var deserialized = SerializerAccessor.DeserializeSystemTextJson(serialized, SourceGenerationJsonSerializerContext.Default.HyperClass);
            item.Should().BeEquivalentTo(deserialized);
            item.Should().NotBe(deserialized);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var serialized = SerializerAccessor.SerializeSystemTextJson(item, SourceGenerationJsonSerializerContext.Default.MyClass);
            var deserialized = SerializerAccessor.DeserializeSystemTextJson(serialized, SourceGenerationJsonSerializerContext.Default.MyClass);
            item.Should().BeEquivalentTo(deserialized);
            item.Should().NotBe(deserialized);
        }

        {
            var item = new NestClass();
            item.Initialize();
            var serialized = SerializerAccessor.SerializeSystemTextJson(item, SourceGenerationJsonSerializerContext.Default.NestClass);
            var deserialized = SerializerAccessor.DeserializeSystemTextJson(serialized, SourceGenerationJsonSerializerContext.Default.NestClass);
            item.Should().BeEquivalentTo(deserialized);
            item.Should().NotBe(deserialized);
        }

        {
            var item = new Primitives();
            item.Initialize();
            var serialized = SerializerAccessor.SerializeSystemTextJson(item, SourceGenerationJsonSerializerContext.Default.Primitives);
            var deserialized = SerializerAccessor.DeserializeSystemTextJson(serialized, SourceGenerationJsonSerializerContext.Default.Primitives);
            item.Should().BeEquivalentTo(deserialized);
            item.Should().NotBe(deserialized);
        }
    }

    [Fact]
    public void NonSourceGeneratorSerializeDeserializeTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<HyperClass>(s1);
            d1.Should().BeEquivalentTo(item);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<MyClass>(s1);
            d1.Should().BeEquivalentTo(item);
        }

        {
            var item = new NestClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<NestClass>(s1);
            d1.Should().BeEquivalentTo(item);
        }

        {
            var item = new Primitives();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<Primitives>(s1);
            d1.Should().BeEquivalentTo(item);
        }
    }

    [Fact]
    public void TwoSerializeDeserializeMatchTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = SerializerAccessor.SerializeSystemTextJson(item, SourceGenerationJsonSerializerContext.Default.HyperClass);
            var d1 = JsonSerializer.Deserialize<HyperClass>(s1);
            var d2 = SerializerAccessor.DeserializeSystemTextJson(s2, SourceGenerationJsonSerializerContext.Default.HyperClass);
            d1.Should().BeEquivalentTo(d2);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = SerializerAccessor.SerializeSystemTextJson(item, SourceGenerationJsonSerializerContext.Default.MyClass);
            var d1 = JsonSerializer.Deserialize<MyClass>(s1);
            var d2 = SerializerAccessor.DeserializeSystemTextJson(s2, SourceGenerationJsonSerializerContext.Default.MyClass);
            d1.Should().BeEquivalentTo(d2);
        }

        {
            var item = new NestClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = SerializerAccessor.SerializeSystemTextJson(item, SourceGenerationJsonSerializerContext.Default.NestClass);
            var d1 = JsonSerializer.Deserialize<NestClass>(s1);
            var d2 = SerializerAccessor.DeserializeSystemTextJson(s2, SourceGenerationJsonSerializerContext.Default.NestClass);
            d1.Should().BeEquivalentTo(d2);
        }

        {
            var item = new Primitives();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = SerializerAccessor.SerializeSystemTextJson(item, SourceGenerationJsonSerializerContext.Default.Primitives);
            var d1 = JsonSerializer.Deserialize<Primitives>(s1);
            var d2 = SerializerAccessor.DeserializeSystemTextJson(s2, SourceGenerationJsonSerializerContext.Default.Primitives);
            d1.Should().BeEquivalentTo(d2);
        }
    }
}
