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
| **RentReturn**        | **1**      |  **19.31 ns** |  **0.449 ns** | **0.025 ns** |  **19.29 ns** |  **19.34 ns** |         **-** |
| AllocateArrayPool | 1      |  82.30 ns |  1.894 ns | 0.104 ns |  82.19 ns |  82.39 ns |         - |
| **RentReturn**        | **10**     | **415.62 ns** | **42.228 ns** | **2.315 ns** | **413.74 ns** | **418.21 ns** |         **-** |
| AllocateArrayPool | 10     | 578.43 ns | 20.595 ns | 1.129 ns | 577.75 ns | 579.73 ns |         - |
