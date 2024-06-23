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
| **RentReturn**        | **1**      |  **57.99 ns** |   **0.872 ns** | **0.048 ns** |  **57.94 ns** |  **58.03 ns** |         **-** |
| AllocateArrayPool | 1      |  97.52 ns |   2.852 ns | 0.156 ns |  97.39 ns |  97.69 ns |         - |
| **RentReturn**        | **10**     | **525.00 ns** |  **83.483 ns** | **4.576 ns** | **519.73 ns** | **527.98 ns** |         **-** |
| AllocateArrayPool | 10     | 707.51 ns | 108.844 ns | 5.966 ns | 702.56 ns | 714.13 ns |         - |
