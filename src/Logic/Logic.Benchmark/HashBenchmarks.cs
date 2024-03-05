using BenchmarkDotNet.Attributes;
using Logic.Core;
using System.ComponentModel;
using System.IO.Hashing;
using System.Security.Cryptography;

namespace Logic.Benchmark;

[ShortRunJob]
[MemoryDiagnoser]
[MinColumn, MaxColumn]
[CategoriesColumn]
public class HashBenchmarks
{
    public static IEnumerable<byte[]> TestBinaryData()
    {
        yield return new byte[1024 * 1024];
    }

    public static IEnumerable<string> TestStringData()
    {
        yield return "KLVJMjiNoaU3msNg4shw0Agf3Au45ivJYkJpTEVMK4xxz4Ff2rUyk40g4FDS64HEC0qZfHpjoy0BHj5GEzPtzeKWn2dDNEXpSFW40iT0uAEa5IHGry72ncuitHwvrvbhAQSzZ7TmpfGKhRABQYTy6ZLI5vg20t2z";
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestBinaryData))]
    [Category(HashCategories.Binary)]
    public void MD5Binary(byte[] data)
    {
        MD5.HashData(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestStringData))]
    [Category(HashCategories.String)]
    public void MD5String(string data)
    {
        HashData.MD5HashData(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestBinaryData))]
    [Category(HashCategories.Binary)]
    public void SHA1Binary(byte[] data)
    {
        SHA1.HashData(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestStringData))]
    [Category(HashCategories.String)]
    public void SHA1String(string data)
    {
        HashData.SHA1HashData(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestBinaryData))]
    [Category(HashCategories.Binary)]
    public void SHA256Binary(byte[] data)
    {
        SHA256.HashData(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestStringData))]
    [Category(HashCategories.String)]
    public void SHA256String(string data)
    {
        HashData.SHA256HashData(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestBinaryData))]
    [Category(HashCategories.Binary)]
    public void SHA512Binary(byte[] data)
    {
        SHA512.HashData(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestStringData))]
    [Category(HashCategories.String)]
    public void SHA512String(string data)
    {
        HashData.SHA512HashData(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestBinaryData))]
    [Category(HashCategories.Binary)]
    public void XxHash32Binary(byte[] data)
    {
        XxHash32.Hash(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestStringData))]
    [Category(HashCategories.String)]
    public void XxHash32String(string data)
    {
        HashData.XxHash32HashData(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestBinaryData))]
    [Category(HashCategories.Binary)]
    public void XxHash64Binary(byte[] data)
    {
        XxHash64.Hash(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestStringData))]
    [Category(HashCategories.String)]
    public void XxHash64String(string data)
    {
        HashData.XxHash64HashData(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestBinaryData))]
    [Category(HashCategories.Binary)]
    public void XxHash128Binary(byte[] data)
    {
        XxHash128.Hash(data);
    }

    [Benchmark]
    [ArgumentsSource(nameof(TestStringData))]
    [Category(HashCategories.String)]
    public void XxHash128String(string data)
    {
        HashData.XxHash128HashData(data);
    }
}
