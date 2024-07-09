```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.03 ns** |  **0.524 ns** | **0.029 ns** |  **35.01 ns** |  **35.06 ns** |         **-** |
| AllocateArrayPool | 1      |  98.24 ns |  1.392 ns | 0.076 ns |  98.17 ns |  98.32 ns |         - |
| **RentReturn**        | **10**     | **528.76 ns** |  **9.174 ns** | **0.503 ns** | **528.33 ns** | **529.31 ns** |         **-** |
| AllocateArrayPool | 10     | 771.22 ns | 17.200 ns | 0.943 ns | 770.25 ns | 772.13 ns |         - |
