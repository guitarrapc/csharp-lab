```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.28 ns** |  **0.400 ns** | **0.022 ns** |  **34.26 ns** |  **34.31 ns** |         **-** |
| AllocateArrayPool | 1      |  97.28 ns |  0.992 ns | 0.054 ns |  97.23 ns |  97.34 ns |         - |
| **RentReturn**        | **10**     | **516.74 ns** | **12.467 ns** | **0.683 ns** | **515.95 ns** | **517.18 ns** |         **-** |
| AllocateArrayPool | 10     | 702.84 ns | 28.843 ns | 1.581 ns | 701.44 ns | 704.56 ns |         - |
