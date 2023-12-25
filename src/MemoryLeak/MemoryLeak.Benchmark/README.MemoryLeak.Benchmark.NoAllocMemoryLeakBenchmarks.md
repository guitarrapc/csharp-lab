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
|        **RentReturn** |      **1** |  **34.58 ns** |  **2.200 ns** | **0.121 ns** |  **34.48 ns** |  **34.72 ns** |         **-** |
| AllocateArrayPool |      1 | 100.65 ns |  3.446 ns | 0.189 ns | 100.45 ns | 100.82 ns |         - |
|        **RentReturn** |     **10** | **517.63 ns** |  **2.835 ns** | **0.155 ns** | **517.46 ns** | **517.75 ns** |         **-** |
| AllocateArrayPool |     10 | 701.66 ns | 10.636 ns | 0.583 ns | 701.06 ns | 702.23 ns |         - |
