```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.10 ns** |   **0.632 ns** | **0.035 ns** |  **35.06 ns** |  **35.13 ns** |         **-** |
| AllocateArrayPool | 1      |  97.67 ns |   1.637 ns | 0.090 ns |  97.62 ns |  97.78 ns |         - |
| **RentReturn**        | **10**     | **513.92 ns** |  **31.467 ns** | **1.725 ns** | **512.35 ns** | **515.77 ns** |         **-** |
| AllocateArrayPool | 10     | 704.85 ns | 112.483 ns | 6.166 ns | 700.53 ns | 711.91 ns |         - |
