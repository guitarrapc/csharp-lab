```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.11 ns** |   **0.292 ns** | **0.016 ns** |  **34.10 ns** |  **34.12 ns** |         **-** |
| AllocateArrayPool | 1      |  97.88 ns |   0.595 ns | 0.033 ns |  97.85 ns |  97.92 ns |         - |
| **RentReturn**        | **10**     | **530.10 ns** |  **14.915 ns** | **0.818 ns** | **529.36 ns** | **530.98 ns** |         **-** |
| AllocateArrayPool | 10     | 713.35 ns | 118.724 ns | 6.508 ns | 709.58 ns | 720.86 ns |         - |
