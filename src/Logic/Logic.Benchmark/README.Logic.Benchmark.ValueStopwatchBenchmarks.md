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
| **Stopwatch**      | **1**      |  **57.51 ns** | **0.968 ns** | **0.053 ns** |  **57.47 ns** |  **57.57 ns** |         **-** |
| ValueStopwatch | 1      |  57.49 ns | 1.238 ns | 0.068 ns |  57.41 ns |  57.54 ns |         - |
| **Stopwatch**      | **3**      | **115.73 ns** | **1.174 ns** | **0.064 ns** | **115.68 ns** | **115.81 ns** |         **-** |
| ValueStopwatch | 3      | 114.34 ns | 0.460 ns | 0.025 ns | 114.31 ns | 114.36 ns |         - |
