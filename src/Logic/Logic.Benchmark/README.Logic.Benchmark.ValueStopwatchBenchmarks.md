```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Gen0   | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|-------:|----------:|
| **Stopwatch**      | **1**      |  **61.38 ns** | **3.411 ns** | **0.187 ns** |  **61.20 ns** |  **61.58 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 1      |  57.12 ns | 0.132 ns | 0.007 ns |  57.11 ns |  57.12 ns |      - |         - |
| **Stopwatch**      | **3**      | **119.61 ns** | **5.178 ns** | **0.284 ns** | **119.43 ns** | **119.94 ns** | **0.0005** |      **40 B** |
| ValueStopwatch | 3      | 114.02 ns | 0.290 ns | 0.016 ns | 114.00 ns | 114.03 ns |      - |         - |
