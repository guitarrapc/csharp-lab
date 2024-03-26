```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.45 ns** |  **1.881 ns** | **0.103 ns** |  **34.33 ns** |  **34.51 ns** |         **-** |
| AllocateArrayPool | 1      |  97.71 ns |  8.367 ns | 0.459 ns |  97.20 ns |  98.09 ns |         - |
| **RentReturn**        | **10**     | **528.96 ns** | **24.222 ns** | **1.328 ns** | **527.46 ns** | **529.99 ns** |         **-** |
| AllocateArrayPool | 10     | 707.18 ns | 46.838 ns | 2.567 ns | 705.30 ns | 710.11 ns |         - |
