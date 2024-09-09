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
| **FastMerge** | **(6f69(...)428a) [76]** |  **0.0046 ns** | **0.1028 ns** | **0.0056 ns** |  **0.0028 ns** |  **0.0000 ns** |  **0.0109 ns** |      **-** |         **-** |
| **FairMerge** | **(8b92(...)fa90) [76]** | **47.5681 ns** | **4.1253 ns** | **0.2261 ns** | **47.6349 ns** | **47.3161 ns** | **47.7533 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(cc7a(...)f637) [76]** | **34.7538 ns** | **0.6162 ns** | **0.0338 ns** | **34.7553 ns** | **34.7193 ns** | **34.7868 ns** | **0.0010** |      **80 B** |
