```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.56 ns** |  **2.135 ns** | **0.117 ns** |  **34.47 ns** |  **34.69 ns** |         **-** |
| AllocateArrayPool | 1      |  97.83 ns |  3.056 ns | 0.168 ns |  97.64 ns |  97.94 ns |         - |
| **RentReturn**        | **10**     | **523.23 ns** | **22.175 ns** | **1.215 ns** | **521.94 ns** | **524.36 ns** |         **-** |
| AllocateArrayPool | 10     | 695.54 ns | 49.425 ns | 2.709 ns | 692.45 ns | 697.51 ns |         - |
