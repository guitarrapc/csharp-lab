```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **(1c93(...)96ea) [76]** |  **0.0216 ns** |  **0.6826 ns** | **0.0374 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0648 ns** |      **-** |         **-** |
| **SlowMerge** | **(406c(...)bf80) [76]** | **34.8691 ns** | **15.4419 ns** | **0.8464 ns** | **34.4988 ns** | **34.2709 ns** | **35.8376 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(96ec(...)43a8) [76]** | **50.3443 ns** | **15.9236 ns** | **0.8728 ns** | **49.8838 ns** | **49.7981 ns** | **51.3509 ns** | **0.0017** |     **144 B** |
