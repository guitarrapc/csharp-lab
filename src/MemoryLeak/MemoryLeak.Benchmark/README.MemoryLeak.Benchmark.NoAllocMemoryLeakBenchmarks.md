```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.48 ns** |  **2.670 ns** | **0.146 ns** |  **19.39 ns** |  **19.65 ns** |         **-** |
| AllocateArrayPool | 1      |  81.89 ns | 28.947 ns | 1.587 ns |  80.92 ns |  83.72 ns |         - |
| **RentReturn**        | **10**     | **390.15 ns** | **65.516 ns** | **3.591 ns** | **386.96 ns** | **394.04 ns** |         **-** |
| AllocateArrayPool | 10     | 563.32 ns | 43.755 ns | 2.398 ns | 560.60 ns | 565.14 ns |         - |
