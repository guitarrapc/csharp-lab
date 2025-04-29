```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(2e8f(...)407e) [76]** |  **0.0032 ns** |  **0.0503 ns** | **0.0028 ns** |  **0.0048 ns** |  **0.0000 ns** |  **0.0048 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (2e8f(...)407e) [76] |  0.0141 ns |  0.3504 ns | 0.0192 ns |  0.0064 ns |  0.0000 ns |  0.0360 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(c165(...)679c) [76]** | **32.9538 ns** |  **0.7455 ns** | **0.0409 ns** | **32.9714 ns** | **32.9070 ns** | **32.9828 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (c165(...)679c) [76] | 33.7869 ns |  9.7522 ns | 0.5345 ns | 33.9810 ns | 33.1824 ns | 34.1972 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(da7b(...)269c) [76]** | **44.9613 ns** | **14.1071 ns** | **0.7733 ns** | **45.3223 ns** | **44.0736 ns** | **45.4881 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (da7b(...)269c) [76] | 41.4223 ns |  8.8102 ns | 0.4829 ns | 41.2811 ns | 41.0257 ns | 41.9600 ns | 0.0086 |     144 B |
