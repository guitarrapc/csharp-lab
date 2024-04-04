```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.36 ns** |   **0.956 ns** | **0.052 ns** |  **34.32 ns** |  **34.42 ns** |         **-** |
| AllocateArrayPool | 1      |  97.79 ns |   4.580 ns | 0.251 ns |  97.50 ns |  97.96 ns |         - |
| **RentReturn**        | **10**     | **530.11 ns** | **139.766 ns** | **7.661 ns** | **521.27 ns** | **534.79 ns** |         **-** |
| AllocateArrayPool | 10     | 700.66 ns |  29.293 ns | 1.606 ns | 698.82 ns | 701.81 ns |         - |
