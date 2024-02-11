```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **40.24 ns** |   **1.828 ns** |  **0.100 ns** |  **40.12 ns** |  **40.31 ns** |         **-** |
| AllocateArrayPool | 1      |  97.82 ns |   6.686 ns |  0.367 ns |  97.56 ns |  98.24 ns |         - |
| **RentReturn**        | **10**     | **526.64 ns** |   **6.485 ns** |  **0.355 ns** | **526.38 ns** | **527.05 ns** |         **-** |
| AllocateArrayPool | 10     | 718.70 ns | 557.880 ns | 30.579 ns | 700.45 ns | 754.00 ns |         - |
