```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.952 μs** |   **2.860 μs** | **0.1568 μs** |  **6.852 μs** |  **7.133 μs** |     **872 B** |
| StringFormat       | 1      |  7.202 μs |   3.681 μs | 0.2018 μs |  6.989 μs |  7.389 μs |     896 B |
| InterpolatedFormat | 1      |  5.733 μs |   4.160 μs | 0.2280 μs |  5.546 μs |  5.987 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.687 μs** | **142.595 μs** | **7.8161 μs** | **32.044 μs** | **45.711 μs** |   **14336 B** |
| StringFormat       | 100    | 36.943 μs | 127.123 μs | 6.9681 μs | 32.702 μs | 44.985 μs |   16736 B |
| InterpolatedFormat | 100    | 34.651 μs | 122.600 μs | 6.7201 μs | 30.617 μs | 42.409 μs |   14336 B |
