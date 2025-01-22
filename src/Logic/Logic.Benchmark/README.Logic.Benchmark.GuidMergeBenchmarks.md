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
| **FastMerge** | **(3796(...)f45f) [76]** |  **0.0028 ns** | **0.0600 ns** | **0.0033 ns** |  **0.0019 ns** |  **0.0000 ns** |  **0.0064 ns** |      **-** |         **-** |
| **SlowMerge** | **(ae54(...)eaef) [76]** | **33.5878 ns** | **4.0047 ns** | **0.2195 ns** | **33.7099 ns** | **33.3344 ns** | **33.7192 ns** | **0.0048** |      **80 B** |
| **FairMerge** | **(fc84(...)73b0) [76]** | **41.7956 ns** | **7.8798 ns** | **0.4319 ns** | **41.9827 ns** | **41.3016 ns** | **42.1023 ns** | **0.0086** |     **144 B** |
