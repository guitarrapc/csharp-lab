namespace SourceGeneratorBasic.ConsoleApp;

public partial class NotifyClass
{
    [MyAutoNotifyAttribute]
    private bool _boolProp;

    [MyAutoNotifyAttribute]
    private int _intProp;

    [MyAutoNotifyAttribute(PropertyName = "Nanika")]
    private long _longProp;
}
