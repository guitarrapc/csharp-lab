```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.65 ns** |  **0.808 ns** | **0.044 ns** |  **34.61 ns** |  **34.70 ns** |         **-** |
| AllocateArrayPool | 1      |  98.67 ns | 36.672 ns | 2.010 ns |  97.51 ns | 100.99 ns |         - |
| **RentReturn**        | **10**     | **522.78 ns** |  **7.406 ns** | **0.406 ns** | **522.42 ns** | **523.22 ns** |         **-** |
| AllocateArrayPool | 10     | 706.78 ns | 54.313 ns | 2.977 ns | 703.91 ns | 709.86 ns |         - |
