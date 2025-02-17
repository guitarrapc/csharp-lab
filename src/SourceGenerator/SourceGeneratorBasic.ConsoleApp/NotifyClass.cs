namespace SourceGeneratorBasic.ConsoleApp;

public partial class NotifyClass
{
    [MyAutoNotify.MyAutoNotifyAttribute]
    private bool _boolProp;

    [MyAutoNotify.MyAutoNotifyAttribute]
    private int _intProp;

    [MyAutoNotify.MyAutoNotifyAttribute(PropertyName = "Nanika")]
    private long _longProp;
}
