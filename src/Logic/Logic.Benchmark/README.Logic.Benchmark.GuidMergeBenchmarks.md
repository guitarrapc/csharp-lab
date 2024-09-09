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
| **FastMerge** | **(47a6(...)3794) [76]** |  **0.0014 ns** | **0.0311 ns** | **0.0017 ns** |  **0.0009 ns** |  **0.0000 ns** |  **0.0033 ns** |      **-** |         **-** |
| **SlowMerge** | **(545e(...)7401) [76]** | **33.9841 ns** | **1.8983 ns** | **0.1041 ns** | **34.0053 ns** | **33.8711 ns** | **34.0759 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(b54a(...)3252) [76]** | **47.3933 ns** | **1.6597 ns** | **0.0910 ns** | **47.4202 ns** | **47.2920 ns** | **47.4679 ns** | **0.0017** |     **144 B** |
