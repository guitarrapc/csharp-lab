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
| **RentReturn**        | **1**      |  **36.71 ns** |  **2.466 ns** | **0.135 ns** |  **36.62 ns** |  **36.86 ns** |         **-** |
| AllocateArrayPool | 1      |  97.25 ns |  7.689 ns | 0.421 ns |  96.93 ns |  97.73 ns |         - |
| **RentReturn**        | **10**     | **530.62 ns** | **34.776 ns** | **1.906 ns** | **528.91 ns** | **532.67 ns** |         **-** |
| AllocateArrayPool | 10     | 723.20 ns | 16.392 ns | 0.898 ns | 722.27 ns | 724.06 ns |         - |
