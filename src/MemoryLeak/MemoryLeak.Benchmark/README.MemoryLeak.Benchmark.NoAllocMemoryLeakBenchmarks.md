```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.25 ns** |  **0.542 ns** | **0.030 ns** |  **19.22 ns** |  **19.28 ns** |         **-** |
| AllocateArrayPool | 1      |  82.16 ns |  1.997 ns | 0.109 ns |  82.08 ns |  82.28 ns |         - |
| **RentReturn**        | **10**     | **414.03 ns** | **28.420 ns** | **1.558 ns** | **413.09 ns** | **415.83 ns** |         **-** |
| AllocateArrayPool | 10     | 570.43 ns | 17.481 ns | 0.958 ns | 569.49 ns | 571.41 ns |         - |
