```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.011 μs** |   **2.737 μs** | **0.1500 μs** |  **5.861 μs** |  **6.161 μs** |     **872 B** |
| StringFormat       | 1      |  7.147 μs |   5.891 μs | 0.3229 μs |  6.793 μs |  7.425 μs |     896 B |
| InterpolatedFormat | 1      |  6.821 μs |   5.875 μs | 0.3220 μs |  6.468 μs |  7.098 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.426 μs** | **121.072 μs** | **6.6364 μs** | **32.341 μs** | **44.083 μs** |   **14336 B** |
| StringFormat       | 100    | 38.128 μs | 121.780 μs | 6.6752 μs | 34.234 μs | 45.836 μs |   16736 B |
| InterpolatedFormat | 100    | 37.475 μs | 165.575 μs | 9.0757 μs | 32.156 μs | 47.955 μs |   14336 B |
