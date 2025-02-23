```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **.NET 8.0** | **(0c82(...)c860) [76]** | **33.2721 ns** | **6.4908 ns** | **0.3558 ns** | **33.3977 ns** | **32.8705 ns** | **33.5480 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (0c82(...)c860) [76] | 32.3956 ns | 2.8446 ns | 0.1559 ns | 32.3409 ns | 32.2743 ns | 32.5715 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(3384(...)b42d) [76]** | **45.1159 ns** | **4.0503 ns** | **0.2220 ns** | **44.9922 ns** | **44.9833 ns** | **45.3722 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (3384(...)b42d) [76] | 40.0133 ns | 7.3033 ns | 0.4003 ns | 39.8855 ns | 39.6925 ns | 40.4620 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(96e9(...)38f2) [76]** |  **0.0015 ns** | **0.0453 ns** | **0.0025 ns** |  **0.0001 ns** |  **0.0000 ns** |  **0.0043 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (96e9(...)38f2) [76] |  0.0003 ns | 0.0095 ns | 0.0005 ns |  0.0000 ns |  0.0000 ns |  0.0009 ns |      - |         - |
