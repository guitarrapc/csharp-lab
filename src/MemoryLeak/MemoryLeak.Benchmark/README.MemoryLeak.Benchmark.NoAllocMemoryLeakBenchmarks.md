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
| **RentReturn**        | **1**      |  **35.97 ns** |  **0.270 ns** | **0.015 ns** |  **35.95 ns** |  **35.98 ns** |         **-** |
| AllocateArrayPool | 1      | 110.43 ns |  8.492 ns | 0.465 ns | 110.06 ns | 110.96 ns |         - |
| **RentReturn**        | **10**     | **521.65 ns** | **15.379 ns** | **0.843 ns** | **520.92 ns** | **522.57 ns** |         **-** |
| AllocateArrayPool | 10     | 714.65 ns | 18.381 ns | 1.008 ns | 713.89 ns | 715.80 ns |         - |
