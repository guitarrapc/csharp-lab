```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **33.15 ns** |  **0.705 ns** | **0.039 ns** |  **33.10 ns** |  **33.17 ns** |         **-** |
| AllocateArrayPool | 1      |  98.08 ns |  7.592 ns | 0.416 ns |  97.83 ns |  98.56 ns |         - |
| **RentReturn**        | **10**     | **522.14 ns** | **10.023 ns** | **0.549 ns** | **521.53 ns** | **522.59 ns** |         **-** |
| AllocateArrayPool | 10     | 710.39 ns |  9.271 ns | 0.508 ns | 709.80 ns | 710.69 ns |         - |
