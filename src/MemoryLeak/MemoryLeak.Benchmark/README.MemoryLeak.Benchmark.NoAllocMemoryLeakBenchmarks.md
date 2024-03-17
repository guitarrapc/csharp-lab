```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.17 ns** |  **1.210 ns** | **0.066 ns** |  **35.10 ns** |  **35.23 ns** |         **-** |
| AllocateArrayPool | 1      | 100.13 ns |  2.589 ns | 0.142 ns |  99.98 ns | 100.26 ns |         - |
| **RentReturn**        | **10**     | **555.25 ns** | **68.825 ns** | **3.773 ns** | **552.26 ns** | **559.49 ns** |         **-** |
| AllocateArrayPool | 10     | 700.65 ns |  1.677 ns | 0.092 ns | 700.58 ns | 700.76 ns |         - |
