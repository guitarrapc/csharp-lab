```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.75 ns** |  **4.441 ns** | **0.243 ns** |  **34.60 ns** |  **35.03 ns** |         **-** |
| AllocateArrayPool | 1      |  98.38 ns |  5.424 ns | 0.297 ns |  98.12 ns |  98.70 ns |         - |
| **RentReturn**        | **10**     | **516.87 ns** |  **2.609 ns** | **0.143 ns** | **516.73 ns** | **517.02 ns** |         **-** |
| AllocateArrayPool | 10     | 702.71 ns | 11.432 ns | 0.627 ns | 702.31 ns | 703.43 ns |         - |
