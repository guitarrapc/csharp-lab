```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.12 ns** |  **0.960 ns** | **0.053 ns** |  **34.06 ns** |  **34.15 ns** |         **-** |
| AllocateArrayPool | 1      |  99.13 ns |  2.384 ns | 0.131 ns |  98.99 ns |  99.24 ns |         - |
| **RentReturn**        | **10**     | **517.29 ns** | **10.697 ns** | **0.586 ns** | **516.82 ns** | **517.95 ns** |         **-** |
| AllocateArrayPool | 10     | 700.04 ns |  1.552 ns | 0.085 ns | 699.95 ns | 700.12 ns |         - |
