```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(32b8(...)e0a8) [76]** | **33.3587 ns** | **2.1484 ns** | **0.1178 ns** | **33.3349 ns** | **33.2547 ns** | **33.4866 ns** | **0.0048** |      **80 B** |
| **FastMerge** | **(4173(...)38c2) [76]** |  **0.0030 ns** | **0.0961 ns** | **0.0053 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0091 ns** |      **-** |         **-** |
| **FairMerge** | **(ab90(...)b09e) [76]** | **39.0948 ns** | **6.2194 ns** | **0.3409 ns** | **39.1180 ns** | **38.7429 ns** | **39.4236 ns** | **0.0086** |     **144 B** |
