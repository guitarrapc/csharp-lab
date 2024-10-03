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
| **RentReturn**        | **1**      |  **32.75 ns** |  **0.515 ns** | **0.028 ns** |  **32.72 ns** |  **32.78 ns** |         **-** |
| AllocateArrayPool | 1      |  98.79 ns | 11.271 ns | 0.618 ns |  98.39 ns |  99.51 ns |         - |
| **RentReturn**        | **10**     | **523.46 ns** |  **7.279 ns** | **0.399 ns** | **523.01 ns** | **523.78 ns** |         **-** |
| AllocateArrayPool | 10     | 710.85 ns | 56.902 ns | 3.119 ns | 707.55 ns | 713.76 ns |         - |
