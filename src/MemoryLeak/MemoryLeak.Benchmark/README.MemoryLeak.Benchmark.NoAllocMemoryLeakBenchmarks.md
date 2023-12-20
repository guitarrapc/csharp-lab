``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
|        **RentReturn** |      **1** |  **34.60 ns** |  **3.445 ns** | **0.189 ns** |  **34.45 ns** |  **34.81 ns** |         **-** |
| AllocateArrayPool |      1 | 100.19 ns | 10.589 ns | 0.580 ns |  99.84 ns | 100.86 ns |         - |
|        **RentReturn** |     **10** | **536.10 ns** |  **8.894 ns** | **0.487 ns** | **535.67 ns** | **536.63 ns** |         **-** |
| AllocateArrayPool |     10 | 748.94 ns | 25.826 ns | 1.416 ns | 747.94 ns | 750.56 ns |         - |
