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
| **RentReturn**        | **1**      |  **30.52 ns** |  **6.824 ns** | **0.374 ns** |  **30.09 ns** |  **30.74 ns** |         **-** |
| AllocateArrayPool | 1      |  80.97 ns |  4.575 ns | 0.251 ns |  80.81 ns |  81.26 ns |         - |
| **RentReturn**        | **10**     | **385.30 ns** | **77.867 ns** | **4.268 ns** | **381.15 ns** | **389.68 ns** |         **-** |
| AllocateArrayPool | 10     | 557.52 ns | 29.469 ns | 1.615 ns | 556.04 ns | 559.24 ns |         - |
