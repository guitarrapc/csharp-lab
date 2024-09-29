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
| **RentReturn**        | **1**      |  **32.81 ns** |  **0.797 ns** | **0.044 ns** |  **32.78 ns** |  **32.86 ns** |         **-** |
| AllocateArrayPool | 1      |  98.18 ns |  2.144 ns | 0.118 ns |  98.10 ns |  98.31 ns |         - |
| **RentReturn**        | **10**     | **528.66 ns** | **62.155 ns** | **3.407 ns** | **526.45 ns** | **532.58 ns** |         **-** |
| AllocateArrayPool | 10     | 703.76 ns |  8.031 ns | 0.440 ns | 703.43 ns | 704.26 ns |         - |
