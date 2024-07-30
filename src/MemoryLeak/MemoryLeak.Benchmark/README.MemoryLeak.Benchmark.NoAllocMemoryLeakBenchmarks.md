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
| **RentReturn**        | **1**      |  **33.86 ns** |   **0.429 ns** |  **0.024 ns** |  **33.84 ns** |  **33.88 ns** |         **-** |
| AllocateArrayPool | 1      |  97.42 ns |   4.383 ns |  0.240 ns |  97.22 ns |  97.69 ns |         - |
| **RentReturn**        | **10**     | **541.97 ns** |   **8.523 ns** |  **0.467 ns** | **541.67 ns** | **542.51 ns** |         **-** |
| AllocateArrayPool | 10     | 714.81 ns | 361.062 ns | 19.791 ns | 702.53 ns | 737.64 ns |         - |
