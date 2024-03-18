```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.69 ns** |   **2.599 ns** |  **0.142 ns** |  **35.60 ns** |  **35.85 ns** |         **-** |
| AllocateArrayPool | 1      |  98.69 ns |   5.293 ns |  0.290 ns |  98.38 ns |  98.96 ns |         - |
| **RentReturn**        | **10**     | **520.36 ns** | **257.507 ns** | **14.115 ns** | **510.95 ns** | **536.59 ns** |         **-** |
| AllocateArrayPool | 10     | 706.56 ns |  15.756 ns |  0.864 ns | 705.68 ns | 707.40 ns |         - |
