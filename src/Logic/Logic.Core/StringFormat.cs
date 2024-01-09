using System.Globalization;
using System.Text;

namespace Logic.Core;

public class StringFormat(string formatString)
{
    public string Composite(string name, int apples)
    {
        var compositeFormat = CompositeFormat.Parse(formatString);
        var message = string.Format(CultureInfo.CurrentCulture, compositeFormat, name, apples);
        return message;
    }

    public string Format(string name, int apples)
    {
        var format = formatString;
        var message = string.Format(format, name, apples);
        return message;
    }
}
