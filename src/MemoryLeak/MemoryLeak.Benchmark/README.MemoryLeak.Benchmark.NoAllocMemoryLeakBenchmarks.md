```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.08 ns** |   **0.192 ns** | **0.011 ns** |  **36.07 ns** |  **36.09 ns** |         **-** |
| AllocateArrayPool | 1      | 102.07 ns |   3.243 ns | 0.178 ns | 101.91 ns | 102.26 ns |         - |
| **RentReturn**        | **10**     | **524.51 ns** | **157.060 ns** | **8.609 ns** | **517.86 ns** | **534.23 ns** |         **-** |
| AllocateArrayPool | 10     | 717.60 ns |  90.076 ns | 4.937 ns | 713.81 ns | 723.19 ns |         - |
