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
| **RentReturn**        | **1**      |  **34.12 ns** |  **0.348 ns** | **0.019 ns** |  **34.10 ns** |  **34.14 ns** |         **-** |
| AllocateArrayPool | 1      |  96.99 ns |  3.439 ns | 0.188 ns |  96.78 ns |  97.14 ns |         - |
| **RentReturn**        | **10**     | **525.52 ns** | **83.217 ns** | **4.561 ns** | **520.56 ns** | **529.53 ns** |         **-** |
| AllocateArrayPool | 10     | 704.58 ns | 13.081 ns | 0.717 ns | 703.97 ns | 705.37 ns |         - |
