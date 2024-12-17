```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(2f5a(...)130c) [76]** | **33.6672 ns** | **13.8354 ns** | **0.7584 ns** | **33.2304 ns** | **33.2283 ns** | **34.5429 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(4281(...)cc41) [76]** | **41.9597 ns** |  **1.2818 ns** | **0.0703 ns** | **41.9701 ns** | **41.8848 ns** | **42.0241 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(d55e(...)701b) [76]** |  **0.0010 ns** |  **0.0310 ns** | **0.0017 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0029 ns** |      **-** |         **-** |
