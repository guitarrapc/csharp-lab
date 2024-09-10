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
| **RentReturn**        | **1**      |  **34.12 ns** |  **0.879 ns** | **0.048 ns** |  **34.09 ns** |  **34.17 ns** |         **-** |
| AllocateArrayPool | 1      |  98.51 ns |  4.397 ns | 0.241 ns |  98.28 ns |  98.76 ns |         - |
| **RentReturn**        | **10**     | **535.28 ns** | **24.584 ns** | **1.348 ns** | **534.02 ns** | **536.70 ns** |         **-** |
| AllocateArrayPool | 10     | 757.88 ns | 40.615 ns | 2.226 ns | 755.97 ns | 760.32 ns |         - |
