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
| **RentReturn**        | **1**      |  **33.98 ns** |  **0.609 ns** | **0.033 ns** |  **33.95 ns** |  **34.02 ns** |         **-** |
| AllocateArrayPool | 1      |  99.85 ns | 46.708 ns | 2.560 ns |  97.34 ns | 102.46 ns |         - |
| **RentReturn**        | **10**     | **512.29 ns** | **70.154 ns** | **3.845 ns** | **509.57 ns** | **516.69 ns** |         **-** |
| AllocateArrayPool | 10     | 742.12 ns | 69.332 ns | 3.800 ns | 738.00 ns | 745.49 ns |         - |
