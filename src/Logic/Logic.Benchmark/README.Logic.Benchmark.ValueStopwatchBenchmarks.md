```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method         | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **Stopwatch**      | **1**      |  **57.52 ns** | **1.893 ns** | **0.104 ns** |  **57.45 ns** |  **57.64 ns** |         **-** |
| ValueStopwatch | 1      |  57.38 ns | 0.141 ns | 0.008 ns |  57.38 ns |  57.39 ns |         - |
| **Stopwatch**      | **3**      | **115.70 ns** | **0.443 ns** | **0.024 ns** | **115.68 ns** | **115.73 ns** |         **-** |
| ValueStopwatch | 3      | 114.34 ns | 0.408 ns | 0.022 ns | 114.31 ns | 114.36 ns |         - |
