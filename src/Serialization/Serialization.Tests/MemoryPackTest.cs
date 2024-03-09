using MemoryPack;
using Serialization.Core;
using System.Text.Json;

namespace Serialization.Tests;

public class MemoryPackTest
{
    [Fact]
    public void MemoryPackSerializeDeserializeTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var serialized = MemoryPackSerializer.Serialize(item);
            var deserialized = MemoryPackSerializer.Deserialize<HyperClass>(serialized);
            item.Should().BeEquivalentTo(deserialized);
            item.Should().NotBe(deserialized);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var serialized = MemoryPackSerializer.Serialize(item);
            var deserialized = MemoryPackSerializer.Deserialize<MyClass>(serialized);
            item.Should().BeEquivalentTo(deserialized);
            item.Should().NotBe(deserialized);
        }

        // MemoryPack does not support Nested Class
        //{
        //    var item = new NestClass();
        //    item.Initialize();
        //    var serialized = MemoryPackSerializer.Serialize(item);
        //    var deserialized = MemoryPackSerializer.Deserialize<NestClass>(serialized);
        //    item.Should().BeEquivalentTo(deserialized);
        //    item.Should().NotBe(deserialized);
        //}

        {
            var item = new Primitives();
            item.Initialize();
            var serialized = MemoryPackSerializer.Serialize(item);
            var deserialized = MemoryPackSerializer.Deserialize<Primitives>(serialized);
            item.Should().BeEquivalentTo(deserialized);
            item.Should().NotBe(deserialized);
        }
    }

    [Fact]
    public void SerializeDeserializeMatchSystemTextJsonTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var s1 = MemoryPackSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.HyperClass);
            var d1 = MemoryPackSerializer.Deserialize<HyperClass>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.HyperClass);
            d1.Should().BeEquivalentTo(d2);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var s1 = MemoryPackSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.MyClass);
            var d1 = MemoryPackSerializer.Deserialize<MyClass>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.MyClass);
            d1.Should().BeEquivalentTo(d2);
        }

        // MemoryPack does not support Nested Class
        //{
        //    var item = new NestClass();
        //    item.Initialize();
        //    var s1 = MemoryPackSerializer.Serialize(item);
        //    var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.NestClass);
        //    var d1 = MemoryPackSerializer.Deserialize<NestClass>(s1);
        //    var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.NestClass);
        //    d1.Should().BeEquivalentTo(d2);
        //}

        {
            var item = new Primitives();
            item.Initialize();
            var s1 = MemoryPackSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.Primitives);
            var d1 = MemoryPackSerializer.Deserialize<Primitives>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.Primitives);
            d1.Should().BeEquivalentTo(d2);
        }
    }
}
