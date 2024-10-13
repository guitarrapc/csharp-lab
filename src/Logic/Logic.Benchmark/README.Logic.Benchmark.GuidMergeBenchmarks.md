```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(01bb(...)9546) [76]** | **48.9678 ns** | **2.0471 ns** | **0.1122 ns** | **48.9587 ns** | **48.8604 ns** | **49.0843 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(659c(...)b3ec) [76]** | **33.9136 ns** | **0.4153 ns** | **0.0228 ns** | **33.9181 ns** | **33.8890 ns** | **33.9339 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(dc71(...)ab4b) [76]** |  **0.0007 ns** | **0.0115 ns** | **0.0006 ns** |  **0.0010 ns** |  **0.0000 ns** |  **0.0012 ns** |      **-** |         **-** |
