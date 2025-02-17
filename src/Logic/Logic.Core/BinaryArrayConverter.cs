namespace Logic.Core;

public class BinaryArrayConverter
{
    private static readonly int bitLength = 8;

    /// <summary>
    /// Use Convert.ToByte without mod for decimal to binary conversion.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static byte[] ToBinaryArrayInt(int value)
    {
        Span<byte> byteArray = stackalloc byte[bitLength];

        // faster then mod %
        var number = value;
        for (var i = bitLength - 1; i >= 0; i--)
        {
            // n % m == n & (m - 1) 
            byteArray[i] = Convert.ToByte(number & (2 - 1)); // fast
            number = Convert.ToByte(number / 2);
        }

        return byteArray.ToArray();
    }

    /// <summary>
    /// Use ConvertToString for decimal to binary conversion.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static byte[] ToBinaryArrayConvertToString(int value)
    {
        Span<byte> byteArray = stackalloc byte[bitLength];

        // slow
        var binaryNumber = Convert.ToString(value, 2).PadLeft(bitLength, '0');
        for (var i = 0; i < binaryNumber.Length; i++)
        {
            byteArray[i] = (byte)char.GetNumericValue(binaryNumber[i]);
        }

        return byteArray.ToArray();
    }

    /// <summary>
    /// Use Convert.ToByte for decimal to binary conversion, number compasion.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static byte[] ToBinaryArrayIntModNumber(int number)
    {
        Span<byte> byteArray = stackalloc byte[bitLength];

        // faster then string but...
        for (var i = bitLength - 1; number > 0; i--)
        {
            byteArray[i] = Convert.ToByte(number % 2); // slow
            number = Convert.ToByte(number / 2);
        }

        return byteArray.ToArray();
    }

    /// <summary>
    /// Use Convert.ToByte for decimal to binary conversion.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static byte[] ToBinaryArrayIntMod(int value)
    {
        Span<byte> byteArray = stackalloc byte[bitLength];

        // faster then string but...
        var number = value;
        for (var i = bitLength - 1; i >= 0; i--)
        {
            byteArray[i] = Convert.ToByte(number % 2); // slow
            number = Convert.ToByte(number / 2);
        }

        return byteArray.ToArray();
    }
}
