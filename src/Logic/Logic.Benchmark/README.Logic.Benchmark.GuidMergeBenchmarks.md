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
| **SlowMerge** | **(624b(...)201a) [76]** | **34.4461 ns** | **4.5779 ns** | **0.2509 ns** | **34.4171 ns** | **34.2110 ns** | **34.7103 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(6be6(...)aa97) [76]** | **47.5982 ns** | **0.6378 ns** | **0.0350 ns** | **47.6014 ns** | **47.5618 ns** | **47.6315 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(c4fc(...)6c05) [76]** |  **0.0004 ns** | **0.0124 ns** | **0.0007 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0012 ns** |      **-** |         **-** |
