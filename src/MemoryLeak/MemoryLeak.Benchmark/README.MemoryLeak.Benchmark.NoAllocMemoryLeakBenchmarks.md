```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.17 ns** |  **3.250 ns** | **0.178 ns** |  **34.05 ns** |  **34.37 ns** |         **-** |
| AllocateArrayPool | 1      |  98.13 ns |  5.468 ns | 0.300 ns |  97.95 ns |  98.47 ns |         - |
| **RentReturn**        | **10**     | **524.73 ns** | **84.450 ns** | **4.629 ns** | **521.91 ns** | **530.07 ns** |         **-** |
| AllocateArrayPool | 10     | 702.58 ns | 26.287 ns | 1.441 ns | 701.18 ns | 704.06 ns |         - |
