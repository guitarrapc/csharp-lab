```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.34 ns** |  **4.122 ns** | **0.226 ns** |  **19.17 ns** |  **19.60 ns** |         **-** |
| AllocateArrayPool | 1      |  92.91 ns |  7.952 ns | 0.436 ns |  92.54 ns |  93.39 ns |         - |
| **RentReturn**        | **10**     | **416.71 ns** | **59.715 ns** | **3.273 ns** | **414.48 ns** | **420.47 ns** |         **-** |
| AllocateArrayPool | 10     | 598.39 ns | 85.006 ns | 4.659 ns | 594.59 ns | 603.59 ns |         - |
