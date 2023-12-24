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
|        **RentReturn** |      **1** |  **34.51 ns** |  **1.348 ns** | **0.074 ns** |  **34.47 ns** |  **34.60 ns** |         **-** |
| AllocateArrayPool |      1 |  99.97 ns |  3.127 ns | 0.171 ns |  99.81 ns | 100.15 ns |         - |
|        **RentReturn** |     **10** | **617.35 ns** |  **5.175 ns** | **0.284 ns** | **617.05 ns** | **617.61 ns** |         **-** |
| AllocateArrayPool |     10 | 709.45 ns | 75.242 ns | 4.124 ns | 705.61 ns | 713.81 ns |         - |
