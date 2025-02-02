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
| **RentReturn**        | **1**      |  **19.29 ns** |  **0.089 ns** | **0.005 ns** |  **19.28 ns** |  **19.29 ns** |         **-** |
| AllocateArrayPool | 1      |  81.61 ns |  5.077 ns | 0.278 ns |  81.30 ns |  81.84 ns |         - |
| **RentReturn**        | **10**     | **415.78 ns** | **14.025 ns** | **0.769 ns** | **415.12 ns** | **416.63 ns** |         **-** |
| AllocateArrayPool | 10     | 573.74 ns | 85.763 ns | 4.701 ns | 570.31 ns | 579.10 ns |         - |
