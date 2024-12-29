```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.17 ns** |  **0.552 ns** | **0.030 ns** |  **19.13 ns** |  **19.19 ns** |         **-** |
| AllocateArrayPool | 1      |  81.92 ns |  4.388 ns | 0.241 ns |  81.70 ns |  82.18 ns |         - |
| **RentReturn**        | **10**     | **402.62 ns** | **80.709 ns** | **4.424 ns** | **399.90 ns** | **407.72 ns** |         **-** |
| AllocateArrayPool | 10     | 571.81 ns | 86.049 ns | 4.717 ns | 567.16 ns | 576.59 ns |         - |
