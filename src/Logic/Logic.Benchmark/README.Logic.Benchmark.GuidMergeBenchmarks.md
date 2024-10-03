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
| **SlowMerge** | **(5ca8(...)1029) [76]** | **34.3174 ns** | **0.5111 ns** | **0.0280 ns** | **34.3234 ns** | **34.2868 ns** | **34.3419 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(b328(...)cbea) [76]** |  **0.0002 ns** | **0.0078 ns** | **0.0004 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0007 ns** |      **-** |         **-** |
| **FairMerge** | **(e896(...)b5cc) [76]** | **47.4511 ns** | **6.9759 ns** | **0.3824 ns** | **47.5880 ns** | **47.0191 ns** | **47.7462 ns** | **0.0017** |     **144 B** |
