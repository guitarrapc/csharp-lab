```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **(1790(...)186d) [76]** |  **0.0001 ns** | **0.0025 ns** | **0.0001 ns** |  **0.0001 ns** |  **0.0000 ns** |  **0.0003 ns** |      **-** |         **-** |
| **SlowMerge** | **(3fff(...)c41d) [76]** | **34.1569 ns** | **4.5813 ns** | **0.2511 ns** | **34.0513 ns** | **33.9758 ns** | **34.4436 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(d6f8(...)9874) [76]** | **47.3402 ns** | **3.2033 ns** | **0.1756 ns** | **47.3399 ns** | **47.1647 ns** | **47.5159 ns** | **0.0017** |     **144 B** |
