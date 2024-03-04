```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.825 μs** |   **4.239 μs** |  **0.2324 μs** |  **5.671 μs** |  **6.092 μs** |     **872 B** |
| StringFormat       | 1      |  5.985 μs |   1.304 μs |  0.0715 μs |  5.921 μs |  6.062 μs |     896 B |
| InterpolatedFormat | 1      |  5.529 μs |   7.287 μs |  0.3995 μs |  5.279 μs |  5.990 μs |     872 B |
| **CompositeFormat**    | **100**    | **32.847 μs** | **116.872 μs** |  **6.4062 μs** | **29.103 μs** | **40.244 μs** |   **14336 B** |
| StringFormat       | 100    | 48.657 μs | 201.757 μs | 11.0590 μs | 40.455 μs | 61.234 μs |   16736 B |
| InterpolatedFormat | 100    | 32.596 μs | 124.644 μs |  6.8322 μs | 27.697 μs | 40.401 μs |   14336 B |
