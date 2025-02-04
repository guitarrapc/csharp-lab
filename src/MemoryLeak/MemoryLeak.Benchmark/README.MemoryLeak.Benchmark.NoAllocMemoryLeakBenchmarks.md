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
| **RentReturn**        | **1**      |  **19.36 ns** |  **0.718 ns** | **0.039 ns** |  **19.32 ns** |  **19.40 ns** |         **-** |
| AllocateArrayPool | 1      |  82.47 ns |  3.430 ns | 0.188 ns |  82.25 ns |  82.58 ns |         - |
| **RentReturn**        | **10**     | **426.01 ns** | **17.226 ns** | **0.944 ns** | **425.33 ns** | **427.09 ns** |         **-** |
| AllocateArrayPool | 10     | 583.54 ns | 38.882 ns | 2.131 ns | 581.85 ns | 585.94 ns |         - |
