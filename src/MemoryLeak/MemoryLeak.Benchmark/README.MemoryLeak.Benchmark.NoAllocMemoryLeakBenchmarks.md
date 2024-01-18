```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.23 ns** |  **3.001 ns** | **0.164 ns** |  **34.14 ns** |  **34.42 ns** |         **-** |
| AllocateArrayPool | 1      |  97.33 ns |  1.899 ns | 0.104 ns |  97.22 ns |  97.42 ns |         - |
| **RentReturn**        | **10**     | **525.32 ns** | **31.353 ns** | **1.719 ns** | **523.91 ns** | **527.23 ns** |         **-** |
| AllocateArrayPool | 10     | 705.29 ns | 52.048 ns | 2.853 ns | 702.34 ns | 708.04 ns |         - |
