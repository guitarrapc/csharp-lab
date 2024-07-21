```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.68 ns** |  **0.278 ns** | **0.015 ns** |  **36.67 ns** |  **36.70 ns** |         **-** |
| AllocateArrayPool | 1      |  98.97 ns |  3.665 ns | 0.201 ns |  98.77 ns |  99.17 ns |         - |
| **RentReturn**        | **10**     | **520.28 ns** | **11.965 ns** | **0.656 ns** | **519.52 ns** | **520.67 ns** |         **-** |
| AllocateArrayPool | 10     | 784.69 ns | 22.854 ns | 1.253 ns | 783.84 ns | 786.13 ns |         - |
