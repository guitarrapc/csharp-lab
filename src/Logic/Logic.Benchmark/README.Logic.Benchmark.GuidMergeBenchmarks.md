```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **.NET 8.0** | **(11a7(...)6f36) [76]** | **32.0371 ns** | **2.7568 ns** | **0.1511 ns** | **32.0521 ns** | **31.8790 ns** | **32.1801 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (11a7(...)6f36) [76] | 31.6908 ns | 3.4117 ns | 0.1870 ns | 31.7251 ns | 31.4890 ns | 31.8583 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(3cce(...)80e5) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (3cce(...)80e5) [76] |  0.0004 ns | 0.0113 ns | 0.0006 ns |  0.0000 ns |  0.0000 ns |  0.0011 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(6b38(...)555c) [76]** | **43.2521 ns** | **1.8559 ns** | **0.1017 ns** | **43.2977 ns** | **43.1356 ns** | **43.3232 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (6b38(...)555c) [76] | 40.8175 ns | 7.3667 ns | 0.4038 ns | 40.7007 ns | 40.4850 ns | 41.2668 ns | 0.0086 |     144 B |
