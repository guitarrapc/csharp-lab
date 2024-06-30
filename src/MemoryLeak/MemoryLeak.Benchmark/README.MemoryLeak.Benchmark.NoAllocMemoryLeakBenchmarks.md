```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.79 ns** |  **1.841 ns** | **0.101 ns** |  **34.72 ns** |  **34.90 ns** |         **-** |
| AllocateArrayPool | 1      |  98.84 ns | 14.148 ns | 0.775 ns |  98.38 ns |  99.73 ns |         - |
| **RentReturn**        | **10**     | **529.26 ns** | **10.213 ns** | **0.560 ns** | **528.77 ns** | **529.87 ns** |         **-** |
| AllocateArrayPool | 10     | 764.26 ns | 85.146 ns | 4.667 ns | 760.64 ns | 769.53 ns |         - |
