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
| **SlowMerge** | **(3b85(...)49f1) [76]** | **32.3406 ns** | **4.2444 ns** | **0.2326 ns** | **32.4045 ns** | **32.0827 ns** | **32.5347 ns** | **0.0048** |      **80 B** |
| **FairMerge** | **(7106(...)f7da) [76]** | **39.6172 ns** | **5.9957 ns** | **0.3286 ns** | **39.7618 ns** | **39.2411 ns** | **39.8488 ns** | **0.0086** |     **144 B** |
| **FastMerge** | **(e767(...)e793) [76]** |  **0.0022 ns** | **0.0691 ns** | **0.0038 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0066 ns** |      **-** |         **-** |
