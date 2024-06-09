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
| **RentReturn**        | **1**      |  **34.24 ns** |  **2.293 ns** | **0.126 ns** |  **34.16 ns** |  **34.39 ns** |         **-** |
| AllocateArrayPool | 1      |  97.76 ns |  1.043 ns | 0.057 ns |  97.72 ns |  97.83 ns |         - |
| **RentReturn**        | **10**     | **529.42 ns** |  **5.803 ns** | **0.318 ns** | **529.06 ns** | **529.67 ns** |         **-** |
| AllocateArrayPool | 10     | 701.49 ns | 31.281 ns | 1.715 ns | 699.51 ns | 702.60 ns |         - |
