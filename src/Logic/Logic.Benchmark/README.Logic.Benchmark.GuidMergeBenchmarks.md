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
| **FairMerge** | **(57d0(...)106e) [76]** | **35.7080 ns** | **8.1481 ns** | **0.4466 ns** | **35.7831 ns** | **35.2285 ns** | **36.1123 ns** | **0.0086** |     **144 B** |
| **FastMerge** | **(8a74(...)b9ac) [76]** |  **0.0027 ns** | **0.0639 ns** | **0.0035 ns** |  **0.0015 ns** |  **0.0000 ns** |  **0.0067 ns** |      **-** |         **-** |
| **SlowMerge** | **(8fb9(...)c498) [76]** | **29.6112 ns** | **5.4574 ns** | **0.2991 ns** | **29.7260 ns** | **29.2717 ns** | **29.8359 ns** | **0.0048** |      **80 B** |
