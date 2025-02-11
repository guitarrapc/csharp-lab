```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **.NET 8.0** | **(18fb(...)f6a0) [76]** | **43.9736 ns** | **2.4044 ns** | **0.1318 ns** | **44.0166 ns** | **43.8256 ns** | **44.0784 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (18fb(...)f6a0) [76] | 39.3547 ns | 3.7329 ns | 0.2046 ns | 39.3448 ns | 39.1552 ns | 39.5641 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(b41c(...)37d4) [76]** |  **0.0006 ns** | **0.0184 ns** | **0.0010 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0017 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (b41c(...)37d4) [76] |  0.0000 ns | 0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(bafe(...)d088) [76]** | **32.8484 ns** | **5.7956 ns** | **0.3177 ns** | **32.8154 ns** | **32.5485 ns** | **33.1813 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (bafe(...)d088) [76] | 32.0984 ns | 5.3060 ns | 0.2908 ns | 31.9713 ns | 31.8927 ns | 32.4311 ns | 0.0048 |      80 B |
