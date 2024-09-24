```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(30ab(...)be40) [76]** | **34.6610 ns** | **2.1301 ns** | **0.1168 ns** | **34.5405 ns** | **34.7736 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(4a33(...)2b79) [76]** | **49.9044 ns** | **3.0373 ns** | **0.1665 ns** | **49.7475 ns** | **50.0790 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(b63c(...)2cde) [76]** |  **0.0026 ns** | **0.0489 ns** | **0.0027 ns** |  **0.0000 ns** |  **0.0054 ns** |      **-** |         **-** |
