```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.34 ns** |   **1.555 ns** |  **0.085 ns** |  **34.27 ns** |  **34.44 ns** |         **-** |
| AllocateArrayPool | 1      |  98.11 ns |   1.361 ns |  0.075 ns |  98.06 ns |  98.20 ns |         - |
| **RentReturn**        | **10**     | **534.81 ns** | **188.717 ns** | **10.344 ns** | **527.74 ns** | **546.68 ns** |         **-** |
| AllocateArrayPool | 10     | 706.68 ns | 115.906 ns |  6.353 ns | 702.44 ns | 713.98 ns |         - |
