```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **.NET 8.0** | **(9dc5(...)77e2) [76]** | **32.7500 ns** | **3.9139 ns** | **0.2145 ns** | **32.7110 ns** | **32.5577 ns** | **32.9814 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (9dc5(...)77e2) [76] | 32.1786 ns | 9.8061 ns | 0.5375 ns | 32.2155 ns | 31.6236 ns | 32.6967 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(bb37(...)d2f7) [76]** |  **0.0009 ns** | **0.0093 ns** | **0.0005 ns** |  **0.0006 ns** |  **0.0005 ns** |  **0.0014 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (bb37(...)d2f7) [76] |  0.0095 ns | 0.2406 ns | 0.0132 ns |  0.0040 ns |  0.0000 ns |  0.0246 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(e4e9(...)5ba8) [76]** | **43.4640 ns** | **6.1828 ns** | **0.3389 ns** | **43.4157 ns** | **43.1519 ns** | **43.8245 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (e4e9(...)5ba8) [76] | 38.5987 ns | 4.7740 ns | 0.2617 ns | 38.7182 ns | 38.2986 ns | 38.7793 ns | 0.0086 |     144 B |
