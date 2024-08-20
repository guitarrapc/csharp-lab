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
| **RentReturn**        | **1**      |  **33.10 ns** |  **0.580 ns** | **0.032 ns** |  **33.07 ns** |  **33.13 ns** |         **-** |
| AllocateArrayPool | 1      |  98.49 ns |  3.550 ns | 0.195 ns |  98.27 ns |  98.65 ns |         - |
| **RentReturn**        | **10**     | **521.56 ns** |  **8.858 ns** | **0.486 ns** | **521.01 ns** | **521.92 ns** |         **-** |
| AllocateArrayPool | 10     | 702.58 ns | 13.058 ns | 0.716 ns | 701.76 ns | 703.07 ns |         - |
