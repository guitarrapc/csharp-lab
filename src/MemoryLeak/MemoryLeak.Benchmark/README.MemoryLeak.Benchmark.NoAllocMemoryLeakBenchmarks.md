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
| **RentReturn**        | **1**      |  **34.17 ns** |  **1.247 ns** | **0.068 ns** |  **34.11 ns** |  **34.24 ns** |         **-** |
| AllocateArrayPool | 1      |  97.69 ns |  2.292 ns | 0.126 ns |  97.58 ns |  97.83 ns |         - |
| **RentReturn**        | **10**     | **522.09 ns** | **66.343 ns** | **3.637 ns** | **517.89 ns** | **524.25 ns** |         **-** |
| AllocateArrayPool | 10     | 710.67 ns | 70.279 ns | 3.852 ns | 706.35 ns | 713.76 ns |         - |
