```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.66 ns** |   **1.867 ns** |  **0.102 ns** |  **36.55 ns** |  **36.76 ns** |         **-** |
| AllocateArrayPool | 1      | 102.16 ns |   0.390 ns |  0.021 ns | 102.14 ns | 102.18 ns |         - |
| **RentReturn**        | **10**     | **542.58 ns** |   **7.651 ns** |  **0.419 ns** | **542.11 ns** | **542.89 ns** |         **-** |
| AllocateArrayPool | 10     | 726.89 ns | 227.799 ns | 12.486 ns | 718.85 ns | 741.28 ns |         - |
