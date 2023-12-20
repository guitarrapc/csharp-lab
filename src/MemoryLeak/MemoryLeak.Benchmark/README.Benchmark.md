``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT
  ShortRun : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
|        **RentReturn** |      **1** |  **37.98 ns** |  **0.363 ns** | **0.020 ns** |  **37.96 ns** |  **38.00 ns** |         **-** |
| AllocateArrayPool |      1 |  98.70 ns |  0.543 ns | 0.030 ns |  98.68 ns |  98.73 ns |         - |
|        **RentReturn** |     **10** | **552.83 ns** |  **9.531 ns** | **0.522 ns** | **552.49 ns** | **553.43 ns** |         **-** |
| AllocateArrayPool |     10 | 723.19 ns | 63.264 ns | 3.468 ns | 721.12 ns | 727.19 ns |         - |
