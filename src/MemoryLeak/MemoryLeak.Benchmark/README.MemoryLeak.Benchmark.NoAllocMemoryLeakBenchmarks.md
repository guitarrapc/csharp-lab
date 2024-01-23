```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **36.86 ns** |   **3.351 ns** | **0.184 ns** |  **36.67 ns** |  **37.03 ns** |         **-** |
| AllocateArrayPool | 1      |  97.32 ns |   1.114 ns | 0.061 ns |  97.27 ns |  97.39 ns |         - |
| **RentReturn**        | **10**     | **538.52 ns** | **159.456 ns** | **8.740 ns** | **528.43 ns** | **543.85 ns** |         **-** |
| AllocateArrayPool | 10     | 703.48 ns |  37.047 ns | 2.031 ns | 702.23 ns | 705.83 ns |         - |
