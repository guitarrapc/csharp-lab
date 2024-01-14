```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.27 ns** |   **2.758 ns** |  **0.151 ns** |  **34.12 ns** |  **34.42 ns** |         **-** |
| AllocateArrayPool | 1      |  97.03 ns |   1.188 ns |  0.065 ns |  96.98 ns |  97.10 ns |         - |
| **RentReturn**        | **10**     | **543.31 ns** | **477.156 ns** | **26.155 ns** | **521.21 ns** | **572.19 ns** |         **-** |
| AllocateArrayPool | 10     | 700.26 ns |   8.047 ns |  0.441 ns | 699.77 ns | 700.62 ns |         - |
