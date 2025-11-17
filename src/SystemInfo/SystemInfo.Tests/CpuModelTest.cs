using System.Runtime.InteropServices;

namespace SystemInfo.Tests;

public class CpuModelTest
{
    private static CpuModel cpuModel = CpuModel.Current;

    [Fact]
    public void Windows_x86_64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && RuntimeInformation.ProcessArchitecture == Architecture.X64)
        {
            Assert.NotEqual("Unkown", cpuModel.ModelName);
            Assert.Empty(cpuModel.UnkownReason);
        }
    }

    [Fact]
    public void Windows_arm64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
        {
            Assert.NotEqual("Unkown", cpuModel.ModelName);
            Assert.Empty(cpuModel.UnkownReason);
        }
    }

    [Fact]
    public void Linux_x86_64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && RuntimeInformation.ProcessArchitecture == Architecture.X64)
        {
            Assert.NotEqual("Unkown", cpuModel.ModelName);
            Assert.Empty(cpuModel.UnkownReason);
        }
    }

    [Fact]
    public void Linux_arm64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
        {
            Assert.NotEqual("Unkown", cpuModel.ModelName);
            Assert.Empty(cpuModel.UnkownReason);
        }
    }

    [Fact]
    public void OSX_x86_64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) && RuntimeInformation.ProcessArchitecture == Architecture.X64)
        {
            Assert.NotEqual("Unkown", cpuModel.ModelName);
            Assert.Empty(cpuModel.UnkownReason);
        }
    }

    [Fact]
    public void OSX_arm64_Test()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX) && RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
        {
            Assert.NotEqual("Unkown", cpuModel.ModelName);
            Assert.Empty(cpuModel.UnkownReason);
        }
    }
}
