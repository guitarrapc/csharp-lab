```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **Stopwatch**      | **1**      |  **58.07 ns** | **0.648 ns** | **0.036 ns** |  **58.04 ns** |  **58.11 ns** |         **-** |
| ValueStopwatch | 1      |  57.56 ns | 4.289 ns | 0.235 ns |  57.41 ns |  57.83 ns |         - |
| **Stopwatch**      | **3**      | **117.62 ns** | **1.337 ns** | **0.073 ns** | **117.54 ns** | **117.68 ns** |         **-** |
| ValueStopwatch | 3      | 115.81 ns | 0.898 ns | 0.049 ns | 115.77 ns | 115.86 ns |         - |
