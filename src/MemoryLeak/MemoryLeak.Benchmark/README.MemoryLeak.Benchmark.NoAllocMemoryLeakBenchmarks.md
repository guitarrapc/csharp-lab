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
| **RentReturn**        | **1**      |  **34.80 ns** |  **0.764 ns** | **0.042 ns** |  **34.77 ns** |  **34.85 ns** |         **-** |
| AllocateArrayPool | 1      |  97.18 ns |  3.691 ns | 0.202 ns |  97.03 ns |  97.41 ns |         - |
| **RentReturn**        | **10**     | **523.41 ns** |  **3.025 ns** | **0.166 ns** | **523.28 ns** | **523.60 ns** |         **-** |
| AllocateArrayPool | 10     | 715.94 ns | 91.145 ns | 4.996 ns | 710.31 ns | 719.84 ns |         - |
