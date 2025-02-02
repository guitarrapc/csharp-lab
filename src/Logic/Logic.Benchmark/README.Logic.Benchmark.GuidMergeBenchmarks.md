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
| **FairMerge** | **(34d4(...)4f49) [76]** | **39.6006 ns** |  **5.3546 ns** | **0.2935 ns** | **39.3494 ns** | **39.9232 ns** | **0.0086** |     **144 B** |
| **SlowMerge** | **(7d80(...)1c89) [76]** | **32.4542 ns** | **13.8623 ns** | **0.7598 ns** | **31.9860 ns** | **33.3309 ns** | **0.0048** |      **80 B** |
| **FastMerge** | **(7e01(...)79e9) [76]** |  **0.0000 ns** |  **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
