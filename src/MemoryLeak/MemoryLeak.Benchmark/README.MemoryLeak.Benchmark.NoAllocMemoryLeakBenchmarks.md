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
| **RentReturn**        | **1**      |  **34.43 ns** |  **1.139 ns** | **0.062 ns** |  **34.39 ns** |  **34.50 ns** |         **-** |
| AllocateArrayPool | 1      |  98.26 ns |  9.465 ns | 0.519 ns |  97.94 ns |  98.86 ns |         - |
| **RentReturn**        | **10**     | **516.55 ns** | **59.250 ns** | **3.248 ns** | **512.88 ns** | **519.05 ns** |         **-** |
| AllocateArrayPool | 10     | 703.43 ns | 55.176 ns | 3.024 ns | 699.97 ns | 705.55 ns |         - |
