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
| **RentReturn**        | **1**      |  **34.13 ns** |   **0.438 ns** |  **0.024 ns** |  **34.10 ns** |  **34.14 ns** |         **-** |
| AllocateArrayPool | 1      |  97.19 ns |   1.124 ns |  0.062 ns |  97.12 ns |  97.24 ns |         - |
| **RentReturn**        | **10**     | **541.23 ns** | **195.299 ns** | **10.705 ns** | **534.95 ns** | **553.59 ns** |         **-** |
| AllocateArrayPool | 10     | 707.07 ns | 197.861 ns | 10.845 ns | 698.36 ns | 719.22 ns |         - |
