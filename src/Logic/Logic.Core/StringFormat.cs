using System.Globalization;
using System.Text;

namespace Logic.Core;

public class StringFormat
{
    private readonly CompositeFormat _compositeFormat;
    private readonly string _stringFormat;
    public StringFormat(string formatString)
    {
        _compositeFormat = CompositeFormat.Parse(formatString);
        _stringFormat = formatString;
    }

    public string Composite(string name, int apples)
    {
        var message = string.Format(CultureInfo.CurrentCulture, _compositeFormat, name, apples);
        return message;
    }

    public string Format(string name, int apples)
    {
        var message = string.Format(_stringFormat, name, apples);
        return message;
    }
}
