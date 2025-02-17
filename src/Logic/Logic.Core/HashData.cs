using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Logic.Core;

public static class HashData
{
    /// <summary>
    /// Get MD5 Hash for string
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string MD5HashData(string content)
    {
        var inputs = new UTF8Encoding(false).GetBytes(content).AsSpan();
        var hashes = MD5.HashData(inputs).AsSpan();
        return ToString(hashes);
    }

    /// <summary>
    /// Get SHA1 Hash for string
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string SHA1HashData(string content)
    {
        var inputs = new UTF8Encoding(false).GetBytes(content).AsSpan();
        var hashes = SHA1.HashData(inputs).AsSpan();
        return ToString(hashes);
    }

    /// <summary>
    /// Get SHA256 Hash for string
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string SHA256HashData(string content)
    {
        var inputs = new UTF8Encoding(false).GetBytes(content).AsSpan();
        var hashes = SHA256.HashData(inputs).AsSpan();
        return ToString(hashes);
    }

    /// <summary>
    /// Get SHA512 Hash for string
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string SHA512HashData(string content)
    {
        var inputs = new UTF8Encoding(false).GetBytes(content).AsSpan();
        var hashes = SHA512.HashData(inputs).AsSpan();
        return ToString(hashes);
    }

    /// <summary>
    /// Get XxHash32 Hash for string
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string XxHash32HashData(string content)
    {
        var inputs = new UTF8Encoding(false).GetBytes(content).AsSpan();
        var hashes = System.IO.Hashing.XxHash32.Hash(inputs).AsSpan();
        return ToString(hashes);
    }

    /// <summary>
    /// Get XxHash64 Hash for string
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string XxHash64HashData(string content)
    {
        var inputs = new UTF8Encoding(false).GetBytes(content).AsSpan();
        var hashes = System.IO.Hashing.XxHash64.Hash(inputs).AsSpan();
        return ToString(hashes);
    }

    /// <summary>
    /// Get XxHash128 Hash for string
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    public static string XxHash128HashData(string content)
    {
        var inputs = new UTF8Encoding(false).GetBytes(content).AsSpan();
        var hashes = System.IO.Hashing.XxHash128.Hash(inputs).AsSpan();
        return ToString(hashes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static string ToString(ReadOnlySpan<byte> hashes)
    {
        var sb = new StringBuilder();
        foreach (var hash in hashes)
            sb.Append(hash.ToString("x2"));
        return sb.ToString();
    }
}
