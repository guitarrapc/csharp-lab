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
| **SlowMerge** | **(1228(...)328d) [76]** | **34.5786 ns** | **4.9160 ns** | **0.2695 ns** | **34.4359 ns** | **34.4105 ns** | **34.8894 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(acf9(...)3138) [76]** | **48.0938 ns** | **1.2565 ns** | **0.0689 ns** | **48.1032 ns** | **48.0208 ns** | **48.1576 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(f78d(...)e94f) [76]** |  **0.0032 ns** | **0.1007 ns** | **0.0055 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0096 ns** |      **-** |         **-** |
