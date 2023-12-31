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
| **RentReturn**        | **1**      |  **34.33 ns** |  **0.138 ns** | **0.008 ns** |  **34.32 ns** |  **34.33 ns** |         **-** |
| AllocateArrayPool | 1      |  98.16 ns | 12.278 ns | 0.673 ns |  97.75 ns |  98.94 ns |         - |
| **RentReturn**        | **10**     | **518.91 ns** | **49.342 ns** | **2.705 ns** | **517.23 ns** | **522.03 ns** |         **-** |
| AllocateArrayPool | 10     | 707.79 ns | 86.322 ns | 4.732 ns | 704.19 ns | 713.15 ns |         - |
