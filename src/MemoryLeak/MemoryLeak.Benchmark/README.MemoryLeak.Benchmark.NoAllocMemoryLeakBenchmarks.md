```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.67 ns** |  **0.299 ns** | **0.016 ns** |  **32.65 ns** |  **32.69 ns** |         **-** |
| AllocateArrayPool | 1      | 105.47 ns |  7.353 ns | 0.403 ns | 105.14 ns | 105.92 ns |         - |
| **RentReturn**        | **10**     | **534.28 ns** | **68.492 ns** | **3.754 ns** | **530.26 ns** | **537.70 ns** |         **-** |
| AllocateArrayPool | 10     | 701.57 ns | 17.950 ns | 0.984 ns | 700.55 ns | 702.51 ns |         - |
