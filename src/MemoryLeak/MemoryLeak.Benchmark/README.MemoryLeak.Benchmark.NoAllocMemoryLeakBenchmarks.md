```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.07 ns** |   **0.557 ns** | **0.031 ns** |  **34.04 ns** |  **34.10 ns** |         **-** |
| AllocateArrayPool | 1      |  97.46 ns |   2.523 ns | 0.138 ns |  97.31 ns |  97.58 ns |         - |
| **RentReturn**        | **10**     | **530.18 ns** |  **36.358 ns** | **1.993 ns** | **527.90 ns** | **531.62 ns** |         **-** |
| AllocateArrayPool | 10     | 710.96 ns | 168.821 ns | 9.254 ns | 704.97 ns | 721.62 ns |         - |
