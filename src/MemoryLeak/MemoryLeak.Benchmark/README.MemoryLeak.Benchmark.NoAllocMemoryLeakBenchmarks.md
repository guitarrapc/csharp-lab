```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.41 ns** |   **1.763 ns** | **0.097 ns** |  **19.34 ns** |  **19.52 ns** |         **-** |
| AllocateArrayPool | 1      |  82.40 ns |   4.831 ns | 0.265 ns |  82.23 ns |  82.70 ns |         - |
| **RentReturn**        | **10**     | **418.72 ns** | **137.127 ns** | **7.516 ns** | **410.82 ns** | **425.78 ns** |         **-** |
| AllocateArrayPool | 10     | 577.63 ns |  53.270 ns | 2.920 ns | 574.45 ns | 580.19 ns |         - |
