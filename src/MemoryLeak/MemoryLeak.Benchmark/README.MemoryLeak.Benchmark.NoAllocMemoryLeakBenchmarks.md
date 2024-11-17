```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.69 ns** |  **0.597 ns** | **0.033 ns** |  **32.65 ns** |  **32.71 ns** |         **-** |
| AllocateArrayPool | 1      |  98.19 ns |  5.069 ns | 0.278 ns |  97.88 ns |  98.42 ns |         - |
| **RentReturn**        | **10**     | **527.54 ns** |  **7.614 ns** | **0.417 ns** | **527.14 ns** | **527.97 ns** |         **-** |
| AllocateArrayPool | 10     | 698.69 ns | 18.119 ns | 0.993 ns | 697.91 ns | 699.81 ns |         - |
