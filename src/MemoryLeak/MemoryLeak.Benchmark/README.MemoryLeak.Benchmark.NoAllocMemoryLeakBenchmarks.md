```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.36 ns** |  **2.413 ns** | **0.132 ns** |  **35.26 ns** |  **35.51 ns** |         **-** |
| AllocateArrayPool | 1      |  97.65 ns |  3.692 ns | 0.202 ns |  97.48 ns |  97.87 ns |         - |
| **RentReturn**        | **10**     | **602.81 ns** | **25.465 ns** | **1.396 ns** | **601.66 ns** | **604.37 ns** |         **-** |
| AllocateArrayPool | 10     | 700.53 ns | 61.400 ns | 3.366 ns | 696.66 ns | 702.79 ns |         - |
