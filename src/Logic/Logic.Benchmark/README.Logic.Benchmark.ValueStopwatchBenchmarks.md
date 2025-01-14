```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **Stopwatch**      | **1**      |  **59.04 ns** | **0.668 ns** | **0.037 ns** |  **59.01 ns** |  **59.08 ns** |         **-** |
| ValueStopwatch | 1      |  57.41 ns | 0.170 ns | 0.009 ns |  57.41 ns |  57.42 ns |         - |
| **Stopwatch**      | **3**      | **117.68 ns** | **1.276 ns** | **0.070 ns** | **117.60 ns** | **117.73 ns** |         **-** |
| ValueStopwatch | 3      | 115.84 ns | 0.643 ns | 0.035 ns | 115.80 ns | 115.87 ns |         - |
