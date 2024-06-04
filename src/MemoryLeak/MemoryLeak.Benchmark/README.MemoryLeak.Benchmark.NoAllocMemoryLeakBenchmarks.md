```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.29 ns** |   **2.805 ns** |  **0.154 ns** |  **34.19 ns** |  **34.47 ns** |         **-** |
| AllocateArrayPool | 1      |  98.95 ns |   1.319 ns |  0.072 ns |  98.90 ns |  99.03 ns |         - |
| **RentReturn**        | **10**     | **528.27 ns** |  **28.112 ns** |  **1.541 ns** | **526.62 ns** | **529.67 ns** |         **-** |
| AllocateArrayPool | 10     | 709.89 ns | 227.252 ns | 12.456 ns | 701.14 ns | 724.15 ns |         - |
