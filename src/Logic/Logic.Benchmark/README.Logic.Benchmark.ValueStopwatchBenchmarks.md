```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.38 ns** |  **2.713 ns** | **0.149 ns** |  **61.22 ns** |  **61.52 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns |  0.279 ns | 0.015 ns |  57.11 ns |  57.14 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.51 ns** | **38.548 ns** | **2.113 ns** | **119.21 ns** | **122.95 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.97 ns |  0.193 ns | 0.011 ns | 113.96 ns | 113.98 ns |      - |         - |
