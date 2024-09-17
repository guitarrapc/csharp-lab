```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **33.00 ns** |  **2.130 ns** | **0.117 ns** |  **32.90 ns** |  **33.13 ns** |         **-** |
| AllocateArrayPool | 1      |  98.20 ns |  3.865 ns | 0.212 ns |  98.01 ns |  98.43 ns |         - |
| **RentReturn**        | **10**     | **526.89 ns** | **69.590 ns** | **3.814 ns** | **522.49 ns** | **529.11 ns** |         **-** |
| AllocateArrayPool | 10     | 710.41 ns | 27.264 ns | 1.494 ns | 709.05 ns | 712.01 ns |         - |
