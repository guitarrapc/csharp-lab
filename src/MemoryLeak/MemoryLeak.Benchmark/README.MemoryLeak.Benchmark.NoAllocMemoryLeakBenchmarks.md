```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.55 ns** |   **0.738 ns** |  **0.040 ns** |  **35.52 ns** |  **35.59 ns** |         **-** |
| AllocateArrayPool | 1      |  98.80 ns |   6.427 ns |  0.352 ns |  98.54 ns |  99.20 ns |         - |
| **RentReturn**        | **10**     | **541.51 ns** | **204.177 ns** | **11.192 ns** | **528.63 ns** | **548.88 ns** |         **-** |
| AllocateArrayPool | 10     | 701.37 ns |  23.224 ns |  1.273 ns | 700.59 ns | 702.84 ns |         - |
