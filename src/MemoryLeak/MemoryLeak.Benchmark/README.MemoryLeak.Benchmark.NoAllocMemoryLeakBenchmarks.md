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
| **RentReturn**        | **1**      |  **32.78 ns** |  **0.601 ns** | **0.033 ns** |  **32.76 ns** |  **32.82 ns** |         **-** |
| AllocateArrayPool | 1      |  99.10 ns |  6.247 ns | 0.342 ns |  98.87 ns |  99.49 ns |         - |
| **RentReturn**        | **10**     | **517.51 ns** | **10.260 ns** | **0.562 ns** | **517.09 ns** | **518.15 ns** |         **-** |
| AllocateArrayPool | 10     | 705.56 ns | 82.472 ns | 4.521 ns | 701.14 ns | 710.17 ns |         - |
