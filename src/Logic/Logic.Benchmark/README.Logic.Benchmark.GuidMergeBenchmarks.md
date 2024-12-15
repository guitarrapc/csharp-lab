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
| **FairMerge** | **(1ce8(...)74af) [76]** | **42.0796 ns** | **5.1204 ns** | **0.2807 ns** | **41.9291 ns** | **41.9062 ns** | **42.4034 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(5b1e(...)11e1) [76]** | **32.7833 ns** | **1.4121 ns** | **0.0774 ns** | **32.7648 ns** | **32.7168 ns** | **32.8683 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(ae4d(...)3503) [76]** |  **0.0003 ns** | **0.0092 ns** | **0.0005 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0009 ns** |      **-** |         **-** |
