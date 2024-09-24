```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.97 ns** |   **1.012 ns** |  **0.055 ns** |  **32.92 ns** |  **33.03 ns** |         **-** |
| AllocateArrayPool | 1      |  99.33 ns |   6.627 ns |  0.363 ns |  99.08 ns |  99.74 ns |         - |
| **RentReturn**        | **10**     | **524.44 ns** |   **9.415 ns** |  **0.516 ns** | **524.08 ns** | **525.03 ns** |         **-** |
| AllocateArrayPool | 10     | 723.59 ns | 401.215 ns | 21.992 ns | 710.22 ns | 748.97 ns |         - |
