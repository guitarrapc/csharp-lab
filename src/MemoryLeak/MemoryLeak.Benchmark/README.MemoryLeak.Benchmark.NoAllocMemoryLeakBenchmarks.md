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
| **RentReturn**        | **1**      |  **34.25 ns** |  **0.570 ns** | **0.031 ns** |  **34.22 ns** |  **34.28 ns** |         **-** |
| AllocateArrayPool | 1      |  97.81 ns |  9.841 ns | 0.539 ns |  97.40 ns |  98.42 ns |         - |
| **RentReturn**        | **10**     | **539.29 ns** | **19.291 ns** | **1.057 ns** | **538.19 ns** | **540.29 ns** |         **-** |
| AllocateArrayPool | 10     | 698.30 ns | 11.914 ns | 0.653 ns | 697.54 ns | 698.68 ns |         - |
