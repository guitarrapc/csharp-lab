```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **33.09 ns** |  **2.050 ns** | **0.112 ns** |  **32.97 ns** |  **33.17 ns** |         **-** |
| AllocateArrayPool | 1      |  97.28 ns |  2.027 ns | 0.111 ns |  97.16 ns |  97.38 ns |         - |
| **RentReturn**        | **10**     | **526.94 ns** | **24.975 ns** | **1.369 ns** | **525.47 ns** | **528.18 ns** |         **-** |
| AllocateArrayPool | 10     | 698.37 ns | 25.570 ns | 1.402 ns | 696.75 ns | 699.29 ns |         - |
