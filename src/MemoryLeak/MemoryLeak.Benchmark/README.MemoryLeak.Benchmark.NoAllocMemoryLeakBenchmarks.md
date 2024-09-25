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
| **RentReturn**        | **1**      |  **33.02 ns** |  **1.061 ns** | **0.058 ns** |  **32.96 ns** |  **33.08 ns** |         **-** |
| AllocateArrayPool | 1      |  97.85 ns |  1.304 ns | 0.071 ns |  97.79 ns |  97.93 ns |         - |
| **RentReturn**        | **10**     | **526.58 ns** | **41.669 ns** | **2.284 ns** | **523.97 ns** | **528.23 ns** |         **-** |
| AllocateArrayPool | 10     | 706.56 ns | 39.039 ns | 2.140 ns | 704.87 ns | 708.97 ns |         - |
