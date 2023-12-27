```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **41.93 ns** |   **0.668 ns** |  **0.037 ns** |  **41.89 ns** |  **41.96 ns** |         **-** |
| AllocateArrayPool | 1      |  97.11 ns |   3.990 ns |  0.219 ns |  96.97 ns |  97.36 ns |         - |
| **RentReturn**        | **10**     | **518.98 ns** |   **7.139 ns** |  **0.391 ns** | **518.72 ns** | **519.43 ns** |         **-** |
| AllocateArrayPool | 10     | 713.22 ns | 211.327 ns | 11.584 ns | 700.13 ns | 722.15 ns |         - |
