```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.13 ns** |  **1.437 ns** | **0.079 ns** |  **34.06 ns** |  **34.21 ns** |         **-** |
| AllocateArrayPool | 1      |  98.57 ns | 12.761 ns | 0.699 ns |  98.16 ns |  99.38 ns |         - |
| **RentReturn**        | **10**     | **541.73 ns** | **30.145 ns** | **1.652 ns** | **540.40 ns** | **543.58 ns** |         **-** |
| AllocateArrayPool | 10     | 696.33 ns | 15.256 ns | 0.836 ns | 695.81 ns | 697.29 ns |         - |
