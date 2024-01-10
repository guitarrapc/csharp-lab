using System.Globalization;
using System.Text;

namespace Logic.Core;

public class StringFormat
{
    private readonly CompositeFormat _compositeFormat;
    private readonly string _stringFormat;

    public StringFormat()
    {
        const string format = "{0:t}: Hello, {1}! I'll give you {2} apples.";
        _compositeFormat = CompositeFormat.Parse(format);
        _stringFormat = format;
    }

    /// <summary>
    /// .NET 8 Introduce CompositeFormat, which can reuse CompositeFormat instance multiple times.
    /// String Interpolation moved parsing to compile-time and removed boxing allocation.
    /// CompositeFormat braing effiency of compile-time parsing to runtime.
    /// </summary>
    /// <param name="datetime"></param>
    /// <param name="name"></param>
    /// <param name="apples"></param>
    /// <returns></returns>
    public string Composite(DateTime datetime, string name, int apples)
    {
        var message = string.Format(CultureInfo.CurrentCulture, _compositeFormat, datetime, name, apples);
        return message;
    }

    public string Format(DateTime datetime, string name, int apples)
    {
        var message = string.Format(_stringFormat, datetime, name, apples);
        return message;
    }
}
