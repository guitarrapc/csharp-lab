```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.17 ns** |   **0.561 ns** |  **0.031 ns** |  **34.14 ns** |  **34.20 ns** |         **-** |
| AllocateArrayPool | 1      |  98.39 ns |  18.756 ns |  1.028 ns |  97.75 ns |  99.58 ns |         - |
| **RentReturn**        | **10**     | **517.79 ns** |  **18.104 ns** |  **0.992 ns** | **516.91 ns** | **518.86 ns** |         **-** |
| AllocateArrayPool | 10     | 724.90 ns | 412.888 ns | 22.632 ns | 698.78 ns | 738.55 ns |         - |
