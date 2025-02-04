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
| **Stopwatch**      | **1**      |  **65.48 ns** | **0.134 ns** | **0.007 ns** |  **65.47 ns** |  **65.48 ns** |         **-** |
| ValueStopwatch | 1      |  57.43 ns | 0.453 ns | 0.025 ns |  57.41 ns |  57.46 ns |         - |
| **Stopwatch**      | **3**      | **117.47 ns** | **0.236 ns** | **0.013 ns** | **117.46 ns** | **117.48 ns** |         **-** |
| ValueStopwatch | 3      | 115.77 ns | 0.106 ns | 0.006 ns | 115.77 ns | 115.78 ns |         - |
