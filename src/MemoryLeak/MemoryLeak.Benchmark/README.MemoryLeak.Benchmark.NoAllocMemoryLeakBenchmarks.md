```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.35 ns** |   **0.391 ns** |  **0.021 ns** |  **19.33 ns** |  **19.37 ns** |         **-** |
| AllocateArrayPool | 1      |  82.42 ns |   7.340 ns |  0.402 ns |  82.05 ns |  82.85 ns |         - |
| **RentReturn**        | **10**     | **397.56 ns** |  **58.527 ns** |  **3.208 ns** | **395.59 ns** | **401.26 ns** |         **-** |
| AllocateArrayPool | 10     | 580.83 ns | 404.303 ns | 22.161 ns | 565.85 ns | 606.29 ns |         - |
