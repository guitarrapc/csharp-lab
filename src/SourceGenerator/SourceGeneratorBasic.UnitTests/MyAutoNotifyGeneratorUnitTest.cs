using Microsoft.CodeAnalysis.Text;
using System.Text;
using VerifyCS = SourceGeneratorBasic.UnitTests.CSharpSourceGeneratorVerifier<SourceGeneratorBasic.MyAutoNotifyGenerator>;

namespace SourceGeneratorBasic.UnitTests;

public class MyAutoNotifyGeneratorUnitTest
{
    [Fact]
    public void SourceCompileTest()
    {
        var code = @"
using MyAutoNotify;

namespace Foo;

public partial class NotifyClass
{
    [MyAutoNotifyAttribute]
    private bool _boolProp;

    [MyAutoNotifyAttribute]
    private int _intProp;

    [MyAutoNotifyAttribute(PropertyName = ""Nanika"")]
    private long _longProp;
}
";

        var compilation = TestHelper.CreateCompilation(code);

        // Run Generator
        var driver = TestHelper.CreateDriver(new MyAutoNotifyGenerator());
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);

        // Generator must run without error
        Assert.Empty(diagnostics);

        // No Compilation error after generator
        Assert.Empty(outputCompilation.GetCompilationErrors());
    }

    [Fact]
    public void WorkspaceCompileTest()
    {
        using var workspace = new TemporaryWorkspace(TemporaryWorkspaceOptions.Default);
        workspace.AddFileToProject("NotifyClass.cs", @"
using MyAutoNotify;

namespace Foo;

public partial class NotifyClass
{
    [MyAutoNotifyAttribute]
    private bool _boolProp;

    [MyAutoNotifyAttribute]
    private int _intProp;

    [MyAutoNotifyAttribute(PropertyName = ""Nanika"")]
    private long _longProp;
}
");

        var compilation = workspace.CreateCompilation();

        // There are reference error before generator run
        Assert.NotEmpty(compilation.GetCompilationErrors());

        // Run Generator
        var driver = TestHelper.CreateDriver(new MyAutoNotifyGenerator());
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);

        // Generator must run without error
        Assert.Empty(diagnostics);

        // No Compilation error after generator
        Assert.Empty(outputCompilation.GetCompilationErrors());
    }

    [Fact]
    public async Task VerifyTest()
    {
        var code = @"
using MyAutoNotify;

namespace Foo;

public partial class NotifyClass
{
    [MyAutoNotifyAttribute]
    private bool _boolProp;

    [MyAutoNotifyAttribute]
    private int _intProp;

    [MyAutoNotifyAttribute(PropertyName = ""Nanika"")]
    private long _longProp;
}
";
        var generateAttirbute = @"// auto-generated
using System;

namespace MyAutoNotify
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    sealed class MyAutoNotifyAttribute : Attribute
    {
        public MyAutoNotifyAttribute() { }
        public string PropertyName { get; set; }
    }
}
";
        var generated = @"// auto-generated
using System;

namespace Foo
{
    public partial class NotifyClass: System.ComponentModel.INotifyPropertyChanged
    {
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void AddPropertyChanged<TProp>(System.Linq.Expressions.Expression<Func<NotifyClass, TProp>> propertyName, System.Action<NotifyClass> handler)
        {
            var name = ((System.Linq.Expressions.MemberExpression)propertyName.Body).Member.Name;
            PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == name)
                {
                    handler(this);
                }
            };
        }

        public bool BoolProp
        {
            get => this._boolProp;
            set
            {
                this._boolProp = value;
                this.PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(BoolProp)));
            }
        }

        public int IntProp
        {
            get => this._intProp;
            set
            {
                this._intProp = value;
                this.PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(IntProp)));
            }
        }

        public long Nanika
        {
            get => this._longProp;
            set
            {
                this._longProp = value;
                this.PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Nanika)));
            }
        }
    }
}
";
        await new VerifyCS.Test
        {
            TestState =
            {
                Sources = { TestHelper.ToLF(code) },
                GeneratedSources =
                {
                    (typeof(SourceGeneratorBasic.MyAutoNotifyGenerator), "MyAutoNotifyAttribute.g.cs", SourceText.From(TestHelper.ToLF(generateAttirbute), Encoding.UTF8, SourceHashAlgorithm.Sha1)),
                    (typeof(SourceGeneratorBasic.MyAutoNotifyGenerator), "NotifyClass_MyAutoNotify.g.cs", SourceText.From(TestHelper.ToLF(generated), Encoding.UTF8, SourceHashAlgorithm.Sha1)),
                },
            },
        }.RunAsync();
    }
}
