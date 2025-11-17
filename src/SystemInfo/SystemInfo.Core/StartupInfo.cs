using System.Runtime.InteropServices;

namespace SystemInfo.Core;

public static class StartupInfo
{
    public static void Print()
    {
        Console.WriteLine($$"""
        Startup info:
          * OS       : {{RuntimeInformation.OSDescription}}
          * CPU Arch : {{RuntimeInformation.ProcessArchitecture}}
          * CPU Model: {{GetCpuModel()}}
          * CPU Cores: {{Environment.ProcessorCount}}
        """);
    }

    static string GetCpuModel()
    {
        return !string.IsNullOrWhiteSpace(CpuModel.Current.ModelName) ? CpuModel.Current.ModelName : CpuModel.Current.UnkownReason;
    }
}
