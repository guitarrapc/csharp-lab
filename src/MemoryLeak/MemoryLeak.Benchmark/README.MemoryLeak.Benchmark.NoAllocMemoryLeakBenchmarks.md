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
| **RentReturn**        | **1**      |  **32.82 ns** |  **1.475 ns** | **0.081 ns** |  **32.73 ns** |  **32.89 ns** |         **-** |
| AllocateArrayPool | 1      |  97.86 ns |  9.793 ns | 0.537 ns |  97.34 ns |  98.41 ns |         - |
| **RentReturn**        | **10**     | **518.54 ns** | **34.521 ns** | **1.892 ns** | **516.78 ns** | **520.54 ns** |         **-** |
| AllocateArrayPool | 10     | 703.16 ns | 23.940 ns | 1.312 ns | 701.80 ns | 704.41 ns |         - |
