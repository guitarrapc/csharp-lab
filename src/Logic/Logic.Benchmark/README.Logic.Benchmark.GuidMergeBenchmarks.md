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
| **SlowMerge** | **(492d(...)ef49) [76]** | **31.5620 ns** | **5.4517 ns** | **0.2988 ns** | **31.2212 ns** | **31.7789 ns** | **0.0048** |      **80 B** |
| **FairMerge** | **(7eb0(...)11bd) [76]** | **44.2044 ns** | **6.9329 ns** | **0.3800 ns** | **43.7981 ns** | **44.5511 ns** | **0.0086** |     **144 B** |
| **FastMerge** | **(a10d(...)ebc5) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
