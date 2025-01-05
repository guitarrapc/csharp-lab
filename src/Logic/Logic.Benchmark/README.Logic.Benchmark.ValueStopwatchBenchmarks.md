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
| **Stopwatch**      | **1**      |  **58.07 ns** | **0.222 ns** | **0.012 ns** |  **58.06 ns** |  **58.08 ns** |         **-** |
| ValueStopwatch | 1      |  57.41 ns | 0.403 ns | 0.022 ns |  57.40 ns |  57.43 ns |         - |
| **Stopwatch**      | **3**      | **117.53 ns** | **1.132 ns** | **0.062 ns** | **117.47 ns** | **117.59 ns** |         **-** |
| ValueStopwatch | 3      | 115.93 ns | 2.074 ns | 0.114 ns | 115.81 ns | 116.04 ns |         - |
