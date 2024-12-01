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
| **RentReturn**        | **1**      |  **32.93 ns** |  **0.715 ns** | **0.039 ns** |  **32.89 ns** |  **32.97 ns** |         **-** |
| AllocateArrayPool | 1      |  99.73 ns |  4.662 ns | 0.256 ns |  99.56 ns | 100.02 ns |         - |
| **RentReturn**        | **10**     | **530.71 ns** | **65.477 ns** | **3.589 ns** | **527.23 ns** | **534.40 ns** |         **-** |
| AllocateArrayPool | 10     | 701.99 ns | 16.610 ns | 0.910 ns | 701.14 ns | 702.95 ns |         - |
