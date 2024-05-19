```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.74 ns** |   **1.210 ns** | **0.066 ns** |  **34.67 ns** |  **34.80 ns** |         **-** |
| AllocateArrayPool | 1      | 100.49 ns |  10.351 ns | 0.567 ns |  99.86 ns | 100.95 ns |         - |
| **RentReturn**        | **10**     | **552.61 ns** |  **12.246 ns** | **0.671 ns** | **552.17 ns** | **553.38 ns** |         **-** |
| AllocateArrayPool | 10     | 709.48 ns | 173.863 ns | 9.530 ns | 702.75 ns | 720.39 ns |         - |
