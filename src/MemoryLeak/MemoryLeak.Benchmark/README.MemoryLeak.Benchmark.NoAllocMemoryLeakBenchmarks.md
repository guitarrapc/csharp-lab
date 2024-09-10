```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **33.63 ns** |  **3.460 ns** | **0.190 ns** |  **33.48 ns** |  **33.84 ns** |         **-** |
| AllocateArrayPool | 1      |  99.43 ns |  6.810 ns | 0.373 ns |  99.19 ns |  99.86 ns |         - |
| **RentReturn**        | **10**     | **521.26 ns** | **21.959 ns** | **1.204 ns** | **520.54 ns** | **522.65 ns** |         **-** |
| AllocateArrayPool | 10     | 701.35 ns | 11.498 ns | 0.630 ns | 700.98 ns | 702.08 ns |         - |
