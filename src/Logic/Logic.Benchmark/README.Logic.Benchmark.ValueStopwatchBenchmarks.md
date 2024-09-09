```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.70 ns** | **3.433 ns** | **0.188 ns** |  **61.59 ns** |  **61.92 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.13 ns | 0.056 ns | 0.003 ns |  57.13 ns |  57.13 ns |      - |         - |
| **Stopwatch**      | **3**      | **120.25 ns** | **9.472 ns** | **0.519 ns** | **119.93 ns** | **120.85 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.10 ns | 1.464 ns | 0.080 ns | 114.03 ns | 114.19 ns |      - |         - |
