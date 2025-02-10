```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(85e1(...)33ea) [76]** | **31.6771 ns** | **5.3382 ns** | **0.2926 ns** | **31.8198 ns** | **31.3405 ns** | **31.8710 ns** | **0.0048** |      **80 B** |
| **FastMerge** | **(eb33(...)84a6) [76]** |  **0.0010 ns** | **0.0238 ns** | **0.0013 ns** |  **0.0006 ns** |  **0.0000 ns** |  **0.0025 ns** |      **-** |         **-** |
| **FairMerge** | **(f754(...)1144) [76]** | **40.1599 ns** | **4.6325 ns** | **0.2539 ns** | **40.2492 ns** | **39.8733 ns** | **40.3571 ns** | **0.0086** |     **144 B** |
