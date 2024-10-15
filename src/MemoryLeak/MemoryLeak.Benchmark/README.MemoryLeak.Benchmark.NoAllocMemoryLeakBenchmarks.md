```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.80 ns** |   **3.289 ns** | **0.180 ns** |  **36.69 ns** |  **37.01 ns** |         **-** |
| AllocateArrayPool | 1      | 102.10 ns |   0.374 ns | 0.021 ns | 102.08 ns | 102.12 ns |         - |
| **RentReturn**        | **10**     | **537.19 ns** |   **2.949 ns** | **0.162 ns** | **537.03 ns** | **537.35 ns** |         **-** |
| AllocateArrayPool | 10     | 728.49 ns | 139.263 ns | 7.633 ns | 723.58 ns | 737.28 ns |         - |
