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
| **SlowMerge** | **(545f(...)74e6) [76]** | **32.3332 ns** | **15.3785 ns** | **0.8429 ns** | **31.5537 ns** | **33.2277 ns** | **0.0048** |      **80 B** |
| **FairMerge** | **(599b(...)1673) [76]** | **38.9092 ns** |  **2.3948 ns** | **0.1313 ns** | **38.7965 ns** | **39.0534 ns** | **0.0086** |     **144 B** |
| **FastMerge** | **(b5a2(...)9727) [76]** |  **0.0000 ns** |  **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
