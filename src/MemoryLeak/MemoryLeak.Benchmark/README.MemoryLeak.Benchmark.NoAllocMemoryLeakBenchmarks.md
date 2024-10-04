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
| **RentReturn**        | **1**      |  **32.68 ns** |  **0.725 ns** | **0.040 ns** |  **32.64 ns** |  **32.72 ns** |         **-** |
| AllocateArrayPool | 1      | 100.79 ns |  1.384 ns | 0.076 ns | 100.70 ns | 100.84 ns |         - |
| **RentReturn**        | **10**     | **587.71 ns** | **12.025 ns** | **0.659 ns** | **587.17 ns** | **588.45 ns** |         **-** |
| AllocateArrayPool | 10     | 717.75 ns | 38.774 ns | 2.125 ns | 715.68 ns | 719.93 ns |         - |
