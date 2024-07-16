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
| **RentReturn**        | **1**      |  **34.04 ns** |  **0.522 ns** | **0.029 ns** |  **34.01 ns** |  **34.07 ns** |         **-** |
| AllocateArrayPool | 1      |  97.21 ns |  2.958 ns | 0.162 ns |  97.05 ns |  97.38 ns |         - |
| **RentReturn**        | **10**     | **529.43 ns** | **27.807 ns** | **1.524 ns** | **527.67 ns** | **530.31 ns** |         **-** |
| AllocateArrayPool | 10     | 704.47 ns |  8.749 ns | 0.480 ns | 704.08 ns | 705.00 ns |         - |
