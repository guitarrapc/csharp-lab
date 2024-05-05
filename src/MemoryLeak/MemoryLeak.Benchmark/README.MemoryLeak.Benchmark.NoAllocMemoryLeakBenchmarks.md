```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.79 ns** |  **0.490 ns** | **0.027 ns** |  **36.77 ns** |  **36.82 ns** |         **-** |
| AllocateArrayPool | 1      | 102.05 ns |  1.299 ns | 0.071 ns | 101.97 ns | 102.09 ns |         - |
| **RentReturn**        | **10**     | **523.19 ns** | **21.946 ns** | **1.203 ns** | **522.25 ns** | **524.54 ns** |         **-** |
| AllocateArrayPool | 10     | 721.77 ns | 46.534 ns | 2.551 ns | 718.91 ns | 723.82 ns |         - |
