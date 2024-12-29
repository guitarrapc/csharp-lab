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
| **Stopwatch**      | **1**      |  **57.47 ns** |  **0.272 ns** | **0.015 ns** |  **57.45 ns** |  **57.48 ns** |         **-** |
| ValueStopwatch | 1      |  57.58 ns |  5.533 ns | 0.303 ns |  57.40 ns |  57.93 ns |         - |
| **Stopwatch**      | **3**      | **116.48 ns** | **24.649 ns** | **1.351 ns** | **115.65 ns** | **118.04 ns** |         **-** |
| ValueStopwatch | 3      | 114.28 ns |  0.037 ns | 0.002 ns | 114.27 ns | 114.28 ns |         - |
