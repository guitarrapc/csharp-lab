```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.22 ns** |   **1.369 ns** | **0.075 ns** |  **34.14 ns** |  **34.29 ns** |         **-** |
| AllocateArrayPool | 1      |  97.52 ns |   2.606 ns | 0.143 ns |  97.42 ns |  97.68 ns |         - |
| **RentReturn**        | **10**     | **519.66 ns** |   **9.008 ns** | **0.494 ns** | **519.10 ns** | **520.03 ns** |         **-** |
| AllocateArrayPool | 10     | 705.25 ns | 157.860 ns | 8.653 ns | 698.05 ns | 714.85 ns |         - |
