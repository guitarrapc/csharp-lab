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
| **RentReturn**        | **1**      |  **34.17 ns** |  **0.778 ns** | **0.043 ns** |  **34.13 ns** |  **34.21 ns** |         **-** |
| AllocateArrayPool | 1      |  98.08 ns |  6.369 ns | 0.349 ns |  97.77 ns |  98.46 ns |         - |
| **RentReturn**        | **10**     | **520.43 ns** | **20.013 ns** | **1.097 ns** | **519.22 ns** | **521.37 ns** |         **-** |
| AllocateArrayPool | 10     | 697.34 ns | 11.318 ns | 0.620 ns | 696.85 ns | 698.04 ns |         - |
