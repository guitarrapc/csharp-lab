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
| **RentReturn**        | **1**      |  **32.87 ns** |  **1.166 ns** | **0.064 ns** |  **32.82 ns** |  **32.94 ns** |         **-** |
| AllocateArrayPool | 1      |  97.78 ns |  2.077 ns | 0.114 ns |  97.71 ns |  97.91 ns |         - |
| **RentReturn**        | **10**     | **572.88 ns** | **42.996 ns** | **2.357 ns** | **570.44 ns** | **575.14 ns** |         **-** |
| AllocateArrayPool | 10     | 698.83 ns | 12.828 ns | 0.703 ns | 698.23 ns | 699.60 ns |         - |
