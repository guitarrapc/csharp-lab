```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.65 ns** |  **4.069 ns** | **0.223 ns** |  **61.51 ns** |  **61.91 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.05 ns |  1.537 ns | 0.084 ns |  57.00 ns |  57.15 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.23 ns** | **10.574 ns** | **0.580 ns** | **119.70 ns** | **120.85 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.67 ns |  1.135 ns | 0.062 ns | 114.60 ns | 114.71 ns |      - |         - |
