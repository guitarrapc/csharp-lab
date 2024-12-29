```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(2879(...)fef3) [76]** | **33.0672 ns** | **3.2823 ns** | **0.1799 ns** | **32.9319 ns** | **33.2714 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(5505(...)b298) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| **FairMerge** | **(f52b(...)8d7a) [76]** | **41.5995 ns** | **1.6855 ns** | **0.0924 ns** | **41.4936 ns** | **41.6633 ns** | **0.0017** |     **144 B** |
