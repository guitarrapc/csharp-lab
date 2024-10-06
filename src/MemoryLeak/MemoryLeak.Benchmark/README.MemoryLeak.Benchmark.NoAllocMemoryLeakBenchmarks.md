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
| **RentReturn**        | **1**      |  **39.57 ns** |   **0.378 ns** |  **0.021 ns** |  **39.55 ns** |  **39.59 ns** |         **-** |
| AllocateArrayPool | 1      |  98.23 ns |   4.257 ns |  0.233 ns |  98.07 ns |  98.50 ns |         - |
| **RentReturn**        | **10**     | **547.55 ns** | **202.006 ns** | **11.073 ns** | **535.11 ns** | **556.33 ns** |         **-** |
| AllocateArrayPool | 10     | 697.46 ns |  83.169 ns |  4.559 ns | 692.21 ns | 700.43 ns |         - |
