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
| **FairMerge** | **(446f(...)bf71) [76]** | **39.0516 ns** | **4.4980 ns** | **0.2465 ns** | **38.8682 ns** | **39.3319 ns** | **0.0086** |     **144 B** |
| **SlowMerge** | **(e585(...)8080) [76]** | **31.5774 ns** | **4.7882 ns** | **0.2625 ns** | **31.2753 ns** | **31.7493 ns** | **0.0048** |      **80 B** |
| **FastMerge** | **(f7c1(...)0b25) [76]** |  **0.0069 ns** | **0.0985 ns** | **0.0054 ns** |  **0.0016 ns** |  **0.0124 ns** |      **-** |         **-** |
