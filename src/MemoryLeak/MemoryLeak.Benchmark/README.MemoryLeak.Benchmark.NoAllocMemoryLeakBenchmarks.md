```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.51 ns** |  **4.398 ns** | **0.241 ns** |  **32.34 ns** |  **32.78 ns** |         **-** |
| AllocateArrayPool | 1      |  97.51 ns |  9.706 ns | 0.532 ns |  96.95 ns |  98.01 ns |         - |
| **RentReturn**        | **10**     | **532.60 ns** | **17.217 ns** | **0.944 ns** | **531.52 ns** | **533.17 ns** |         **-** |
| AllocateArrayPool | 10     | 698.67 ns | 39.507 ns | 2.165 ns | 697.10 ns | 701.14 ns |         - |
