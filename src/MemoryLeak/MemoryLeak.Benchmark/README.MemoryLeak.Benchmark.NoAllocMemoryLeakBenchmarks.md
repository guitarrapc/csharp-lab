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
| **RentReturn**        | **1**      |  **36.03 ns** |  **0.848 ns** | **0.046 ns** |  **35.99 ns** |  **36.08 ns** |         **-** |
| AllocateArrayPool | 1      | 103.38 ns |  3.399 ns | 0.186 ns | 103.27 ns | 103.59 ns |         - |
| **RentReturn**        | **10**     | **530.55 ns** | **22.621 ns** | **1.240 ns** | **529.13 ns** | **531.37 ns** |         **-** |
| AllocateArrayPool | 10     | 715.39 ns | 20.881 ns | 1.145 ns | 714.38 ns | 716.63 ns |         - |
