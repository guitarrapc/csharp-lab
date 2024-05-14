```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **37.21 ns** |   **1.558 ns** |  **0.085 ns** |  **37.11 ns** |  **37.27 ns** |         **-** |
| AllocateArrayPool | 1      | 101.67 ns |   0.924 ns |  0.051 ns | 101.61 ns | 101.70 ns |         - |
| **RentReturn**        | **10**     | **530.06 ns** | **220.927 ns** | **12.110 ns** | **522.66 ns** | **544.04 ns** |         **-** |
| AllocateArrayPool | 10     | 737.42 ns |  19.002 ns |  1.042 ns | 736.47 ns | 738.53 ns |         - |
