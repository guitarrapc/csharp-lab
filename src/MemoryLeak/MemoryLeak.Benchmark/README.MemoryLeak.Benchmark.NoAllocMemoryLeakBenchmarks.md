```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.15 ns** |  **0.523 ns** | **0.029 ns** |  **34.13 ns** |  **34.18 ns** |         **-** |
| AllocateArrayPool | 1      |  97.44 ns |  0.185 ns | 0.010 ns |  97.43 ns |  97.45 ns |         - |
| **RentReturn**        | **10**     | **534.24 ns** | **20.649 ns** | **1.132 ns** | **533.01 ns** | **535.24 ns** |         **-** |
| AllocateArrayPool | 10     | 702.25 ns | 14.105 ns | 0.773 ns | 701.48 ns | 703.03 ns |         - |
