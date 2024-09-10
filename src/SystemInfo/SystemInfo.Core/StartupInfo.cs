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
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            return GetCpuModelWindows();
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            return GetCpuModelLinux();
        }
        else
        {
            return "Unknown operating system.";
        }
    }

    static string GetCpuModelWindows()
    {
        const string registryKey = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";
        const string valueName = "ProcessorNameString";

        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            return "";

        using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(registryKey))
        {
            if (key != null)
            {
                var value = key.GetValue(valueName);
                if (value != null)
                {
                    return value.ToString()!;
                }
            }
            return "Windows Registry Key not found.";
        }
    }

    static string GetCpuModelLinux()
    {
        var cpuInfo = File.ReadAllText("/proc/cpuinfo");
        foreach (string line in cpuInfo.Split('\n'))
        {
            if (line.StartsWith("model name"))
            {
                var cpuModel = line.Split(':')[1].Trim();
                return cpuModel;
            }
        }
        return "Linux CPU model name not found";
    }
}
