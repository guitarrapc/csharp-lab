```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.42 ns** | **0.519 ns** | **0.028 ns** |  **34.39 ns** |  **34.44 ns** |         **-** |
| AllocateArrayPool | 1      |  97.82 ns | 1.828 ns | 0.100 ns |  97.71 ns |  97.91 ns |         - |
| **RentReturn**        | **10**     | **528.58 ns** | **2.597 ns** | **0.142 ns** | **528.46 ns** | **528.74 ns** |         **-** |
| AllocateArrayPool | 10     | 701.21 ns | 8.441 ns | 0.463 ns | 700.77 ns | 701.69 ns |         - |
