```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **(0ba1(...)3237) [76]** |  **0.0002 ns** | **0.0070 ns** | **0.0004 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0007 ns** |      **-** |         **-** |
| **SlowMerge** | **(5637(...)6cb0) [76]** | **34.4048 ns** | **2.3171 ns** | **0.1270 ns** | **34.4152 ns** | **34.2729 ns** | **34.5263 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(7292(...)d6fc) [76]** | **46.1874 ns** | **3.1557 ns** | **0.1730 ns** | **46.1231 ns** | **46.0558 ns** | **46.3833 ns** | **0.0017** |     **144 B** |
