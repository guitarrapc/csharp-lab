using MyAutoNotify;

namespace SourceGeneratorBasic.ConsoleApp;

public partial class NotifyClass
{
    [MyAutoNotifyAttirbute]
    private bool _boolProp;

    [MyAutoNotifyAttirbute]
    private int _intProp;

    [MyAutoNotifyAttirbute(PropertyName = "Nanika")]
    private long _longProp;
}
