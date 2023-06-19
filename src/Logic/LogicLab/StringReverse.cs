using System.Globalization;
using System.Text;

namespace LogicLab;

// inspire from https://code-maze.com/csharp-reverse-string/
public class StringReverse
{
    /// <summary>
    /// Use Array.Reverse() Method to Reverse a String.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string ArrayReverseString(string text)
    {
        var charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    /// <summary>
    /// Enumerable Reverse() Extension Method for String Reversion.
    /// This include ToArray = Allocation.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string EnumerableReverse(string text)
    {
        return string.Concat(Enumerable.Reverse(text));
    }

    /// <summary>
    /// Reverse a String With Recursion.
    /// This concat string every time calling method recursively.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string RecursiveStringReverse(string text)
    {
        if (text.Length <= 1)
            return text;

        return text[^1] +
               RecursiveStringReverse(text[1..^1]) + text[0];
    }

    /// <summary>
    /// Reverse a String Using a Loop and XOR Operator.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string ReverseXor(string text)
    {
        var charArray = text.ToCharArray();
        var len = text.Length - 1;

        for (int i = 0; i < len; i++, len--)
        {
            charArray[i] ^= charArray[len];
            charArray[len] ^= charArray[i];
            charArray[i] ^= charArray[len];
        }

        return new string(charArray);
    }

    /// <summary>
    /// Use Stack to Reverse a String.
    /// Using Stack for reverse and StringBuilder to create string.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string StackReverse(string text)
    {
        var resultStack = new Stack<char>();
        foreach (char c in text)
        {
            resultStack.Push(c);
        }

        var sb = new StringBuilder();
        while (resultStack.Count > 0)
        {
            sb.Append(resultStack.Pop());
        }

        return sb.ToString();
    }

    /// <summary>
    /// Use Create() Method to Create a String in Reverse Order.
    /// Use string.Create and directly memory access of char via Span().
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string StringSpan(string text)
    {
        return string.Create(text.Length, text, (chars, state) =>
        {
            state.AsSpan().CopyTo(chars);
            chars.Reverse();
        });
    }

    /// <summary>
    /// LINQ Reverse() Extension Method.
    /// Use Reverse() and ToArray, then directly input to string .ctor.
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string StringExtensionReverse(string text)
    {
        return new string(text.Reverse().ToArray());
    }

    /// <summary>
    /// Special Characters Reversion With TextElementEnumerator.
    /// Create 
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string TextElementEnumerator(string text)
    {
        return string.Create(text.Length, text, (chars, val) =>
        {
            var valSpan = val.AsSpan();
            var en = StringInfo.GetTextElementEnumerator(val);
            en.MoveNext();
            var start = en.ElementIndex;
            var pos = chars.Length;
            while (en.MoveNext())
            {
                var next = en.ElementIndex;
                var len = next - start;
                valSpan[start..next].CopyTo(chars[(pos - len)..pos]);
                pos -= len;
                start = next;
            }

            if (start != 0)
                valSpan[start..].CopyTo(chars[0..pos]);
        });
    }

    public static string GenerateText(int length = 64)
    {
        var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        var random = new Random();
        var builder = new StringBuilder(length);

        for (int i = 0; i < length; ++i)
        {
            var index = random.Next(alphabet.Length);

            builder.Append(alphabet[index]);
        }

        return builder.ToString();
    }
}
