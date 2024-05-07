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
| **RentReturn**        | **1**      |  **36.64 ns** |   **0.438 ns** |  **0.024 ns** |  **36.61 ns** |  **36.66 ns** |         **-** |
| AllocateArrayPool | 1      | 105.04 ns |   9.811 ns |  0.538 ns | 104.52 ns | 105.59 ns |         - |
| **RentReturn**        | **10**     | **528.45 ns** | **209.242 ns** | **11.469 ns** | **519.66 ns** | **541.43 ns** |         **-** |
| AllocateArrayPool | 10     | 717.24 ns |  25.950 ns |  1.422 ns | 715.62 ns | 718.26 ns |         - |
