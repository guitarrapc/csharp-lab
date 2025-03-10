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
| **SlowMerge** | **.NET 8.0** | **(2df9(...)1706) [76]** | **33.1319 ns** |  **2.9753 ns** | **0.1631 ns** | **33.1738 ns** | **32.9520 ns** | **33.2699 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (2df9(...)1706) [76] | 31.6979 ns |  4.4730 ns | 0.2452 ns | 31.6341 ns | 31.4910 ns | 31.9687 ns | 0.0048 |      80 B |
| **FastMerge** | **.NET 8.0** | **(5772(...)ad86) [76]** |  **0.0001 ns** |  **0.0040 ns** | **0.0002 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0004 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (5772(...)ad86) [76] |  0.0018 ns |  0.0567 ns | 0.0031 ns |  0.0000 ns |  0.0000 ns |  0.0054 ns |      - |         - |
| **FairMerge** | **.NET 8.0** | **(896f(...)f2ed) [76]** | **48.6236 ns** | **21.2237 ns** | **1.1633 ns** | **49.1841 ns** | **47.2862 ns** | **49.4007 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (896f(...)f2ed) [76] | 40.6525 ns | 13.1675 ns | 0.7218 ns | 41.0358 ns | 39.8200 ns | 41.1018 ns | 0.0086 |     144 B |
