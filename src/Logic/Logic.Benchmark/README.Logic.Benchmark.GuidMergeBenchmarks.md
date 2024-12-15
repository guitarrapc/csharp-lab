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
| **SlowMerge** | **(a7ca(...)a8c0) [76]** | **34.7501 ns** | **2.5553 ns** | **0.1401 ns** | **34.7545 ns** | **34.6078 ns** | **34.8878 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(c329(...)447c) [76]** | **48.2485 ns** | **1.0449 ns** | **0.0573 ns** | **48.2552 ns** | **48.1883 ns** | **48.3022 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(e6ed(...)3754) [76]** |  **0.0005 ns** | **0.0149 ns** | **0.0008 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0014 ns** |      **-** |         **-** |
