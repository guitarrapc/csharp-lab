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
| **RentReturn**        | **1**      |  **36.31 ns** |  **0.351 ns** | **0.019 ns** |  **36.29 ns** |  **36.32 ns** |         **-** |
| AllocateArrayPool | 1      | 102.54 ns |  8.155 ns | 0.447 ns | 102.09 ns | 102.99 ns |         - |
| **RentReturn**        | **10**     | **531.78 ns** | **31.576 ns** | **1.731 ns** | **530.78 ns** | **533.78 ns** |         **-** |
| AllocateArrayPool | 10     | 714.57 ns | 22.257 ns | 1.220 ns | 713.27 ns | 715.69 ns |         - |
