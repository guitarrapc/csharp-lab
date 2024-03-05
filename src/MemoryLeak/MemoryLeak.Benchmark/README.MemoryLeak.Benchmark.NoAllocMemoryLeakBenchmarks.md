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
| **RentReturn**        | **1**      |  **34.07 ns** |  **0.812 ns** | **0.045 ns** |  **34.04 ns** |  **34.12 ns** |         **-** |
| AllocateArrayPool | 1      | 103.04 ns |  1.332 ns | 0.073 ns | 102.96 ns | 103.11 ns |         - |
| **RentReturn**        | **10**     | **515.38 ns** | **17.602 ns** | **0.965 ns** | **514.57 ns** | **516.45 ns** |         **-** |
| AllocateArrayPool | 10     | 711.16 ns | 26.233 ns | 1.438 ns | 710.19 ns | 712.81 ns |         - |
