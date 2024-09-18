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
| **FastMerge** | **(59bc(...)34b3) [76]** |  **0.0020 ns** | **0.0438 ns** | **0.0024 ns** |  **0.0014 ns** |  **0.0000 ns** |  **0.0047 ns** |      **-** |         **-** |
| **SlowMerge** | **(a210(...)86e3) [76]** | **34.2331 ns** | **2.0981 ns** | **0.1150 ns** | **34.2437 ns** | **34.1131 ns** | **34.3424 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(a5e5(...)b983) [76]** | **49.3169 ns** | **3.2309 ns** | **0.1771 ns** | **49.2602 ns** | **49.1751 ns** | **49.5154 ns** | **0.0017** |     **144 B** |
