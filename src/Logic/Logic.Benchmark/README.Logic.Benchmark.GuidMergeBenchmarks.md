```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **(6d59(...)48f2) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| **SlowMerge** | **(850e(...)1950) [76]** | **33.7771 ns** | **2.3814 ns** | **0.1305 ns** | **33.6474 ns** | **33.9085 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(9e20(...)1431) [76]** | **46.0707 ns** | **3.0995 ns** | **0.1699 ns** | **45.8785 ns** | **46.2008 ns** | **0.0017** |     **144 B** |
