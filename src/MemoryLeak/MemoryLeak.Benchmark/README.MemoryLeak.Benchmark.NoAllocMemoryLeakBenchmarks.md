```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **21.09 ns** |  **1.121 ns** | **0.061 ns** |  **21.03 ns** |  **21.15 ns** |         **-** |
| AllocateArrayPool | 1      | 122.32 ns | 26.041 ns | 1.427 ns | 121.42 ns | 123.97 ns |         - |
| **RentReturn**        | **10**     | **386.19 ns** |  **9.179 ns** | **0.503 ns** | **385.69 ns** | **386.70 ns** |         **-** |
| AllocateArrayPool | 10     | 565.87 ns | 44.931 ns | 2.463 ns | 563.41 ns | 568.33 ns |         - |
