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
| **RentReturn**        | **1**      |  **36.47 ns** |  **1.712 ns** | **0.094 ns** |  **36.37 ns** |  **36.55 ns** |         **-** |
| AllocateArrayPool | 1      |  97.78 ns |  9.618 ns | 0.527 ns |  97.45 ns |  98.39 ns |         - |
| **RentReturn**        | **10**     | **519.92 ns** | **16.929 ns** | **0.928 ns** | **519.08 ns** | **520.92 ns** |         **-** |
| AllocateArrayPool | 10     | 699.33 ns |  3.822 ns | 0.210 ns | 699.17 ns | 699.57 ns |         - |
