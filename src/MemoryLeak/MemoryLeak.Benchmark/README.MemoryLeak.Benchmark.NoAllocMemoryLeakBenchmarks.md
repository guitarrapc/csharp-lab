```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.23 ns** |  **0.909 ns** | **0.050 ns** |  **34.19 ns** |  **34.29 ns** |         **-** |
| AllocateArrayPool | 1      |  97.42 ns |  1.128 ns | 0.062 ns |  97.37 ns |  97.49 ns |         - |
| **RentReturn**        | **10**     | **558.08 ns** | **16.188 ns** | **0.887 ns** | **557.14 ns** | **558.91 ns** |         **-** |
| AllocateArrayPool | 10     | 703.69 ns | 11.992 ns | 0.657 ns | 703.25 ns | 704.45 ns |         - |
