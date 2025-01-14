```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **(0a0a(...)749e) [76]** |  **0.0170 ns** |  **0.5384 ns** | **0.0295 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0511 ns** |      **-** |         **-** |
| **FairMerge** | **(c45f(...)a3f8) [76]** | **40.3077 ns** | **10.1204 ns** | **0.5547 ns** | **40.1220 ns** | **39.8696 ns** | **40.9314 ns** | **0.0086** |     **144 B** |
| **SlowMerge** | **(fc82(...)8ac4) [76]** | **31.9994 ns** |  **3.7877 ns** | **0.2076 ns** | **32.0350 ns** | **31.7763 ns** | **32.1869 ns** | **0.0048** |      **80 B** |
