```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(1b3a(...)63c6) [76]** | **47.4405 ns** | **1.8563 ns** | **0.1017 ns** | **47.4066 ns** | **47.3601 ns** | **47.5549 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(9732(...)3086) [76]** |  **0.0089 ns** | **0.2811 ns** | **0.0154 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0267 ns** |      **-** |         **-** |
| **SlowMerge** | **(9ed8(...)1fc1) [76]** | **34.3470 ns** | **1.8235 ns** | **0.1000 ns** | **34.2989 ns** | **34.2801 ns** | **34.4619 ns** | **0.0010** |      **80 B** |
