using System.Runtime.InteropServices;

namespace SystemInfo.Tests;

public class CpuModelTest
{
    private static CpuModel cpuModel = CpuModel.Current;

    [Test]
    public async Task Windows_x86_64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && RuntimeInformation.ProcessArchitecture == Architecture.X64)
        {
            await Assert.That(cpuModel.ModelName).IsNotEqualTo("Unkown");
            await Assert.That(cpuModel.UnknownReason).IsEmpty();
        }
    }

    [Test]
    public async Task Windows_arm64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
        {
            await Assert.That(cpuModel.ModelName).IsNotEqualTo("Unkown");
            await Assert.That(cpuModel.UnknownReason).IsEmpty();
        }
    }

    [Test]
    public async Task Linux_x86_64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && RuntimeInformation.ProcessArchitecture == Architecture.X64)
        {
            await Assert.That(cpuModel.ModelName).IsNotEqualTo("Unkown");
            await Assert.That(cpuModel.UnknownReason).IsEmpty();
        }
    }

    [Test]
    public async Task Linux_arm64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
        {
            await Assert.That(cpuModel.ModelName).IsNotEqualTo("Unkown");
            await Assert.That(cpuModel.UnknownReason).IsEmpty();
        }
    }

    [Test]
    public async Task OSX_x86_64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) && RuntimeInformation.ProcessArchitecture == Architecture.X64)
        {
            await Assert.That(cpuModel.ModelName).IsNotEqualTo("Unkown");
            await Assert.That(cpuModel.UnknownReason).IsEmpty();
        }
    }

    [Test]
    public async Task OSX_arm64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) && RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
        {
            await Assert.That(cpuModel.ModelName).IsNotEqualTo("Unkown");
            await Assert.That(cpuModel.UnknownReason).IsEmpty();
        }
    }
}
