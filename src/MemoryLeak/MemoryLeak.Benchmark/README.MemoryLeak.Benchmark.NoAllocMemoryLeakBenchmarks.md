```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method            | Number | Mean      | Error      | StdDev   | Min       | Max       | Allocated |
|------------------ |------- |----------:|-----------:|---------:|----------:|----------:|----------:|
| **RentReturn**        | **1**      |  **34.32 ns** |   **0.182 ns** | **0.010 ns** |  **34.31 ns** |  **34.33 ns** |         **-** |
| AllocateArrayPool | 1      |  99.03 ns |   3.522 ns | 0.193 ns |  98.91 ns |  99.26 ns |         - |
| **RentReturn**        | **10**     | **526.49 ns** |  **69.204 ns** | **3.793 ns** | **522.16 ns** | **529.23 ns** |         **-** |
| AllocateArrayPool | 10     | 705.83 ns | 169.481 ns | 9.290 ns | 699.47 ns | 716.49 ns |         - |
