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
| **RentReturn**        | **1**      |  **36.09 ns** |   **1.524 ns** |  **0.084 ns** |  **36.03 ns** |  **36.18 ns** |         **-** |
| AllocateArrayPool | 1      | 102.92 ns |  21.354 ns |  1.170 ns | 102.17 ns | 104.27 ns |         - |
| **RentReturn**        | **10**     | **534.06 ns** | **207.408 ns** | **11.369 ns** | **526.78 ns** | **547.16 ns** |         **-** |
| AllocateArrayPool | 10     | 728.31 ns | 310.277 ns | 17.007 ns | 716.78 ns | 747.84 ns |         - |
