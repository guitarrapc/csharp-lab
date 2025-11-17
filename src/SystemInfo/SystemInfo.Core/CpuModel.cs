using System.Runtime.InteropServices;

namespace SystemInfo.Core;

public class CpuModel
{
    const string UnkownFrase = "Unkown";

    public static CpuModel Current { get; } = new CpuModel();
    public string ModelName { get; } = "";
    public string UnkownReason { get; } = "";

    private CpuModel()
    {
        if (System.Runtime.Intrinsics.X86.X86Base.IsSupported)
        {
            // x86_64 OS (Linux, Windows, macOS) ...
            (ModelName, UnkownReason) = GetX86CpuModelName();
        }
        else
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                // Windows Arm64 will be here...
                (ModelName, UnkownReason) = GetWindowsModelName();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                // Linux Arm64 will be here...
                (ModelName, UnkownReason) = GetLinuxModelName();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // macOS will be here...
                (ModelName, UnkownReason) = GetOSXModelname();
            }
            else
            {
                // Windows Arm64 is not supported... Don't like WMI or kernel32.dll SystemInfo
                (ModelName, UnkownReason) = (UnkownFrase, $"Platform not supported for... OS: {RuntimeInformation.OSDescription}, Architecture: {RuntimeInformation.OSArchitecture}");
            }
        }
    }

    private static (string modelName, string unkownReason) GetX86CpuModelName()
    {
        Span<int> regs = stackalloc int[12]; // call 3 times (0x80000002, 0x80000003, 0x80000004) for 4 registers

        // Calling __cpuid with 0x80000000 as the InfoType argument and gets the number of valid extended IDs.
        var extendedId = System.Runtime.Intrinsics.X86.X86Base.CpuId(unchecked((int)0x80000000), 0).Eax;

        // Get the information associated with each extended ID.
        if ((uint)extendedId >= 0x80000004)
        {
            int p = 0;
            for (uint i = 0x80000002; i <= 0x80000004; ++i)
            {
                var (Eax, Ebx, Ecx, Edx) = System.Runtime.Intrinsics.X86.X86Base.CpuId((int)i, 0);
                regs[p + 0] = Eax;
                regs[p + 1] = Ebx;
                regs[p + 2] = Ecx;
                regs[p + 3] = Edx;
                p += 4; // advance
            }
            return (ConvertToString(regs), "");
        }

        return (UnkownFrase, $"CPU Architecture not supported... extendedId: {extendedId}");

        static string ConvertToString(ReadOnlySpan<int> regs)
        {
            Span<byte> bytes = stackalloc byte[regs.Length * 4]; // int 4byte * 12
            for (int i = 0; i < regs.Length; i++)
            {
                BitConverter.TryWriteBytes(bytes.Slice(i * 4, 4), regs[i]);
            }
            return System.Text.Encoding.ASCII.GetString(bytes).Trim();
        }
    }

    private static (string modelName, string unkownReason) GetWindowsModelName()
    {
        const string registryKey = @"HARDWARE\DESCRIPTION\System\CentralProcessor\0";
        const string valueName = "ProcessorNameString";

        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            throw new PlatformNotSupportedException("Not Windows OS.");

        using var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(registryKey);
        if (key != null)
        {
            var value = key.GetValue(valueName);
            if (value is string model)
            {
                return (model, "");
            }
        }
        return (UnkownFrase, "Windows Registry Key not found.");
    }

    private static (string modelName, string unkownReason) GetLinuxModelName()
    {
        var cpuInfo = File.ReadAllText("/proc/cpuinfo");
        var lines = cpuInfo.Split('\n');
        foreach (var line in lines)
        {
            if (!line.StartsWith("model name"))
            {
                continue;
            }
            var parts = line.Split(':');
            if (parts.Length > 1)
            {
                var modelName = parts[1].Trim();
                return (modelName, "");
            }
        }
        return (UnkownFrase, "'model name' section not found.");
    }

    private static (string modelName, string unkownReason) GetOSXModelname()
    {
        try
        {
            nint size = 0;

            // First call to get the size
            int result = sysctlbyname("machdep.cpu.brand_string", IntPtr.Zero, ref size, IntPtr.Zero, 0);
            if (result != 0)
            {
                return (UnkownFrase, $"sysctlbyname failed to get size. Return code: {result}, errno: {Marshal.GetLastPInvokeError()}");
            }

            if (size == 0)
            {
                return (UnkownFrase, "sysctlbyname returned size 0");
            }

            IntPtr buffer = Marshal.AllocHGlobal((int)size);
            try
            {
                // Second call to get the actual value
                result = sysctlbyname("machdep.cpu.brand_string", buffer, ref size, IntPtr.Zero, 0);
                if (result != 0)
                {
                    return (UnkownFrase, $"sysctlbyname failed to get value. Return code: {result}, errno: {Marshal.GetLastPInvokeError()}");
                }

                var cpuBrand = Marshal.PtrToStringAnsi(buffer);
                if (string.IsNullOrEmpty(cpuBrand))
                {
                    return (UnkownFrase, "machdep.cpu.brand_string returned empty string.");
                }

                return (cpuBrand.Trim(), "");
            }
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }
        catch (Exception ex)
        {
            return (UnkownFrase, $"Exception occurred: {ex.Message}");
        }
    }

    [DllImport("libSystem.dylib")]
    private static extern int sysctlbyname(string name, IntPtr oldp, ref IntPtr oldlenp, IntPtr newp, IntPtr newlen);
}
