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
| **RentReturn**        | **1**      |  **33.48 ns** |   **0.719 ns** | **0.039 ns** |  **33.46 ns** |  **33.53 ns** |         **-** |
| AllocateArrayPool | 1      |  98.96 ns |   3.453 ns | 0.189 ns |  98.74 ns |  99.08 ns |         - |
| **RentReturn**        | **10**     | **537.40 ns** | **174.340 ns** | **9.556 ns** | **528.89 ns** | **547.74 ns** |         **-** |
| AllocateArrayPool | 10     | 710.63 ns |  51.236 ns | 2.808 ns | 707.44 ns | 712.72 ns |         - |
