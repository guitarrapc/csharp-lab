namespace Serialization.Core;

public class NestClass
{
    public class Inner
    {
        public int Int { get; set; }
        public double Double { get; set; }
        public string String { get; set; }

        public Inner()
        {
            var rnd = new System.Random();
            Int = rnd.Next();
            Double = rnd.NextDouble();
            String = Guid.NewGuid().ToString();
        }
    }

    public Inner A { get; set; } = default!;
    public Inner B { get; set; } = default!;
    public Inner C { get; set; } = default!;
    public Inner D { get; set; } = default!;
    public Inner E { get; set; } = default!;
    public Inner F { get; set; } = default!;
    public Inner G { get; set; } = default!;
    public Inner H { get; set; } = default!;
    public Inner I { get; set; } = default!;

    // シリアライズ前に呼ぶ
    public void Initialize()
    {
        A = new Inner();
        B = new Inner();
        C = new Inner();
        D = new Inner();
        E = new Inner();
        F = new Inner();
        G = new Inner();
        H = new Inner();
        I = new Inner();
    }
}
