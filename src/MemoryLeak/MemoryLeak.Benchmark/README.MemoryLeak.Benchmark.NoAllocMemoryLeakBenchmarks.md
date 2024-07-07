```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **37.69 ns** |  **4.124 ns** | **0.226 ns** |  **37.43 ns** |  **37.85 ns** |         **-** |
| AllocateArrayPool | 1      |  98.22 ns |  4.137 ns | 0.227 ns |  98.06 ns |  98.48 ns |         - |
| **RentReturn**        | **10**     | **521.52 ns** | **12.410 ns** | **0.680 ns** | **520.78 ns** | **522.11 ns** |         **-** |
| AllocateArrayPool | 10     | 709.98 ns | 77.047 ns | 4.223 ns | 705.25 ns | 713.38 ns |         - |
