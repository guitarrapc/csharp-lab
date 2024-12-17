```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **Stopwatch**      | **1**      |  **57.50 ns** |  **1.930 ns** | **0.106 ns** |  **57.42 ns** |  **57.62 ns** |         **-** |
| ValueStopwatch | 1      |  57.40 ns |  0.030 ns | 0.002 ns |  57.40 ns |  57.40 ns |         - |
| **Stopwatch**      | **3**      | **115.65 ns** |  **2.002 ns** | **0.110 ns** | **115.57 ns** | **115.77 ns** |         **-** |
| ValueStopwatch | 3      | 115.15 ns | 18.148 ns | 0.995 ns | 114.31 ns | 116.25 ns |         - |
