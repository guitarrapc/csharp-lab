```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **33.62 ns** |  **1.026 ns** | **0.056 ns** |  **33.55 ns** |  **33.65 ns** |         **-** |
| AllocateArrayPool | 1      |  98.47 ns |  3.306 ns | 0.181 ns |  98.27 ns |  98.62 ns |         - |
| **RentReturn**        | **10**     | **522.90 ns** | **27.397 ns** | **1.502 ns** | **521.58 ns** | **524.53 ns** |         **-** |
| AllocateArrayPool | 10     | 703.87 ns |  6.940 ns | 0.380 ns | 703.53 ns | 704.28 ns |         - |
