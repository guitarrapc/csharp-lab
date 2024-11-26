```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(074a(...)ef6f) [76]** | **46.2172 ns** | **0.7066 ns** | **0.0387 ns** | **46.2219 ns** | **46.1763 ns** | **46.2533 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(334a(...)4b4f) [76]** | **33.9926 ns** | **1.4199 ns** | **0.0778 ns** | **33.9773 ns** | **33.9235 ns** | **34.0769 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(5008(...)0038) [76]** |  **0.0001 ns** | **0.0022 ns** | **0.0001 ns** |  **0.0002 ns** |  **0.0000 ns** |  **0.0002 ns** |      **-** |         **-** |
