```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(a911(...)2cac) [76]** | **46.4840 ns** | **3.2829 ns** | **0.1799 ns** | **46.5508 ns** | **46.2803 ns** | **46.6211 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(d55e(...)1421) [76]** |  **0.0281 ns** | **0.8893 ns** | **0.0487 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0844 ns** |      **-** |         **-** |
| **SlowMerge** | **(ff31(...)1122) [76]** | **34.1727 ns** | **0.6851 ns** | **0.0376 ns** | **34.1528 ns** | **34.1493 ns** | **34.2161 ns** | **0.0010** |      **80 B** |
