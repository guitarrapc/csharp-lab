```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error    | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|---------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.44 ns** | **0.938 ns** | **0.051 ns** |  **34.38 ns** |  **34.48 ns** |         **-** |
| AllocateArrayPool | 1      |  98.45 ns | 0.586 ns | 0.032 ns |  98.41 ns |  98.48 ns |         - |
| **RentReturn**        | **10**     | **517.92 ns** | **5.038 ns** | **0.276 ns** | **517.70 ns** | **518.23 ns** |         **-** |
| AllocateArrayPool | 10     | 704.02 ns | 9.610 ns | 0.527 ns | 703.56 ns | 704.59 ns |         - |
