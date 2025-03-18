```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method    | Runtime  | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **.NET 8.0** | **(6b93(...)e0a7) [76]** | **34.2996 ns** |  **1.8390 ns** | **0.1008 ns** | **34.2852 ns** | **34.2068 ns** | **34.4069 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (6b93(...)e0a7) [76] | 38.0015 ns | 17.3722 ns | 0.9522 ns | 37.6469 ns | 37.2775 ns | 39.0802 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(97eb(...)6d57) [76]** |  **0.0000 ns** |  **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (97eb(...)6d57) [76] |  0.0224 ns |  0.5459 ns | 0.0299 ns |  0.0108 ns |  0.0000 ns |  0.0564 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(9a76(...)3978) [76]** | **42.9262 ns** |  **1.1656 ns** | **0.0639 ns** | **42.9563 ns** | **42.8528 ns** | **42.9695 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (9a76(...)3978) [76] | 38.8294 ns | 17.4339 ns | 0.9556 ns | 38.4281 ns | 38.1399 ns | 39.9203 ns | 0.0086 |     144 B |
