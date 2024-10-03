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
| **RentReturn**        | **1**      |  **34.30 ns** |  **0.666 ns** | **0.037 ns** |  **34.26 ns** |  **34.33 ns** |         **-** |
| AllocateArrayPool | 1      |  99.70 ns |  4.633 ns | 0.254 ns |  99.48 ns |  99.97 ns |         - |
| **RentReturn**        | **10**     | **529.65 ns** | **84.445 ns** | **4.629 ns** | **526.06 ns** | **534.87 ns** |         **-** |
| AllocateArrayPool | 10     | 799.56 ns | 72.186 ns | 3.957 ns | 795.07 ns | 802.53 ns |         - |
