```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(5523(...)0352) [76]** |  **0.0016 ns** |  **0.0479 ns** | **0.0026 ns** |  **0.0001 ns** |  **0.0000 ns** |  **0.0046 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (5523(...)0352) [76] |  0.0000 ns |  0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(c7d2(...)718f) [76]** | **32.7178 ns** |  **4.6659 ns** | **0.2558 ns** | **32.7762 ns** | **32.4379 ns** | **32.9394 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (c7d2(...)718f) [76] | 32.2195 ns |  6.1233 ns | 0.3356 ns | 32.1327 ns | 31.9358 ns | 32.5900 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(dc70(...)9449) [76]** | **45.1305 ns** | **15.7528 ns** | **0.8635 ns** | **44.6682 ns** | **44.5966 ns** | **46.1266 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (dc70(...)9449) [76] | 41.5005 ns |  6.6486 ns | 0.3644 ns | 41.6471 ns | 41.0855 ns | 41.7687 ns | 0.0086 |     144 B |
