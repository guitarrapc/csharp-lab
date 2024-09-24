```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.77 ns** |  **0.829 ns** | **0.045 ns** |  **34.73 ns** |  **34.82 ns** |         **-** |
| AllocateArrayPool | 1      | 100.41 ns | 14.417 ns | 0.790 ns |  99.50 ns | 100.94 ns |         - |
| **RentReturn**        | **10**     | **513.73 ns** | **12.748 ns** | **0.699 ns** | **513.18 ns** | **514.52 ns** |         **-** |
| AllocateArrayPool | 10     | 715.32 ns | 22.462 ns | 1.231 ns | 714.15 ns | 716.61 ns |         - |
