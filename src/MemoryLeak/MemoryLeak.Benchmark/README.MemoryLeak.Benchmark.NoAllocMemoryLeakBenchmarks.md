```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.21 ns** |   **0.613 ns** | **0.034 ns** |  **34.17 ns** |  **34.24 ns** |         **-** |
| AllocateArrayPool | 1      | 102.03 ns |   2.247 ns | 0.123 ns | 101.91 ns | 102.16 ns |         - |
| **RentReturn**        | **10**     | **530.30 ns** | **166.193 ns** | **9.110 ns** | **523.43 ns** | **540.64 ns** |         **-** |
| AllocateArrayPool | 10     | 704.25 ns |  13.035 ns | 0.715 ns | 703.51 ns | 704.94 ns |         - |
