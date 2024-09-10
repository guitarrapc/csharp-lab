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
| **RentReturn**        | **1**      |  **32.99 ns** |  **3.802 ns** | **0.208 ns** |  **32.82 ns** |  **33.23 ns** |         **-** |
| AllocateArrayPool | 1      |  98.77 ns |  4.524 ns | 0.248 ns |  98.61 ns |  99.05 ns |         - |
| **RentReturn**        | **10**     | **528.20 ns** |  **6.073 ns** | **0.333 ns** | **527.85 ns** | **528.51 ns** |         **-** |
| AllocateArrayPool | 10     | 709.71 ns | 50.895 ns | 2.790 ns | 707.98 ns | 712.93 ns |         - |
