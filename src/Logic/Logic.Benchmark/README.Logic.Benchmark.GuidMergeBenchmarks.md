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
| **FastMerge** | **(3178(...)87bf) [76]** |  **0.0405 ns** | **1.1058 ns** | **0.0606 ns** |  **0.0067 ns** |  **0.0043 ns** |  **0.1105 ns** |      **-** |         **-** |
| **SlowMerge** | **(766a(...)def7) [76]** | **34.9509 ns** | **0.1639 ns** | **0.0090 ns** | **34.9507 ns** | **34.9421 ns** | **34.9600 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(e476(...)1e6e) [76]** | **48.0690 ns** | **0.9475 ns** | **0.0519 ns** | **48.0644 ns** | **48.0195 ns** | **48.1231 ns** | **0.0017** |     **144 B** |
