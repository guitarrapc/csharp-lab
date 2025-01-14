```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.32 ns** |  **2.106 ns** | **0.115 ns** |  **19.25 ns** |  **19.45 ns** |         **-** |
| AllocateArrayPool | 1      |  86.70 ns | 16.933 ns | 0.928 ns |  86.11 ns |  87.77 ns |         - |
| **RentReturn**        | **10**     | **414.09 ns** |  **3.045 ns** | **0.167 ns** | **413.97 ns** | **414.28 ns** |         **-** |
| AllocateArrayPool | 10     | 584.58 ns | 14.553 ns | 0.798 ns | 583.77 ns | 585.37 ns |         - |
