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
| **RentReturn**        | **1**      |  **34.49 ns** |  **0.149 ns** | **0.008 ns** |  **34.48 ns** |  **34.49 ns** |         **-** |
| AllocateArrayPool | 1      |  97.49 ns |  1.506 ns | 0.083 ns |  97.43 ns |  97.58 ns |         - |
| **RentReturn**        | **10**     | **526.94 ns** | **86.836 ns** | **4.760 ns** | **523.71 ns** | **532.40 ns** |         **-** |
| AllocateArrayPool | 10     | 718.36 ns |  5.687 ns | 0.312 ns | 718.00 ns | 718.58 ns |         - |
