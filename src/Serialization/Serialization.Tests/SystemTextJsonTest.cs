using Serialization.Core;
using System.Text.Json;
using System.Threading.Tasks;

namespace Serialization.Tests;

public class SystemTextJsonTest
{
    [Test]
    public async Task SourceGeneratorSerializeDeserializeTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var serialized = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.HyperClass);
            var deserialized = JsonSerializer.Deserialize(serialized, SourceGenerationJsonSerializerContext.Default.HyperClass);
            await Assert.That(item).IsEquivalentTo(deserialized);
            await Assert.That(item).IsNotEqualTo(deserialized);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var serialized = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.MyClass);
            var deserialized = JsonSerializer.Deserialize(serialized, SourceGenerationJsonSerializerContext.Default.MyClass);
            await Assert.That(item).IsEquivalentTo(deserialized);
            await Assert.That(item).IsNotEqualTo(deserialized);
        }

        {
            var item = new NestClass();
            item.Initialize();
            var serialized = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.NestClass);
            var deserialized = JsonSerializer.Deserialize(serialized, SourceGenerationJsonSerializerContext.Default.NestClass);
            await Assert.That(item).IsEquivalentTo(deserialized);
            await Assert.That(item).IsNotEqualTo(deserialized);
        }

        {
            var item = new Primitives();
            item.Initialize();
            var serialized = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.Primitives);
            var deserialized = JsonSerializer.Deserialize(serialized, SourceGenerationJsonSerializerContext.Default.Primitives);
            await Assert.That(item).IsEquivalentTo(deserialized);
            await Assert.That(item).IsNotEqualTo(deserialized);
        }
    }

    [Test]
    public async Task NonSourceGeneratorSerializeDeserializeTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<HyperClass>(s1);
            await Assert.That(d1).IsEquivalentTo(item);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<MyClass>(s1);
            await Assert.That(d1).IsEquivalentTo(item);
        }

        {
            var item = new NestClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<NestClass>(s1);
            await Assert.That(d1).IsEquivalentTo(item);
        }

        {
            var item = new Primitives();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var d1 = JsonSerializer.Deserialize<Primitives>(s1);
            await Assert.That(d1).IsEquivalentTo(item);
        }
    }

    [Test]
    public async Task TwoSerializeDeserializeMatchTest()
    {
        {
            var item = new HyperClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.HyperClass);
            var d1 = JsonSerializer.Deserialize<HyperClass>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.HyperClass);
            await Assert.That(d1).IsEquivalentTo(d2);
        }

        {
            var item = new MyClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.MyClass);
            var d1 = JsonSerializer.Deserialize<MyClass>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.MyClass);
            await Assert.That(d1).IsEquivalentTo(d2);
        }

        {
            var item = new NestClass();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.NestClass);
            var d1 = JsonSerializer.Deserialize<NestClass>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.NestClass);
            await Assert.That(d1).IsEquivalentTo(d2);
        }

        {
            var item = new Primitives();
            item.Initialize();
            var s1 = JsonSerializer.Serialize(item);
            var s2 = JsonSerializer.Serialize(item, SourceGenerationJsonSerializerContext.Default.Primitives);
            var d1 = JsonSerializer.Deserialize<Primitives>(s1);
            var d2 = JsonSerializer.Deserialize(s2, SourceGenerationJsonSerializerContext.Default.Primitives);
            await Assert.That(d1).IsEquivalentTo(d2);
        }
    }
}