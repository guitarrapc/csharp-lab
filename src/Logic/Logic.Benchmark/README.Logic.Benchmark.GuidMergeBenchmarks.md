```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(5452(...)9f9c) [76]** | **42.8392 ns** | **3.0848 ns** | **0.1691 ns** | **42.7333 ns** | **43.0342 ns** | **0.0086** |     **144 B** |
| **SlowMerge** | **(d2f9(...)ec09) [76]** | **33.9310 ns** | **5.8335 ns** | **0.3198 ns** | **33.6875 ns** | **34.2931 ns** | **0.0048** |      **80 B** |
| **FastMerge** | **(e2a0(...)da69) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
