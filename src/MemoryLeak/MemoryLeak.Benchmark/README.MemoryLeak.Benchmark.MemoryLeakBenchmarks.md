```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **731.9 ns** |   **305.37 ns** |  **16.74 ns** |   **712.8 ns** |   **743.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   729.9 ns |   283.87 ns |  15.56 ns |   715.9 ns |   746.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   706.1 ns |   259.70 ns |  14.24 ns |   692.9 ns |   721.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   724.3 ns |    97.31 ns |   5.33 ns |   718.3 ns |   728.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   703.7 ns |   251.63 ns |  13.79 ns |   689.6 ns |   717.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,632.7 ns** | **2,922.62 ns** | **160.20 ns** | **7,466.6 ns** | **7,786.3 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,205.2 ns | 1,094.57 ns |  60.00 ns | 7,146.3 ns | 7,266.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,017.1 ns | 4,791.10 ns | 262.62 ns | 6,714.8 ns | 7,188.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,350.8 ns | 2,823.30 ns | 154.75 ns | 7,258.1 ns | 7,529.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,115.3 ns | 5,391.36 ns | 295.52 ns | 6,793.8 ns | 7,375.1 ns | 0.1221 | 0.1144 |  10.23 KB |
