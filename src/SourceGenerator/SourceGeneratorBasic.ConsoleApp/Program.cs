namespace SourceGeneratorBasic.ConsoleApp;

partial class Program
{
    static void Main(string[] args)
    {
        HelloFrom("Generated Code");

        var userClass = new UserClass();
        userClass.UserMethod();

        var fileTransform = new FileGeneratedNamespace.GeneratedClass();
        fileTransform.GeneratedMethod();

        var augument = new UserClassAugment();
        augument.UserMethod();

        var augumentContext = new UserClassAugmentContext();
        augumentContext.UserMethod();

        var notify = new NotifyClass();
        notify.PropertyChanged += NanikaChanged;
        notify.AddPropertyChanged(o => o.BoolProp, BoolChanged);
        notify.Nanika = 10;
        notify.Nanika = 100_000;
        notify.BoolProp = false;
    }

    public static void NanikaChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName != "Nanika") return;

        var p = (NotifyClass)sender!;
        Console.WriteLine($"Nanika changed; {p.Nanika}");
    }
    public static void BoolChanged(NotifyClass n)
    {
        Console.WriteLine($"BoolProp changed; {n.BoolProp}");
    }

    static partial void HelloFrom(string name);
}
