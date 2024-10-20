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
| **RentReturn**        | **1**      |  **36.79 ns** |  **1.257 ns** | **0.069 ns** |  **36.75 ns** |  **36.87 ns** |         **-** |
| AllocateArrayPool | 1      | 103.68 ns |  2.416 ns | 0.132 ns | 103.55 ns | 103.82 ns |         - |
| **RentReturn**        | **10**     | **530.31 ns** | **47.726 ns** | **2.616 ns** | **527.29 ns** | **531.85 ns** |         **-** |
| AllocateArrayPool | 10     | 817.41 ns |  6.324 ns | 0.347 ns | 817.11 ns | 817.79 ns |         - |
