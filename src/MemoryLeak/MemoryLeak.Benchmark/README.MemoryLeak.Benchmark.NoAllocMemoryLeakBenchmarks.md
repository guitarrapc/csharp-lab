```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.21 ns** |   **1.284 ns** |  **0.070 ns** |  **36.14 ns** |  **36.28 ns** |         **-** |
| AllocateArrayPool | 1      |  98.53 ns |   2.089 ns |  0.114 ns |  98.41 ns |  98.64 ns |         - |
| **RentReturn**        | **10**     | **564.62 ns** | **642.366 ns** | **35.210 ns** | **544.08 ns** | **605.28 ns** |         **-** |
| AllocateArrayPool | 10     | 701.20 ns |   3.752 ns |  0.206 ns | 701.03 ns | 701.43 ns |         - |
