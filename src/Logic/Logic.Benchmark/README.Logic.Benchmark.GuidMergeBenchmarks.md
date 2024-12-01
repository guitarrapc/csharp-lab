```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(0bec(...)5554) [76]** | **34.4453 ns** |  **0.5050 ns** | **0.0277 ns** | **34.4426 ns** | **34.4191 ns** | **34.4743 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(972f(...)df50) [76]** | **49.6825 ns** | **16.6631 ns** | **0.9134 ns** | **49.1616 ns** | **49.1488 ns** | **50.7371 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(9ea3(...)95c6) [76]** |  **0.0282 ns** |  **0.8839 ns** | **0.0484 ns** |  **0.0005 ns** |  **0.0000 ns** |  **0.0842 ns** |      **-** |         **-** |
