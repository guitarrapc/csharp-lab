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
| **SlowMerge** | **.NET 8.0** | **(37e5(...)524e) [76]** | **34.2520 ns** | **4.8735 ns** | **0.2671 ns** | **34.1244 ns** | **34.0726 ns** | **34.5590 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (37e5(...)524e) [76] | 33.4883 ns | 7.5834 ns | 0.4157 ns | 33.6792 ns | 33.0115 ns | 33.7743 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(5400(...)cc03) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (5400(...)cc03) [76] |  0.0013 ns | 0.0286 ns | 0.0016 ns |  0.0009 ns |  0.0000 ns |  0.0031 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(5f61(...)79b0) [76]** | **46.0421 ns** | **5.3359 ns** | **0.2925 ns** | **46.1642 ns** | **45.7084 ns** | **46.2538 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (5f61(...)79b0) [76] | 42.2811 ns | 0.7493 ns | 0.0411 ns | 42.2682 ns | 42.2481 ns | 42.3271 ns | 0.0086 |     144 B |
