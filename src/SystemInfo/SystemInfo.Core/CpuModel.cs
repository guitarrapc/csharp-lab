﻿using System.Runtime.InteropServices;

namespace SystemInfo.Core;

public class CpuModel
{
    const string UnkownFrase = "Unkown";

    public static CpuModel Current { get; } = new CpuModel();
    public string ModelName { get; private set; } = "";
    public string UnkownReason { get; private set; } = "";

    private CpuModel()
    {
        if (System.Runtime.Intrinsics.X86.X86Base.IsSupported)
        {
            // x86_64 OS (Linux, Windows, macOS) ...
            (ModelName, UnkownReason) = GetX86CpuModelName();
        }
        else
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
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
        IntPtr size = IntPtr.Zero;
        sysctlbyname("machdep.cpu.brand_string", IntPtr.Zero, ref size, IntPtr.Zero, IntPtr.Zero);

        IntPtr buffer = Marshal.AllocHGlobal(size.ToInt32());
        sysctlbyname("machdep.cpu.brand_string", buffer, ref size, IntPtr.Zero, IntPtr.Zero);

        var result = Marshal.PtrToStringAnsi(buffer);
        Marshal.FreeHGlobal(buffer);
        if (string.IsNullOrEmpty(result))
        {
            return (UnkownFrase, "machdep.cpu.brand_string not found.");
        }
        else
        {
            return (result, "");
        }
    }

    [DllImport("libc")]
    private static extern int sysctlbyname(string name, IntPtr oldp, ref IntPtr oldlenp, IntPtr newp, IntPtr newlen);
}
