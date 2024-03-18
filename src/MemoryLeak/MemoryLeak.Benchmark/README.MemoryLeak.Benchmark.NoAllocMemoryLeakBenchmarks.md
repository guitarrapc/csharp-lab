```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error     | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.26 ns** |  **3.771 ns** | **0.207 ns** |  **34.03 ns** |  **34.42 ns** |         **-** |
| AllocateArrayPool | 1      |  98.28 ns |  1.657 ns | 0.091 ns |  98.23 ns |  98.39 ns |         - |
| **RentReturn**        | **10**     | **524.73 ns** | **36.208 ns** | **1.985 ns** | **523.01 ns** | **526.90 ns** |         **-** |
| AllocateArrayPool | 10     | 701.64 ns |  3.743 ns | 0.205 ns | 701.42 ns | 701.83 ns |         - |
