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
| **RentReturn**        | **1**      |  **34.39 ns** |  **0.799 ns** | **0.044 ns** |  **34.37 ns** |  **34.44 ns** |         **-** |
| AllocateArrayPool | 1      |  98.07 ns |  0.876 ns | 0.048 ns |  98.03 ns |  98.12 ns |         - |
| **RentReturn**        | **10**     | **526.75 ns** | **21.338 ns** | **1.170 ns** | **526.00 ns** | **528.09 ns** |         **-** |
| AllocateArrayPool | 10     | 704.77 ns | 38.647 ns | 2.118 ns | 702.51 ns | 706.71 ns |         - |
