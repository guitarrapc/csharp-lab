```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.18 ns** |  **0.915 ns** | **0.050 ns** |  **36.14 ns** |  **36.24 ns** |         **-** |
| AllocateArrayPool | 1      | 107.06 ns |  6.693 ns | 0.367 ns | 106.64 ns | 107.34 ns |         - |
| **RentReturn**        | **10**     | **523.43 ns** | **43.951 ns** | **2.409 ns** | **521.21 ns** | **526.00 ns** |         **-** |
| AllocateArrayPool | 10     | 714.71 ns | 14.825 ns | 0.813 ns | 713.80 ns | 715.37 ns |         - |
