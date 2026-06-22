using MemoryPack;
using Serialization.Core;
using System.Text.Json;

namespace Serialization.Tests;

public class MemoryPackTest
{
    [Test]
    public async Task MemoryPackSerializeDeserializeTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var serialized = MemoryPackSerializer.Serialize(item);
            var deserialized = MemoryPackSerializer.Deserialize<HyperClass>(serialized);
            await Assert.That(item).IsEquivalentTo(deserialized);
            await Assert.That(item).IsNotEqualTo(deserialized);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var serialized = MemoryPackSerializer.Serialize(item);
            var deserialized = MemoryPackSerializer.Deserialize<MyClass>(serialized);
            await Assert.That(item).IsEquivalentTo(deserialized);
            await Assert.That(item).IsNotEqualTo(deserialized);
        }

        // MemoryPack does not support Nested Class
        //{
        //    var item = new NestClass();
        //    item.Initialize();
        //    var serialized = MemoryPackSerializer.Serialize(item);
        //    var deserialized = MemoryPackSerializer.Deserialize<NestClass>(serialized);
        //    itemAssert.Equivalent(deserialized);
        //    itemAssert.NotEqual(deserialized);
        //}

        {
            var item = new Primitives();
            item.Initialize();
            var serialized = MemoryPackSerializer.Serialize(item);
            var deserialized = MemoryPackSerializer.Deserialize<Primitives>(serialized);
            await Assert.That(item).IsEquivalentTo(deserialized);
            await Assert.That(item).IsNotEqualTo(deserialized);
        }
    }

    [Test]
    public async Task SerializeDeserializeMatchSystemTextJsonTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var s1 = MemoryPackSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.HyperClass);
            var d1 = MemoryPackSerializer.Deserialize<HyperClass>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.HyperClass);
            await Assert.That(d1).IsEquivalentTo(d2);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var s1 = MemoryPackSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.MyClass);
            var d1 = MemoryPackSerializer.Deserialize<MyClass>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.MyClass);
            await Assert.That(d1).IsEquivalentTo(d2);
        }

        // MemoryPack does not support Nested Class
        //{
        //    var item = new NestClass();
        //    item.Initialize();
        //    var s1 = MemoryPackSerializer.Serialize(item);
        //    var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.NestClass);
        //    var d1 = MemoryPackSerializer.Deserialize<NestClass>(s1);
        //    var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.NestClass);
        //    Assert.Equivalent(d2, d1);
        //}

        {
            var item = new Primitives();
            item.Initialize();
            var s1 = MemoryPackSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.Primitives);
            var d1 = MemoryPackSerializer.Deserialize<Primitives>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.Primitives);
            await Assert.That(d1).IsEquivalentTo(d2);
        }
    }
}
