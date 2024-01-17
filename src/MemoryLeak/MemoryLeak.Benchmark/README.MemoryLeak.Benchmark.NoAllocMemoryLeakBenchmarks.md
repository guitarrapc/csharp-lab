```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.08 ns** |   **0.632 ns** |  **0.035 ns** |  **34.05 ns** |  **34.12 ns** |         **-** |
| AllocateArrayPool | 1      |  97.39 ns |   2.248 ns |  0.123 ns |  97.30 ns |  97.53 ns |         - |
| **RentReturn**        | **10**     | **526.35 ns** | **138.181 ns** |  **7.574 ns** | **521.42 ns** | **535.07 ns** |         **-** |
| AllocateArrayPool | 10     | 712.14 ns | 214.282 ns | 11.746 ns | 698.59 ns | 719.29 ns |         - |
