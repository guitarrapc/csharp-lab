```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.12 ns** |   **0.557 ns** |  **0.031 ns** |  **34.09 ns** |  **34.14 ns** |         **-** |
| AllocateArrayPool | 1      |  96.85 ns |   1.445 ns |  0.079 ns |  96.76 ns |  96.91 ns |         - |
| **RentReturn**        | **10**     | **544.06 ns** | **296.771 ns** | **16.267 ns** | **534.45 ns** | **562.85 ns** |         **-** |
| AllocateArrayPool | 10     | 705.21 ns |  11.027 ns |  0.604 ns | 704.79 ns | 705.90 ns |         - |
