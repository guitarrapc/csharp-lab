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
| **FairMerge** | **.NET 8.0** | **(031d(...)47f5) [76]** | **42.8829 ns** | **2.5004 ns** | **0.1371 ns** | **42.9154 ns** | **42.7325 ns** | **43.0007 ns** | **0.0086** |     **144 B** |
| FairMerge | .NET 9.0 | (031d(...)47f5) [76] | 38.5349 ns | 3.1367 ns | 0.1719 ns | 38.6257 ns | 38.3366 ns | 38.6423 ns | 0.0086 |     144 B |
| **FastMerge** | **.NET 8.0** | **(5b93(...)eb9a) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| FastMerge | .NET 9.0 | (5b93(...)eb9a) [76] |  0.0352 ns | 0.7110 ns | 0.0390 ns |  0.0228 ns |  0.0040 ns |  0.0789 ns |      - |         - |
| **SlowMerge** | **.NET 8.0** | **(8fca(...)cc77) [76]** | **33.7196 ns** | **3.9077 ns** | **0.2142 ns** | **33.6301 ns** | **33.5647 ns** | **33.9640 ns** | **0.0048** |      **80 B** |
| SlowMerge | .NET 9.0 | (8fca(...)cc77) [76] | 31.5927 ns | 5.3499 ns | 0.2932 ns | 31.4889 ns | 31.3655 ns | 31.9237 ns | 0.0048 |      80 B |
