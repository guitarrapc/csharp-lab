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
| **Stopwatch**      | **1**      |  **57.46 ns** | **0.146 ns** | **0.008 ns** |  **57.45 ns** |  **57.46 ns** |         **-** |
| ValueStopwatch | 1      |  57.42 ns | 0.347 ns | 0.019 ns |  57.41 ns |  57.44 ns |         - |
| **Stopwatch**      | **3**      | **115.65 ns** | **0.915 ns** | **0.050 ns** | **115.59 ns** | **115.69 ns** |         **-** |
| ValueStopwatch | 3      | 114.40 ns | 2.205 ns | 0.121 ns | 114.31 ns | 114.54 ns |         - |
