```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.87 ns** |   **0.343 ns** |  **0.019 ns** |  **32.85 ns** |  **32.89 ns** |         **-** |
| AllocateArrayPool | 1      |  99.75 ns |  58.422 ns |  3.202 ns |  97.85 ns | 103.45 ns |         - |
| **RentReturn**        | **10**     | **560.82 ns** | **478.582 ns** | **26.233 ns** | **530.55 ns** | **576.91 ns** |         **-** |
| AllocateArrayPool | 10     | 703.91 ns |  42.262 ns |  2.317 ns | 701.98 ns | 706.48 ns |         - |
