```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **33.44 ns** |  **3.879 ns** | **0.213 ns** |  **33.21 ns** |  **33.63 ns** |         **-** |
| AllocateArrayPool | 1      |  92.46 ns |  6.089 ns | 0.334 ns |  92.14 ns |  92.80 ns |         - |
| **RentReturn**        | **10**     | **494.12 ns** | **31.874 ns** | **1.747 ns** | **492.40 ns** | **495.89 ns** |         **-** |
| AllocateArrayPool | 10     | 689.29 ns | 60.987 ns | 3.343 ns | 687.21 ns | 693.14 ns |         - |
