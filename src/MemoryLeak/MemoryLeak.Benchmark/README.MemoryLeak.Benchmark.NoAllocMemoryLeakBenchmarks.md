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
| **RentReturn**        | **1**      |  **37.25 ns** |  **1.073 ns** | **0.059 ns** |  **37.20 ns** |  **37.31 ns** |         **-** |
| AllocateArrayPool | 1      |  98.36 ns |  2.196 ns | 0.120 ns |  98.22 ns |  98.44 ns |         - |
| **RentReturn**        | **10**     | **524.84 ns** |  **0.587 ns** | **0.032 ns** | **524.81 ns** | **524.87 ns** |         **-** |
| AllocateArrayPool | 10     | 742.96 ns | 34.204 ns | 1.875 ns | 741.25 ns | 744.96 ns |         - |
