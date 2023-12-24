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
|        **RentReturn** |      **1** |  **35.40 ns** |   **9.589 ns** |  **0.526 ns** |  **35.00 ns** |  **35.99 ns** |         **-** |
| AllocateArrayPool |      1 | 102.30 ns |   6.114 ns |  0.335 ns | 102.10 ns | 102.68 ns |         - |
|        **RentReturn** |     **10** | **515.77 ns** | **243.740 ns** | **13.360 ns** | **506.56 ns** | **531.10 ns** |         **-** |
| AllocateArrayPool |     10 | 728.57 ns |  23.678 ns |  1.298 ns | 727.11 ns | 729.60 ns |         - |
