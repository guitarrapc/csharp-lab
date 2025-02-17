using MemoryPack;

namespace Serialization.Core;

[MemoryPackable]
public partial class MyClass
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public void FillDummy()
    {
        X = 1606474087;
        Y = 904419156;
        Z = 1997954408;
        FirstName = "60c627ed-08fa-4cd9-91eb-faa65ebe0b3d";
        LastName = "5216caf5-c504-4622-a497-efc19906c16b\r\n";
    }

    // Call before serialize
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
