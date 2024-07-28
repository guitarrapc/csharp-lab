```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.05 ns** |  **0.676 ns** | **0.037 ns** |  **34.02 ns** |  **34.09 ns** |         **-** |
| AllocateArrayPool | 1      |  97.44 ns |  2.711 ns | 0.149 ns |  97.29 ns |  97.59 ns |         - |
| **RentReturn**        | **10**     | **529.85 ns** | **12.793 ns** | **0.701 ns** | **529.36 ns** | **530.65 ns** |         **-** |
| AllocateArrayPool | 10     | 704.54 ns | 18.514 ns | 1.015 ns | 703.37 ns | 705.22 ns |         - |
