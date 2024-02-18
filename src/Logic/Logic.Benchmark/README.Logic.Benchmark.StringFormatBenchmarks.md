```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.037 μs** |   **4.338 μs** |  **0.2378 μs** |  **5.881 μs** |  **6.311 μs** |     **872 B** |
| StringFormat       | 1      |  7.303 μs |  11.200 μs |  0.6139 μs |  6.622 μs |  7.814 μs |     896 B |
| InterpolatedFormat | 1      |  5.901 μs |   1.567 μs |  0.0859 μs |  5.820 μs |  5.991 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.598 μs** | **192.702 μs** | **10.5627 μs** | **32.470 μs** | **50.795 μs** |   **14336 B** |
| StringFormat       | 100    | 38.425 μs | 127.118 μs |  6.9678 μs | 34.184 μs | 46.467 μs |   16736 B |
| InterpolatedFormat | 100    | 36.796 μs | 210.121 μs | 11.5174 μs | 30.016 μs | 50.094 μs |   14336 B |
