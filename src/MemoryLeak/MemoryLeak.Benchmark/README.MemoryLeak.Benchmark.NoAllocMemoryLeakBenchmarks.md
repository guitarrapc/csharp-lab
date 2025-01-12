```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.25 ns** | **1.206 ns** | **0.066 ns** |  **19.21 ns** |  **19.33 ns** |         **-** |
| AllocateArrayPool | 1      |  84.18 ns | 2.247 ns | 0.123 ns |  84.07 ns |  84.31 ns |         - |
| **RentReturn**        | **10**     | **413.98 ns** | **8.704 ns** | **0.477 ns** | **413.67 ns** | **414.53 ns** |         **-** |
| AllocateArrayPool | 10     | 573.50 ns | 6.562 ns | 0.360 ns | 573.09 ns | 573.78 ns |         - |
