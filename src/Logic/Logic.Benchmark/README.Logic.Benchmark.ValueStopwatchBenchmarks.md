```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **Stopwatch**      | **1**      |  **56.99 ns** |  **3.291 ns** | **0.180 ns** |  **56.78 ns** |  **57.10 ns** |         **-** |
| ValueStopwatch | 1      |  56.67 ns |  6.445 ns | 0.353 ns |  56.28 ns |  56.96 ns |         - |
| **Stopwatch**      | **3**      | **115.43 ns** | **33.709 ns** | **1.848 ns** | **113.49 ns** | **117.17 ns** |         **-** |
| ValueStopwatch | 3      | 113.21 ns | 41.506 ns | 2.275 ns | 111.60 ns | 115.81 ns |         - |
