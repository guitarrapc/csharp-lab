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
| **RentReturn**        | **1**      |  **34.07 ns** |  **1.067 ns** | **0.058 ns** |  **34.03 ns** |  **34.14 ns** |         **-** |
| AllocateArrayPool | 1      |  97.36 ns |  0.747 ns | 0.041 ns |  97.31 ns |  97.39 ns |         - |
| **RentReturn**        | **10**     | **526.45 ns** | **23.691 ns** | **1.299 ns** | **525.04 ns** | **527.60 ns** |         **-** |
| AllocateArrayPool | 10     | 704.22 ns |  3.550 ns | 0.195 ns | 704.04 ns | 704.42 ns |         - |
