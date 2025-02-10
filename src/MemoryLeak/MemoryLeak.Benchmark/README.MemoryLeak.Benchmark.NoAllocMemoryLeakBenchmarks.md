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
| **RentReturn**        | **1**      |  **19.25 ns** |  **0.578 ns** | **0.032 ns** |  **19.22 ns** |  **19.27 ns** |         **-** |
| AllocateArrayPool | 1      |  83.20 ns | 15.200 ns | 0.833 ns |  82.57 ns |  84.15 ns |         - |
| **RentReturn**        | **10**     | **407.75 ns** | **93.484 ns** | **5.124 ns** | **404.71 ns** | **413.67 ns** |         **-** |
| AllocateArrayPool | 10     | 581.75 ns | 84.185 ns | 4.614 ns | 576.45 ns | 584.85 ns |         - |
