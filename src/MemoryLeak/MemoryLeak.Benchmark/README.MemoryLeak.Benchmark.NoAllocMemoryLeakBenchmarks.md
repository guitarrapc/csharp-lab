```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.77 ns** | **18.82 ns** | **1.032 ns** |  **34.16 ns** |  **35.96 ns** |         **-** |
| AllocateArrayPool | 1      |  97.86 ns | 21.55 ns | 1.181 ns |  96.98 ns |  99.20 ns |         - |
| **RentReturn**        | **10**     | **538.51 ns** | **13.22 ns** | **0.725 ns** | **537.88 ns** | **539.30 ns** |         **-** |
| AllocateArrayPool | 10     | 712.93 ns | 16.86 ns | 0.924 ns | 711.87 ns | 713.58 ns |         - |
