using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;

namespace Logic.Core;

public class GuidMerge
{
    /// <summary>
    /// Create single GUID from 2 name. This implementation loose GUID randomness, but can create deterministic GUID from desired names.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="other"></param>
    /// <returns></returns>
    public static Guid CreateGuidFromNames(string name, string other)
    {
        ReadOnlySpan<byte> nameBytes = Encoding.UTF8.GetBytes(name);
        ReadOnlySpan<byte> otherBytes = Encoding.UTF8.GetBytes(other);
        Span<byte> combinedBytes = stackalloc byte[nameBytes.Length + otherBytes.Length];

        // fill span
        nameBytes.CopyTo(combinedBytes[..nameBytes.Length]);
        otherBytes.CopyTo(combinedBytes.Slice(nameBytes.Length, otherBytes.Length));

        // Get SHA-1 Hash and use first 16 bytes.
        Span<byte> guidBytes = SHA1.HashData(combinedBytes).AsSpan()[..16];

        // Set UUID variant (10xx -> 2 bits)
        guidBytes[8] = (byte)((guidBytes[8] & 0xBF) | 0x80);

        // Set UUID version (0101 -> 4 bits)
        guidBytes[6] = (byte)((guidBytes[6] & 0x0F) | 0x50);

        return new Guid(guidBytes);
    }

    /// <summary>
    /// Merge two GUID to single GUID by XOR. Use SIMD if available, direct memory operation even no SIMD.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Guid FastMerge(Guid a, Guid b)
    {
        // SIMD. Treat GUID (16byte) as Vector128(8 byte, 8 byte), then Xor each.
        if (Sse2.IsSupported)
        {
            var result = Sse2.Xor(Unsafe.As<Guid, Vector128<long>>(ref a), Unsafe.As<Guid, Vector128<long>>(ref b));
            return Unsafe.As<Vector128<long>, Guid>(ref result);
        }
        else
        {
            // Treat GUID (16byte) as long (8 byte) + long (8 byte), then Xor each.
            var spanA = MemoryMarshal.CreateSpan(ref Unsafe.As<Guid, long>(ref a), 2);
            var spanB = MemoryMarshal.CreateSpan(ref Unsafe.As<Guid, long>(ref b), 2);
            spanB[0] ^= spanA[0];
            spanB[1] ^= spanA[1];
            return b;
        }
    }

    /// <summary>
    /// Merge two GUID to single GUID by XOR. No SIMD, missing memory operation, non-alloc. xor for 8 byte.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Guid FairMerge(Guid a, Guid b)
    {
        var spanA = a.ToByteArray().AsSpan();
        var spanB = b.ToByteArray().AsSpan();

        var aLong1 = BitConverter.ToInt64(spanA[..8]);
        var aLong2 = BitConverter.ToInt64(spanA[8..]);
        var bLong1 = BitConverter.ToInt64(spanB[..8]);
        var bLong2 = BitConverter.ToInt64(spanB[8..]);

        bLong1 ^= aLong1;
        bLong2 ^= aLong2;
        BitConverter.GetBytes(bLong1).CopyTo(spanB[..8]);
        BitConverter.GetBytes(bLong2).CopyTo(spanB[8..]);
        return new Guid(spanB);
    }

    /// <summary>
    /// Merge two GUID to single GUID by XOR. No SIMD, missing memory operation, non-alloc. xor for each byte.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static Guid SlowMerge(Guid a, Guid b)
    {
        var spanA = a.ToByteArray().AsSpan();
        var spanB = b.ToByteArray().AsSpan();
        Span<byte> concat = stackalloc byte[spanA.Length];

        for (var i = 0; i < concat.Length; i++)
        {
            concat[i] = (byte)(spanA[i] ^ spanB[i]);
        }

        return new Guid(concat);
    }
}
