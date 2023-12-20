``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method | Number |      Mean |      Error |   StdDev |       Min |       Max | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
|        **RentReturn** |      **1** |  **34.95 ns** |   **1.934 ns** | **0.106 ns** |  **34.83 ns** |  **35.02 ns** |         **-** |
| AllocateArrayPool |      1 | 101.48 ns |  26.746 ns | 1.466 ns |  99.79 ns | 102.35 ns |         - |
|        **RentReturn** |     **10** | **515.30 ns** | **124.396 ns** | **6.819 ns** | **511.00 ns** | **523.16 ns** |         **-** |
| AllocateArrayPool |     10 | 819.78 ns |  50.354 ns | 2.760 ns | 816.71 ns | 822.05 ns |         - |
