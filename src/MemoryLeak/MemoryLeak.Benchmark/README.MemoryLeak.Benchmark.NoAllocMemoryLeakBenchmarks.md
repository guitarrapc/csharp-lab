```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **32.78 ns** |  **1.470 ns** | **0.081 ns** |  **32.72 ns** |  **32.87 ns** |         **-** |
| AllocateArrayPool | 1      |  98.55 ns |  3.213 ns | 0.176 ns |  98.36 ns |  98.71 ns |         - |
| **RentReturn**        | **10**     | **540.83 ns** | **20.386 ns** | **1.117 ns** | **539.70 ns** | **541.93 ns** |         **-** |
| AllocateArrayPool | 10     | 703.33 ns | 17.437 ns | 0.956 ns | 702.77 ns | 704.43 ns |         - |
