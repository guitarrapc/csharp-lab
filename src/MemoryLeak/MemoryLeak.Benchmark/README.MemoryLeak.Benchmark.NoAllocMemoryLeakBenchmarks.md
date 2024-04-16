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
| **RentReturn**        | **1**      |  **36.35 ns** |   **1.659 ns** |  **0.091 ns** |  **36.29 ns** |  **36.45 ns** |         **-** |
| AllocateArrayPool | 1      | 102.58 ns |   1.967 ns |  0.108 ns | 102.48 ns | 102.69 ns |         - |
| **RentReturn**        | **10**     | **527.10 ns** | **201.392 ns** | **11.039 ns** | **520.09 ns** | **539.83 ns** |         **-** |
| AllocateArrayPool | 10     | 716.58 ns |  21.290 ns |  1.167 ns | 715.42 ns | 717.76 ns |         - |
