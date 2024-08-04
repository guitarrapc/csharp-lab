```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.22 ns** |  **0.718 ns** | **0.039 ns** |  **34.18 ns** |  **34.25 ns** |         **-** |
| AllocateArrayPool | 1      |  99.33 ns |  2.883 ns | 0.158 ns |  99.19 ns |  99.50 ns |         - |
| **RentReturn**        | **10**     | **519.47 ns** | **30.238 ns** | **1.657 ns** | **518.29 ns** | **521.36 ns** |         **-** |
| AllocateArrayPool | 10     | 704.06 ns | 17.144 ns | 0.940 ns | 703.36 ns | 705.13 ns |         - |
