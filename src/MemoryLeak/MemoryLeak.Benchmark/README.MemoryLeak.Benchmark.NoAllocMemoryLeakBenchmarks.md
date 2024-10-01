```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.98 ns** |   **1.562 ns** |  **0.086 ns** |  **32.92 ns** |  **33.08 ns** |         **-** |
| AllocateArrayPool | 1      |  99.43 ns |   1.923 ns |  0.105 ns |  99.33 ns |  99.54 ns |         - |
| **RentReturn**        | **10**     | **530.56 ns** | **217.113 ns** | **11.901 ns** | **523.10 ns** | **544.29 ns** |         **-** |
| AllocateArrayPool | 10     | 705.58 ns |  13.783 ns |  0.756 ns | 704.72 ns | 706.15 ns |         - |
