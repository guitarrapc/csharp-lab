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
|        **RentReturn** |      **1** |  **34.92 ns** |   **2.783 ns** |  **0.153 ns** |  **34.83 ns** |  **35.10 ns** |         **-** |
| AllocateArrayPool |      1 | 100.77 ns |   1.725 ns |  0.095 ns | 100.68 ns | 100.87 ns |         - |
|        **RentReturn** |     **10** | **526.82 ns** | **215.605 ns** | **11.818 ns** | **518.28 ns** | **540.31 ns** |         **-** |
| AllocateArrayPool |     10 | 711.11 ns |  64.646 ns |  3.543 ns | 708.15 ns | 715.04 ns |         - |
