```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **35.15 ns** |  **4.069 ns** | **0.223 ns** |  **34.98 ns** |  **35.40 ns** |         **-** |
| AllocateArrayPool | 1      | 106.88 ns | 41.911 ns | 2.297 ns | 104.23 ns | 108.25 ns |         - |
| **RentReturn**        | **10**     | **536.93 ns** | **40.102 ns** | **2.198 ns** | **535.54 ns** | **539.46 ns** |         **-** |
| AllocateArrayPool | 10     | 703.25 ns | 54.824 ns | 3.005 ns | 701.22 ns | 706.70 ns |         - |
