```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.93 ns** |  **0.485 ns** | **0.027 ns** |  **32.90 ns** |  **32.95 ns** |         **-** |
| AllocateArrayPool | 1      |  98.36 ns |  2.345 ns | 0.129 ns |  98.22 ns |  98.46 ns |         - |
| **RentReturn**        | **10**     | **529.77 ns** | **25.674 ns** | **1.407 ns** | **528.75 ns** | **531.37 ns** |         **-** |
| AllocateArrayPool | 10     | 764.42 ns | 17.180 ns | 0.942 ns | 763.76 ns | 765.50 ns |         - |
