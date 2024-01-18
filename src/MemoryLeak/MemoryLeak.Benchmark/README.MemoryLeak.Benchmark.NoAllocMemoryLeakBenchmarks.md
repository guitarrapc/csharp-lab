```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.56 ns** |   **0.790 ns** |  **0.043 ns** |  **34.51 ns** |  **34.59 ns** |         **-** |
| AllocateArrayPool | 1      |  97.10 ns |   0.547 ns |  0.030 ns |  97.07 ns |  97.13 ns |         - |
| **RentReturn**        | **10**     | **540.00 ns** | **270.161 ns** | **14.808 ns** | **531.03 ns** | **557.09 ns** |         **-** |
| AllocateArrayPool | 10     | 716.84 ns | 339.445 ns | 18.606 ns | 705.86 ns | 738.33 ns |         - |
