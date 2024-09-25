```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **33.08 ns** |  **0.719 ns** | **0.039 ns** |  **33.04 ns** |  **33.12 ns** |         **-** |
| AllocateArrayPool | 1      |  98.04 ns |  1.588 ns | 0.087 ns |  97.94 ns |  98.11 ns |         - |
| **RentReturn**        | **10**     | **552.00 ns** | **21.841 ns** | **1.197 ns** | **550.92 ns** | **553.28 ns** |         **-** |
| AllocateArrayPool | 10     | 705.82 ns | 13.771 ns | 0.755 ns | 704.95 ns | 706.29 ns |         - |
