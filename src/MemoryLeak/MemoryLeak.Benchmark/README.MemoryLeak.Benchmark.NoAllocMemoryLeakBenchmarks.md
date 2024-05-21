```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **43.36 ns** |  **1.009 ns** | **0.055 ns** |  **43.31 ns** |  **43.42 ns** |         **-** |
| AllocateArrayPool | 1      |  95.95 ns |  1.603 ns | 0.088 ns |  95.85 ns |  96.01 ns |         - |
| **RentReturn**        | **10**     | **527.57 ns** | **12.181 ns** | **0.668 ns** | **527.13 ns** | **528.34 ns** |         **-** |
| AllocateArrayPool | 10     | 705.16 ns | 23.702 ns | 1.299 ns | 704.23 ns | 706.65 ns |         - |
