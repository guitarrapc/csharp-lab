```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.32 ns** |   **3.663 ns** |  **0.201 ns** |  **34.20 ns** |  **34.56 ns** |         **-** |
| AllocateArrayPool | 1      |  98.08 ns |   6.275 ns |  0.344 ns |  97.71 ns |  98.38 ns |         - |
| **RentReturn**        | **10**     | **533.69 ns** |  **41.286 ns** |  **2.263 ns** | **531.60 ns** | **536.09 ns** |         **-** |
| AllocateArrayPool | 10     | 749.81 ns | 630.092 ns | 34.537 ns | 709.96 ns | 771.09 ns |         - |
