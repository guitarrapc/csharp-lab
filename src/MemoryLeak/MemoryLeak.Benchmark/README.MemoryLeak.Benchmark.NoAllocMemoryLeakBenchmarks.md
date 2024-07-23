```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **33.86 ns** |   **0.627 ns** |  **0.034 ns** |  **33.82 ns** |  **33.89 ns** |         **-** |
| AllocateArrayPool | 1      |  97.98 ns |   1.451 ns |  0.080 ns |  97.92 ns |  98.07 ns |         - |
| **RentReturn**        | **10**     | **510.53 ns** |  **25.538 ns** |  **1.400 ns** | **508.92 ns** | **511.41 ns** |         **-** |
| AllocateArrayPool | 10     | 758.10 ns | 783.517 ns | 42.947 ns | 708.54 ns | 784.40 ns |         - |
