```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.24 ns** |  **3.037 ns** | **0.166 ns** |  **34.14 ns** |  **34.43 ns** |         **-** |
| AllocateArrayPool | 1      |  98.20 ns | 11.261 ns | 0.617 ns |  97.51 ns |  98.69 ns |         - |
| **RentReturn**        | **10**     | **547.00 ns** | **50.456 ns** | **2.766 ns** | **545.32 ns** | **550.20 ns** |         **-** |
| AllocateArrayPool | 10     | 723.41 ns | 81.834 ns | 4.486 ns | 718.47 ns | 727.22 ns |         - |
