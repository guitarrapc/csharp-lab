``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method | Number |      Mean |      Error |    StdDev |       Min |       Max | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
|        **RentReturn** |      **1** |  **39.29 ns** |   **2.552 ns** |  **0.140 ns** |  **39.15 ns** |  **39.43 ns** |         **-** |
| AllocateArrayPool |      1 | 102.23 ns |   6.957 ns |  0.381 ns | 101.99 ns | 102.67 ns |         - |
|        **RentReturn** |     **10** | **526.66 ns** | **215.308 ns** | **11.802 ns** | **516.38 ns** | **539.55 ns** |         **-** |
| AllocateArrayPool |     10 | 750.24 ns | 340.229 ns | 18.649 ns | 738.83 ns | 771.76 ns |         - |
