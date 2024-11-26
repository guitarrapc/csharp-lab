```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.56 ns** |  **0.763 ns** | **0.042 ns** |  **32.53 ns** |  **32.61 ns** |         **-** |
| AllocateArrayPool | 1      | 100.69 ns |  5.014 ns | 0.275 ns | 100.44 ns | 100.98 ns |         - |
| **RentReturn**        | **10**     | **538.79 ns** | **42.238 ns** | **2.315 ns** | **536.48 ns** | **541.11 ns** |         **-** |
| AllocateArrayPool | 10     | 704.80 ns | 16.975 ns | 0.930 ns | 703.92 ns | 705.77 ns |         - |
