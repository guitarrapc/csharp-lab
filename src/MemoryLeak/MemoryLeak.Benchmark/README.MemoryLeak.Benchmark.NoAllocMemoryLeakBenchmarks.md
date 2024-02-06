```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.65 ns** |   **1.008 ns** | **0.055 ns** |  **35.58 ns** |  **35.68 ns** |         **-** |
| AllocateArrayPool | 1      |  98.53 ns |   4.847 ns | 0.266 ns |  98.28 ns |  98.81 ns |         - |
| **RentReturn**        | **10**     | **558.18 ns** | **131.043 ns** | **7.183 ns** | **553.34 ns** | **566.43 ns** |         **-** |
| AllocateArrayPool | 10     | 699.42 ns |  14.019 ns | 0.768 ns | 698.61 ns | 700.14 ns |         - |
