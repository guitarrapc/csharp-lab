```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.97 ns** |  **6.398 ns** | **0.351 ns** |  **61.60 ns** |  **62.29 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns |  0.456 ns | 0.025 ns |  57.10 ns |  57.15 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.03 ns** | **10.926 ns** | **0.599 ns** | **119.53 ns** | **120.70 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 113.96 ns |  0.207 ns | 0.011 ns | 113.95 ns | 113.97 ns |      - |         - |
