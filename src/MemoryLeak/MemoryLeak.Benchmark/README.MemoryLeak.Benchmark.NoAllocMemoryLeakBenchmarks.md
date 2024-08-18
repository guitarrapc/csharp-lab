```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.17 ns** |   **3.404 ns** | **0.187 ns** |  **34.01 ns** |  **34.37 ns** |         **-** |
| AllocateArrayPool | 1      | 100.04 ns |  16.743 ns | 0.918 ns |  99.05 ns | 100.86 ns |         - |
| **RentReturn**        | **10**     | **517.41 ns** |  **74.659 ns** | **4.092 ns** | **513.01 ns** | **521.09 ns** |         **-** |
| AllocateArrayPool | 10     | 715.99 ns | 164.417 ns | 9.012 ns | 707.58 ns | 725.50 ns |         - |
