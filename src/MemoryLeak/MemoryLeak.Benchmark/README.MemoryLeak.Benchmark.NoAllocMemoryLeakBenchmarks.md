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
| **RentReturn**        | **1**      |  **34.26 ns** |   **2.584 ns** | **0.142 ns** |  **34.15 ns** |  **34.42 ns** |         **-** |
| AllocateArrayPool | 1      |  97.18 ns |   0.504 ns | 0.028 ns |  97.15 ns |  97.21 ns |         - |
| **RentReturn**        | **10**     | **531.36 ns** | **174.690 ns** | **9.575 ns** | **525.62 ns** | **542.41 ns** |         **-** |
| AllocateArrayPool | 10     | 711.22 ns |  50.707 ns | 2.779 ns | 708.08 ns | 713.37 ns |         - |
