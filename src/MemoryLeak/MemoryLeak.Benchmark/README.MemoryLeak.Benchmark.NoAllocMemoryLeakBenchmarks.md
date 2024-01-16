```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.15 ns** |  **1.742 ns** | **0.095 ns** |  **34.06 ns** |  **34.25 ns** |         **-** |
| AllocateArrayPool | 1      |  97.63 ns |  1.757 ns | 0.096 ns |  97.52 ns |  97.69 ns |         - |
| **RentReturn**        | **10**     | **556.90 ns** | **47.155 ns** | **2.585 ns** | **554.01 ns** | **558.99 ns** |         **-** |
| AllocateArrayPool | 10     | 703.84 ns | 51.292 ns | 2.812 ns | 701.92 ns | 707.06 ns |         - |
