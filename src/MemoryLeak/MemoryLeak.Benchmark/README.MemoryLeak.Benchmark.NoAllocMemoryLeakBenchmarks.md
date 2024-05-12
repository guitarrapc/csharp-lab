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
| **RentReturn**        | **1**      |  **36.02 ns** |   **1.697 ns** | **0.093 ns** |  **35.92 ns** |  **36.10 ns** |         **-** |
| AllocateArrayPool | 1      | 102.45 ns |   1.216 ns | 0.067 ns | 102.38 ns | 102.52 ns |         - |
| **RentReturn**        | **10**     | **525.58 ns** | **109.792 ns** | **6.018 ns** | **521.08 ns** | **532.42 ns** |         **-** |
| AllocateArrayPool | 10     | 714.55 ns |  37.686 ns | 2.066 ns | 712.18 ns | 715.98 ns |         - |
