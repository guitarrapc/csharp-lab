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
| **RentReturn**        | **1**      |  **34.20 ns** |   **1.446 ns** | **0.079 ns** |  **34.14 ns** |  **34.29 ns** |         **-** |
| AllocateArrayPool | 1      |  97.16 ns |   2.387 ns | 0.131 ns |  97.05 ns |  97.30 ns |         - |
| **RentReturn**        | **10**     | **525.54 ns** |  **55.997 ns** | **3.069 ns** | **522.54 ns** | **528.68 ns** |         **-** |
| AllocateArrayPool | 10     | 702.22 ns | 132.984 ns | 7.289 ns | 695.78 ns | 710.13 ns |         - |
