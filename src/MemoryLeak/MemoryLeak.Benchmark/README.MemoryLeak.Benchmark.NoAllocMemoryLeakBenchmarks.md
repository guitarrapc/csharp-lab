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
| **RentReturn**        | **1**      |  **19.34 ns** |  **1.294 ns** | **0.071 ns** |  **19.29 ns** |  **19.42 ns** |         **-** |
| AllocateArrayPool | 1      |  95.59 ns |  2.715 ns | 0.149 ns |  95.42 ns |  95.70 ns |         - |
| **RentReturn**        | **10**     | **411.15 ns** | **14.088 ns** | **0.772 ns** | **410.55 ns** | **412.02 ns** |         **-** |
| AllocateArrayPool | 10     | 587.55 ns | 30.169 ns | 1.654 ns | 586.58 ns | 589.46 ns |         - |
