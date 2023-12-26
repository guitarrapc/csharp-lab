```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.00 ns** |  **1.088 ns** | **0.060 ns** |  **33.96 ns** |  **34.07 ns** |         **-** |
| AllocateArrayPool | 1      |  97.14 ns |  0.778 ns | 0.043 ns |  97.11 ns |  97.19 ns |         - |
| **RentReturn**        | **10**     | **516.70 ns** | **33.284 ns** | **1.824 ns** | **514.81 ns** | **518.46 ns** |         **-** |
| AllocateArrayPool | 10     | 700.65 ns | 44.279 ns | 2.427 ns | 698.26 ns | 703.11 ns |         - |
