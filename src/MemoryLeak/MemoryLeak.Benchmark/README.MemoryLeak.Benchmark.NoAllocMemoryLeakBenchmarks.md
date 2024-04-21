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
| **RentReturn**        | **1**      |  **35.99 ns** |   **0.951 ns** |  **0.052 ns** |  **35.93 ns** |  **36.03 ns** |         **-** |
| AllocateArrayPool | 1      | 102.31 ns |   2.556 ns |  0.140 ns | 102.18 ns | 102.45 ns |         - |
| **RentReturn**        | **10**     | **541.60 ns** | **286.305 ns** | **15.693 ns** | **523.81 ns** | **553.47 ns** |         **-** |
| AllocateArrayPool | 10     | 715.45 ns |  43.359 ns |  2.377 ns | 713.80 ns | 718.17 ns |         - |
