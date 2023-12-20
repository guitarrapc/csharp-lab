``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT
  ShortRun : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method | Number |      Mean |      Error |   StdDev |       Min |       Max | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
|        **RentReturn** |      **1** |  **38.19 ns** |   **3.392 ns** | **0.186 ns** |  **38.05 ns** |  **38.40 ns** |         **-** |
| AllocateArrayPool |      1 |  98.21 ns |   1.044 ns | 0.057 ns |  98.16 ns |  98.27 ns |         - |
|        **RentReturn** |     **10** | **553.42 ns** | **175.734 ns** | **9.633 ns** | **546.92 ns** | **564.49 ns** |         **-** |
| AllocateArrayPool |     10 | 726.44 ns |  58.966 ns | 3.232 ns | 724.03 ns | 730.12 ns |         - |
