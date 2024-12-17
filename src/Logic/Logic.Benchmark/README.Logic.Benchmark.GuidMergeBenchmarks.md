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
| **FairMerge** | **(c1be(...)417a) [76]** | **42.8609 ns** | **5.7407 ns** | **0.3147 ns** | **43.0199 ns** | **42.4984 ns** | **43.0643 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(ebea(...)8d63) [76]** |  **0.0022 ns** | **0.0636 ns** | **0.0035 ns** |  **0.0003 ns** |  **0.0000 ns** |  **0.0062 ns** |      **-** |         **-** |
| **SlowMerge** | **(f3eb(...)d9da) [76]** | **33.1316 ns** | **4.3472 ns** | **0.2383 ns** | **33.1046 ns** | **32.9079 ns** | **33.3822 ns** | **0.0010** |      **80 B** |
