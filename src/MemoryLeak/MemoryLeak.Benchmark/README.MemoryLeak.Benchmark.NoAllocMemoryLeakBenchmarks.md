```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.83 ns** |   **1.826 ns** | **0.100 ns** |  **34.75 ns** |  **34.94 ns** |         **-** |
| AllocateArrayPool | 1      | 101.66 ns |  15.186 ns | 0.832 ns | 100.96 ns | 102.58 ns |         - |
| **RentReturn**        | **10**     | **534.51 ns** | **104.952 ns** | **5.753 ns** | **528.21 ns** | **539.48 ns** |         **-** |
| AllocateArrayPool | 10     | 698.75 ns |  46.675 ns | 2.558 ns | 697.14 ns | 701.70 ns |         - |
