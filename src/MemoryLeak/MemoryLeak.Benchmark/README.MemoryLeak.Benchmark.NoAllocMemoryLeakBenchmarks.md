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
| **RentReturn**        | **1**      |  **34.54 ns** |  **0.443 ns** | **0.024 ns** |  **34.52 ns** |  **34.57 ns** |         **-** |
| AllocateArrayPool | 1      |  99.10 ns | 26.417 ns | 1.448 ns |  98.17 ns | 100.76 ns |         - |
| **RentReturn**        | **10**     | **525.59 ns** | **48.065 ns** | **2.635 ns** | **523.33 ns** | **528.48 ns** |         **-** |
| AllocateArrayPool | 10     | 698.68 ns | 30.687 ns | 1.682 ns | 696.95 ns | 700.32 ns |         - |
