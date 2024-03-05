namespace Serialization.Core;

public partial class MyClass
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public void Initialize()
    {
        var rnd = new System.Random();
        X = rnd.Next();
        Y = rnd.Next();
        Z = rnd.Next();
        FirstName = Guid.NewGuid().ToString();
        LastName = Guid.NewGuid().ToString();
    }
}
