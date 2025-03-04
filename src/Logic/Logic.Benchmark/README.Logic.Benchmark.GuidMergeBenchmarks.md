```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **.NET 8.0** | **(6083(...)dd15) [76]** |  **0.0017 ns** |  **0.0552 ns** | **0.0030 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0052 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (6083(...)dd15) [76] |  0.0000 ns |  0.0000 ns | 0.0000 ns |  0.0000 ns |  0.0000 ns |  0.0000 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(c7f0(...)1b99) [76]** | **34.4772 ns** |  **8.9452 ns** | **0.4903 ns** | **34.5295 ns** | **33.9629 ns** | **34.9393 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (c7f0(...)1b99) [76] | 34.0560 ns |  6.2750 ns | 0.3440 ns | 33.8852 ns | 33.8309 ns | 34.4519 ns | 0.0048 |      80 B |
| **FairMerge** | **.NET 8.0** | **(f6a7(...)ffdd) [76]** | **49.7649 ns** |  **3.0428 ns** | **0.1668 ns** | **49.8047 ns** | **49.5818 ns** | **49.9081 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (f6a7(...)ffdd) [76] | 41.7239 ns | 20.2045 ns | 1.1075 ns | 42.3088 ns | 40.4466 ns | 42.4163 ns | 0.0086 |     144 B |
