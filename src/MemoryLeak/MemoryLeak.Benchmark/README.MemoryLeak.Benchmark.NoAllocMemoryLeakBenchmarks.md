```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.96 ns** |   **1.520 ns** |  **0.083 ns** |  **36.89 ns** |  **37.05 ns** |         **-** |
| AllocateArrayPool | 1      |  98.53 ns |   5.435 ns |  0.298 ns |  98.21 ns |  98.79 ns |         - |
| **RentReturn**        | **10**     | **519.49 ns** |  **46.466 ns** |  **2.547 ns** | **516.69 ns** | **521.68 ns** |         **-** |
| AllocateArrayPool | 10     | 710.53 ns | 195.225 ns | 10.701 ns | 704.28 ns | 722.89 ns |         - |
