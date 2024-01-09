```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.32 ns** |  **2.588 ns** | **0.142 ns** |  **34.16 ns** |  **34.43 ns** |         **-** |
| AllocateArrayPool | 1      |  97.68 ns |  4.178 ns | 0.229 ns |  97.47 ns |  97.92 ns |         - |
| **RentReturn**        | **10**     | **532.43 ns** |  **4.936 ns** | **0.271 ns** | **532.13 ns** | **532.65 ns** |         **-** |
| AllocateArrayPool | 10     | 703.02 ns | 88.212 ns | 4.835 ns | 700.04 ns | 708.60 ns |         - |
