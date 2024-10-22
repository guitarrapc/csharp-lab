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
| **RentReturn**        | **1**      |  **36.17 ns** |  **1.505 ns** | **0.083 ns** |  **36.11 ns** |  **36.26 ns** |         **-** |
| AllocateArrayPool | 1      | 103.49 ns |  2.227 ns | 0.122 ns | 103.36 ns | 103.59 ns |         - |
| **RentReturn**        | **10**     | **527.84 ns** | **36.114 ns** | **1.980 ns** | **526.52 ns** | **530.12 ns** |         **-** |
| AllocateArrayPool | 10     | 713.44 ns |  7.373 ns | 0.404 ns | 713.18 ns | 713.90 ns |         - |
