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
| **FairMerge** | **(c207(...)fd70) [76]** | **48.0598 ns** | **9.4041 ns** | **0.5155 ns** | **48.0690 ns** | **47.5399 ns** | **48.5707 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(d209(...)41f2) [76]** | **34.3767 ns** | **3.5697 ns** | **0.1957 ns** | **34.3134 ns** | **34.2205 ns** | **34.5962 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(de84(...)03a1) [76]** |  **0.0105 ns** | **0.3130 ns** | **0.0172 ns** |  **0.0012 ns** |  **0.0000 ns** |  **0.0303 ns** |      **-** |         **-** |
