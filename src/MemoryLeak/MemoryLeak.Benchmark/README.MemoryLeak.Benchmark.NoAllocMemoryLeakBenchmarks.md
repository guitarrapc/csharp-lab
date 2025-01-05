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
| **RentReturn**        | **1**      |  **19.24 ns** |  **1.021 ns** | **0.056 ns** |  **19.19 ns** |  **19.30 ns** |         **-** |
| AllocateArrayPool | 1      |  86.37 ns |  1.675 ns | 0.092 ns |  86.28 ns |  86.46 ns |         - |
| **RentReturn**        | **10**     | **414.45 ns** | **34.236 ns** | **1.877 ns** | **412.31 ns** | **415.81 ns** |         **-** |
| AllocateArrayPool | 10     | 586.69 ns | 56.091 ns | 3.075 ns | 583.52 ns | 589.65 ns |         - |
