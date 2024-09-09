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
| **RentReturn**        | **1**      |  **35.00 ns** |  **1.080 ns** | **0.059 ns** |  **34.94 ns** |  **35.05 ns** |         **-** |
| AllocateArrayPool | 1      |  98.70 ns |  2.647 ns | 0.145 ns |  98.54 ns |  98.81 ns |         - |
| **RentReturn**        | **10**     | **519.02 ns** | **65.943 ns** | **3.615 ns** | **515.03 ns** | **522.08 ns** |         **-** |
| AllocateArrayPool | 10     | 705.17 ns | 35.404 ns | 1.941 ns | 703.39 ns | 707.24 ns |         - |
