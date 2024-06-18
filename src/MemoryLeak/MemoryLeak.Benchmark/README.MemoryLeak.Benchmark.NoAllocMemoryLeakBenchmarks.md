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
| **RentReturn**        | **1**      |  **41.35 ns** |  **1.087 ns** | **0.060 ns** |  **41.31 ns** |  **41.42 ns** |         **-** |
| AllocateArrayPool | 1      |  98.75 ns |  6.353 ns | 0.348 ns |  98.52 ns |  99.15 ns |         - |
| **RentReturn**        | **10**     | **532.93 ns** | **66.189 ns** | **3.628 ns** | **528.98 ns** | **536.11 ns** |         **-** |
| AllocateArrayPool | 10     | 711.10 ns | 21.583 ns | 1.183 ns | 709.81 ns | 712.14 ns |         - |
