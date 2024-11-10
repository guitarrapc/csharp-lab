```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.04 ns** |  **1.067 ns** | **0.058 ns** |  **35.99 ns** |  **36.10 ns** |         **-** |
| AllocateArrayPool | 1      | 102.39 ns |  2.719 ns | 0.149 ns | 102.22 ns | 102.50 ns |         - |
| **RentReturn**        | **10**     | **521.10 ns** |  **6.657 ns** | **0.365 ns** | **520.88 ns** | **521.52 ns** |         **-** |
| AllocateArrayPool | 10     | 730.29 ns | 12.799 ns | 0.702 ns | 729.53 ns | 730.92 ns |         - |
