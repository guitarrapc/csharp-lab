```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.10 ns** |  **18.510 ns** | **1.015 ns** |  **34.50 ns** |  **36.27 ns** |         **-** |
| AllocateArrayPool | 1      | 100.99 ns |   2.614 ns | 0.143 ns | 100.87 ns | 101.15 ns |         - |
| **RentReturn**        | **10**     | **534.14 ns** | **122.211 ns** | **6.699 ns** | **529.63 ns** | **541.84 ns** |         **-** |
| AllocateArrayPool | 10     | 703.69 ns |  27.201 ns | 1.491 ns | 702.68 ns | 705.40 ns |         - |
