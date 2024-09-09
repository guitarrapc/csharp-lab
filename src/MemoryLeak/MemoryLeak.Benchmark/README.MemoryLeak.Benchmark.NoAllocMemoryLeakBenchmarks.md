```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.26 ns** |  **1.132 ns** | **0.062 ns** |  **34.19 ns** |  **34.32 ns** |         **-** |
| AllocateArrayPool | 1      |  98.33 ns | 15.119 ns | 0.829 ns |  97.78 ns |  99.29 ns |         - |
| **RentReturn**        | **10**     | **530.17 ns** |  **4.906 ns** | **0.269 ns** | **529.86 ns** | **530.38 ns** |         **-** |
| AllocateArrayPool | 10     | 700.42 ns | 31.356 ns | 1.719 ns | 699.33 ns | 702.40 ns |         - |
