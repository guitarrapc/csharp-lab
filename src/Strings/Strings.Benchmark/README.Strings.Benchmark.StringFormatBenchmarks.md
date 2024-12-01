```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.095 μs** |   **5.119 μs** | **0.2806 μs** |  **5.811 μs** |  **6.372 μs** |     **872 B** |
| StringFormat       | 1      |  6.812 μs |   8.844 μs | 0.4848 μs |  6.261 μs |  7.173 μs |     896 B |
| InterpolatedFormat | 1      |  5.994 μs |   1.728 μs | 0.0947 μs |  5.921 μs |  6.101 μs |     872 B |
| **CompositeFormat**    | **100**    | **40.382 μs** | **122.967 μs** | **6.7402 μs** | **32.661 μs** | **45.093 μs** |   **14336 B** |
| StringFormat       | 100    | 37.803 μs | 133.606 μs | 7.3234 μs | 33.351 μs | 46.255 μs |   16736 B |
| InterpolatedFormat | 100    | 35.553 μs | 115.135 μs | 6.3109 μs | 31.830 μs | 42.840 μs |   14336 B |
