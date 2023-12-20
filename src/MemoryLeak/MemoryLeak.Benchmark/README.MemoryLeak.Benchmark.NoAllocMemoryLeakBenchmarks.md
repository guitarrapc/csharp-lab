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
|        **RentReturn** |      **1** |  **34.40 ns** |   **0.857 ns** |  **0.047 ns** |  **34.35 ns** |  **34.44 ns** |         **-** |
| AllocateArrayPool |      1 |  99.84 ns |   0.467 ns |  0.026 ns |  99.81 ns |  99.86 ns |         - |
|        **RentReturn** |     **10** | **527.02 ns** |   **2.091 ns** |  **0.115 ns** | **526.89 ns** | **527.11 ns** |         **-** |
| AllocateArrayPool |     10 | 711.59 ns | 231.037 ns | 12.664 ns | 703.70 ns | 726.19 ns |         - |
