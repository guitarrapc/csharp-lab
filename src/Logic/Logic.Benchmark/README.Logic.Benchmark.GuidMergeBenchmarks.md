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
| **FastMerge** | **(4487(...)94e8) [76]** |  **0.0083 ns** | **0.1495 ns** | **0.0082 ns** |  **0.0045 ns** |  **0.0028 ns** |  **0.0177 ns** |      **-** |         **-** |
| **SlowMerge** | **(a1df(...)9277) [76]** | **34.5943 ns** | **4.1689 ns** | **0.2285 ns** | **34.5899 ns** | **34.3680 ns** | **34.8249 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(bfd1(...)40c6) [76]** | **50.3572 ns** | **4.3816 ns** | **0.2402 ns** | **50.4638 ns** | **50.0822 ns** | **50.5256 ns** | **0.0017** |     **144 B** |
