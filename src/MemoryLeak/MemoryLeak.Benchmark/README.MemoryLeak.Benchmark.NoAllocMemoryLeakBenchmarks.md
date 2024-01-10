```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.05 ns** |  **0.710 ns** | **0.039 ns** |  **34.01 ns** |  **34.09 ns** |         **-** |
| AllocateArrayPool | 1      |  97.31 ns |  3.139 ns | 0.172 ns |  97.16 ns |  97.50 ns |         - |
| **RentReturn**        | **10**     | **538.05 ns** | **41.109 ns** | **2.253 ns** | **535.48 ns** | **539.68 ns** |         **-** |
| AllocateArrayPool | 10     | 717.56 ns | 33.359 ns | 1.829 ns | 715.94 ns | 719.54 ns |         - |
