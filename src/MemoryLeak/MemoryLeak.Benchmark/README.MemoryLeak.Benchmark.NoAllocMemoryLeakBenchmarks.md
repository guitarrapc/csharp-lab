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
| **RentReturn**        | **1**      |  **35.74 ns** |  **0.205 ns** | **0.011 ns** |  **35.73 ns** |  **35.75 ns** |         **-** |
| AllocateArrayPool | 1      | 102.95 ns |  2.682 ns | 0.147 ns | 102.83 ns | 103.12 ns |         - |
| **RentReturn**        | **10**     | **536.37 ns** | **50.367 ns** | **2.761 ns** | **534.27 ns** | **539.50 ns** |         **-** |
| AllocateArrayPool | 10     | 740.63 ns | 23.760 ns | 1.302 ns | 739.35 ns | 741.95 ns |         - |
