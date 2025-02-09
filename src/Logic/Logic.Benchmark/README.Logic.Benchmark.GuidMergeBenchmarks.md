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
| **SlowMerge** | **(5d98(...)c633) [76]** | **32.3771 ns** | **2.5005 ns** | **0.1371 ns** | **32.4335 ns** | **32.2208 ns** | **32.4769 ns** | **0.0048** |      **80 B** |
| **FastMerge** | **(8097(...)caed) [76]** |  **0.0063 ns** | **0.1431 ns** | **0.0078 ns** |  **0.0035 ns** |  **0.0002 ns** |  **0.0151 ns** |      **-** |         **-** |
| **FairMerge** | **(bf96(...)0500) [76]** | **39.3602 ns** | **5.3610 ns** | **0.2939 ns** | **39.3358 ns** | **39.0793 ns** | **39.6654 ns** | **0.0086** |     **144 B** |
