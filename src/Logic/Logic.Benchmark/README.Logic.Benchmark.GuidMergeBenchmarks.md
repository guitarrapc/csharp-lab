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
| **FastMerge** | **(0f29(...)5718) [76]** |  **0.0032 ns** |  **0.0354 ns** | **0.0019 ns** |  **0.0013 ns** |  **0.0052 ns** |      **-** |         **-** |
| **FairMerge** | **(880e(...)8d07) [76]** | **39.6420 ns** | **28.9353 ns** | **1.5860 ns** | **38.4248 ns** | **41.4357 ns** | **0.0086** |     **144 B** |
| **SlowMerge** | **(c1f9(...)703a) [76]** | **31.7245 ns** |  **5.7115 ns** | **0.3131 ns** | **31.5260 ns** | **32.0854 ns** | **0.0048** |      **80 B** |
