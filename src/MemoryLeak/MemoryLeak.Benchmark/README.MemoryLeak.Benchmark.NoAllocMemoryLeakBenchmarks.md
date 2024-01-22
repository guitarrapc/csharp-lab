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
| **RentReturn**        | **1**      |  **34.75 ns** |   **3.816 ns** | **0.209 ns** |  **34.51 ns** |  **34.90 ns** |         **-** |
| AllocateArrayPool | 1      |  96.80 ns |   6.515 ns | 0.357 ns |  96.39 ns |  97.05 ns |         - |
| **RentReturn**        | **10**     | **520.68 ns** |  **40.048 ns** | **2.195 ns** | **518.36 ns** | **522.72 ns** |         **-** |
| AllocateArrayPool | 10     | 709.62 ns | 166.663 ns | 9.135 ns | 702.41 ns | 719.89 ns |         - |
