```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.73 ns** |  **2.648 ns** | **0.145 ns** |  **34.61 ns** |  **34.89 ns** |         **-** |
| AllocateArrayPool | 1      | 100.91 ns |  4.233 ns | 0.232 ns | 100.74 ns | 101.18 ns |         - |
| **RentReturn**        | **10**     | **523.55 ns** | **90.501 ns** | **4.961 ns** | **520.40 ns** | **529.27 ns** |         **-** |
| AllocateArrayPool | 10     | 700.28 ns | 58.979 ns | 3.233 ns | 697.94 ns | 703.97 ns |         - |
