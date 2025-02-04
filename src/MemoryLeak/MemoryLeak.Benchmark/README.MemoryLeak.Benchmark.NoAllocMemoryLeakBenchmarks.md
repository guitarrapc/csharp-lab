```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **19.26 ns** |  **0.439 ns** | **0.024 ns** |  **19.25 ns** |  **19.29 ns** |         **-** |
| AllocateArrayPool | 1      |  82.20 ns |  1.772 ns | 0.097 ns |  82.09 ns |  82.29 ns |         - |
| **RentReturn**        | **10**     | **415.86 ns** | **28.399 ns** | **1.557 ns** | **414.46 ns** | **417.54 ns** |         **-** |
| AllocateArrayPool | 10     | 576.80 ns | 21.741 ns | 1.192 ns | 575.43 ns | 577.60 ns |         - |
