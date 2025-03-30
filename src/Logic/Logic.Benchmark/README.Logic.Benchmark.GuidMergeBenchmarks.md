```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(befb(...)e3d3) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (befb(...)e3d3) [76] |  0.0005 ns | 0.0145 ns | 0.0008 ns |  0.0000 ns |  0.0000 ns |  0.0014 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(c048(...)a868) [76]** | **43.9314 ns** | **6.5682 ns** | **0.3600 ns** | **43.7907 ns** | **43.6630 ns** | **44.3405 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (c048(...)a868) [76] | 38.7827 ns | 6.0002 ns | 0.3289 ns | 38.8378 ns | 38.4298 ns | 39.0806 ns | 0.0086 |     144 B |
| **SlowMerge** | **.NET 8.0** | **(cef6(...)c99f) [76]** | **32.5210 ns** | **4.5188 ns** | **0.2477 ns** | **32.4320 ns** | **32.3300 ns** | **32.8009 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (cef6(...)c99f) [76] | 32.0008 ns | 4.7985 ns | 0.2630 ns | 32.1096 ns | 31.7009 ns | 32.1920 ns | 0.0048 |      80 B |
