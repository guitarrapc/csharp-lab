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
| **Stopwatch**      | **1**      |  **61.50 ns** |  **2.404 ns** | **0.132 ns** |  **61.39 ns** |  **61.65 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns |  0.024 ns | 0.001 ns |  57.12 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.47 ns** | **14.809 ns** | **0.812 ns** | **118.56 ns** | **120.11 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.92 ns |  1.831 ns | 0.100 ns | 113.81 ns | 113.99 ns |      - |         - |
