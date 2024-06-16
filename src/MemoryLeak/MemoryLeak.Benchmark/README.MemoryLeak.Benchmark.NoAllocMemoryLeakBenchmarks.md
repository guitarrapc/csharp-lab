```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.14 ns** |   **0.223 ns** | **0.012 ns** |  **34.13 ns** |  **34.15 ns** |         **-** |
| AllocateArrayPool | 1      |  99.95 ns |   3.847 ns | 0.211 ns |  99.74 ns | 100.16 ns |         - |
| **RentReturn**        | **10**     | **520.12 ns** |  **40.580 ns** | **2.224 ns** | **518.43 ns** | **522.64 ns** |         **-** |
| AllocateArrayPool | 10     | 711.88 ns | 162.310 ns | 8.897 ns | 706.69 ns | 722.15 ns |         - |
