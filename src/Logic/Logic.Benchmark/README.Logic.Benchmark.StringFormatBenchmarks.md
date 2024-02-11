```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.826 μs** |   **7.5331 μs** |  **0.4129 μs** |  **6.362 μs** |  **7.153 μs** |     **872 B** |
| StringFormat       | 1      |  6.462 μs |   0.3109 μs |  0.0170 μs |  6.442 μs |  6.472 μs |     896 B |
| InterpolatedFormat | 1      |  6.472 μs |   5.8891 μs |  0.3228 μs |  6.131 μs |  6.773 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.896 μs** | **218.0788 μs** | **11.9536 μs** | **42.889 μs** | **63.698 μs** |   **14336 B** |
| StringFormat       | 100    | 52.692 μs | 250.6857 μs | 13.7409 μs | 44.634 μs | 68.558 μs |   16736 B |
| InterpolatedFormat | 100    | 35.019 μs | 156.7216 μs |  8.5904 μs | 29.806 μs | 44.934 μs |   14336 B |
