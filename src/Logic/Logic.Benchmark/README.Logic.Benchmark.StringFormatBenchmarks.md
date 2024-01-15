```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.907 μs** |  **35.881 μs** |  **1.9668 μs** |  **5.761 μs** |  **9.178 μs** |     **872 B** |
| StringFormat       | 1      |  6.713 μs |  12.544 μs |  0.6876 μs |  6.202 μs |  7.495 μs |     896 B |
| InterpolatedFormat | 1      |  5.547 μs |   3.065 μs |  0.1680 μs |  5.441 μs |  5.741 μs |     872 B |
| **CompositeFormat**    | **100**    | **52.456 μs** | **228.614 μs** | **12.5311 μs** | **44.489 μs** | **66.900 μs** |   **14336 B** |
| StringFormat       | 100    | 53.190 μs | 294.849 μs | 16.1617 μs | 42.039 μs | 71.725 μs |   16736 B |
| InterpolatedFormat | 100    | 35.546 μs | 127.129 μs |  6.9684 μs | 31.158 μs | 43.581 μs |   14336 B |
