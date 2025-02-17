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
            var serialized = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.HyperClass);
            var deserialized = JsonSerializer.Deserialize(serialized, SourceGenerationJsonSerializerContext.Default.HyperClass);
            Assert.Equivalent(deserialized, item);
            Assert.NotEqual(deserialized, item);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var serialized = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.MyClass);
            var deserialized = JsonSerializer.Deserialize(serialized, SourceGenerationJsonSerializerContext.Default.MyClass);
            Assert.Equivalent(deserialized, item);
            Assert.NotEqual(deserialized, item);
        }

        {
            var item = new NestClass();
            item.Initialize();
            var serialized = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.NestClass);
            var deserialized = JsonSerializer.Deserialize(serialized, SourceGenerationJsonSerializerContext.Default.NestClass);
            Assert.Equivalent(deserialized, item);
            Assert.NotEqual(deserialized, item);
        }

        {
            var item = new Primitives();
            item.Initialize();
            var serialized = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.Primitives);
            var deserialized = JsonSerializer.Deserialize(serialized, SourceGenerationJsonSerializerContext.Default.Primitives);
            Assert.Equivalent(deserialized, item);
            Assert.NotEqual(deserialized, item);
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
            Assert.Equivalent(item, d1);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<MyClass>(s1);
            Assert.Equivalent(item, d1);
        }

        {
            var item = new NestClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<NestClass>(s1);
            Assert.Equivalent(item, d1);
        }

        {
            var item = new Primitives();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<Primitives>(s1);
            Assert.Equivalent(item, d1);
        }
    }

    [Fact]
    public void TwoSerializeDeserializeMatchTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.HyperClass);
            var d1 = JsonSerializer.Deserialize<HyperClass>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.HyperClass);
            Assert.Equivalent(d2, d1);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.MyClass);
            var d1 = JsonSerializer.Deserialize<MyClass>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.MyClass);
            Assert.Equivalent(d2, d1);
        }

        {
            var item = new NestClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.NestClass);
            var d1 = JsonSerializer.Deserialize<NestClass>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.NestClass);
            Assert.Equivalent(d2, d1);
        }

        {
            var item = new Primitives();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.Primitives);
            var d1 = JsonSerializer.Deserialize<Primitives>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.Primitives);
            Assert.Equivalent(d2, d1);
        }
    }
}
