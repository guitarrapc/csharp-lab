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
| **RentReturn**        | **1**      |  **34.88 ns** |  **1.091 ns** | **0.060 ns** |  **34.81 ns** |  **34.93 ns** |         **-** |
| AllocateArrayPool | 1      |  97.65 ns |  7.064 ns | 0.387 ns |  97.32 ns |  98.08 ns |         - |
| **RentReturn**        | **10**     | **516.24 ns** | **55.767 ns** | **3.057 ns** | **514.08 ns** | **519.74 ns** |         **-** |
| AllocateArrayPool | 10     | 704.33 ns |  8.833 ns | 0.484 ns | 703.77 ns | 704.64 ns |         - |
