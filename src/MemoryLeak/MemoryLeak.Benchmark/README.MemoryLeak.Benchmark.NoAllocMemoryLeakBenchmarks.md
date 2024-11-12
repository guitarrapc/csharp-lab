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
| **RentReturn**        | **1**      |  **36.34 ns** |  **0.336 ns** | **0.018 ns** |  **36.32 ns** |  **36.35 ns** |         **-** |
| AllocateArrayPool | 1      | 103.60 ns |  0.910 ns | 0.050 ns | 103.54 ns | 103.64 ns |         - |
| **RentReturn**        | **10**     | **534.80 ns** | **36.615 ns** | **2.007 ns** | **532.62 ns** | **536.58 ns** |         **-** |
| AllocateArrayPool | 10     | 719.99 ns | 44.567 ns | 2.443 ns | 718.05 ns | 722.73 ns |         - |
