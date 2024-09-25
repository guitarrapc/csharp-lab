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
| **SlowMerge** | **(657d(...)2311) [76]** | **34.5053 ns** | **1.2668 ns** | **0.0694 ns** | **34.4872 ns** | **34.4468 ns** | **34.5820 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(c3a2(...)d005) [76]** | **47.2706 ns** | **3.2794 ns** | **0.1798 ns** | **47.2247 ns** | **47.1183 ns** | **47.4689 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(e7e3(...)00a7) [76]** |  **0.0012 ns** | **0.0382 ns** | **0.0021 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0036 ns** |      **-** |         **-** |
