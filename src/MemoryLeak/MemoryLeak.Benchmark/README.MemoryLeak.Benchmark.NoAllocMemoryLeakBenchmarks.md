```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.25 ns** |   **0.243 ns** | **0.013 ns** |  **34.24 ns** |  **34.27 ns** |         **-** |
| AllocateArrayPool | 1      |  98.76 ns |   8.240 ns | 0.452 ns |  98.25 ns |  99.09 ns |         - |
| **RentReturn**        | **10**     | **525.15 ns** |  **23.728 ns** | **1.301 ns** | **524.20 ns** | **526.64 ns** |         **-** |
| AllocateArrayPool | 10     | 710.53 ns | 143.447 ns | 7.863 ns | 705.13 ns | 719.55 ns |         - |
