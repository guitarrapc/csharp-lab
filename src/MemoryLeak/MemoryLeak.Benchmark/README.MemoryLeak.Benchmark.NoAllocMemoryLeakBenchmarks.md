```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.98 ns** |  **0.515 ns** | **0.028 ns** |  **36.96 ns** |  **37.01 ns** |         **-** |
| AllocateArrayPool | 1      | 102.63 ns |  7.222 ns | 0.396 ns | 102.36 ns | 103.09 ns |         - |
| **RentReturn**        | **10**     | **531.67 ns** | **27.575 ns** | **1.511 ns** | **529.97 ns** | **532.87 ns** |         **-** |
| AllocateArrayPool | 10     | 726.55 ns | 25.289 ns | 1.386 ns | 724.97 ns | 727.58 ns |         - |
