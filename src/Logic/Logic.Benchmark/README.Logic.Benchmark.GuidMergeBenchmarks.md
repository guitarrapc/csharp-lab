```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(0a66(...)ac62) [76]** | **42.5075 ns** | **3.2009 ns** | **0.1755 ns** | **42.4879 ns** | **42.3427 ns** | **42.6920 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(57fb(...)4e7b) [76]** | **32.4992 ns** | **1.0804 ns** | **0.0592 ns** | **32.5131 ns** | **32.4342 ns** | **32.5502 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(e623(...)95cf) [76]** |  **0.0001 ns** | **0.0023 ns** | **0.0001 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0002 ns** |      **-** |         **-** |
