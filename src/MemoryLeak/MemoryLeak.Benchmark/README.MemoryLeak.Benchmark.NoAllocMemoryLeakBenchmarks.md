```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **33.30 ns** |  **1.785 ns** | **0.098 ns** |  **33.23 ns** |  **33.41 ns** |         **-** |
| AllocateArrayPool | 1      |  97.36 ns |  0.810 ns | 0.044 ns |  97.33 ns |  97.41 ns |         - |
| **RentReturn**        | **10**     | **535.11 ns** |  **8.362 ns** | **0.458 ns** | **534.83 ns** | **535.64 ns** |         **-** |
| AllocateArrayPool | 10     | 701.15 ns | 19.999 ns | 1.096 ns | 699.89 ns | 701.88 ns |         - |
