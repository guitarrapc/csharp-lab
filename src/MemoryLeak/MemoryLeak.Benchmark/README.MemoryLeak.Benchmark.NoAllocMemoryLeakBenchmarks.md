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
| **RentReturn**        | **1**      |  **34.13 ns** |   **0.614 ns** |  **0.034 ns** |  **34.10 ns** |  **34.17 ns** |         **-** |
| AllocateArrayPool | 1      |  97.23 ns |   0.479 ns |  0.026 ns |  97.21 ns |  97.26 ns |         - |
| **RentReturn**        | **10**     | **528.25 ns** |  **64.536 ns** |  **3.537 ns** | **524.40 ns** | **531.35 ns** |         **-** |
| AllocateArrayPool | 10     | 723.39 ns | 289.635 ns | 15.876 ns | 705.12 ns | 733.85 ns |         - |
