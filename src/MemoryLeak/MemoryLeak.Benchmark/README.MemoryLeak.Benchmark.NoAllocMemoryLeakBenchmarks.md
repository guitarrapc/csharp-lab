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
| **RentReturn**        | **1**      |  **35.92 ns** |  **4.867 ns** | **0.267 ns** |  **35.71 ns** |  **36.22 ns** |         **-** |
| AllocateArrayPool | 1      | 111.92 ns |  1.249 ns | 0.068 ns | 111.84 ns | 111.97 ns |         - |
| **RentReturn**        | **10**     | **532.13 ns** | **23.498 ns** | **1.288 ns** | **530.70 ns** | **533.19 ns** |         **-** |
| AllocateArrayPool | 10     | 724.24 ns | 57.800 ns | 3.168 ns | 721.92 ns | 727.85 ns |         - |
