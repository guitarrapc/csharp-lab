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
|        **RentReturn** |      **1** |  **35.38 ns** |  **14.442 ns** |  **0.792 ns** |  **34.46 ns** |  **35.86 ns** |         **-** |
| AllocateArrayPool |      1 | 101.03 ns |   0.195 ns |  0.011 ns | 101.01 ns | 101.04 ns |         - |
|        **RentReturn** |     **10** | **523.48 ns** |  **47.975 ns** |  **2.630 ns** | **520.46 ns** | **525.28 ns** |         **-** |
| AllocateArrayPool |     10 | 735.72 ns | 379.606 ns | 20.807 ns | 711.78 ns | 749.46 ns |         - |
