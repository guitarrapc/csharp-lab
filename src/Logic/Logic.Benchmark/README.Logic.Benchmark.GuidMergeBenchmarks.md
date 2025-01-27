```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(010b(...)6646) [76]** | **40.8610 ns** | **20.3571 ns** | **1.1158 ns** | **39.8782 ns** | **42.0740 ns** | **0.0086** |     **144 B** |
| **SlowMerge** | **(2ef7(...)5c70) [76]** | **32.9907 ns** | **10.3740 ns** | **0.5686 ns** | **32.4194 ns** | **33.5566 ns** | **0.0048** |      **80 B** |
| **FastMerge** | **(4ce0(...)ad31) [76]** |  **0.0000 ns** |  **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
