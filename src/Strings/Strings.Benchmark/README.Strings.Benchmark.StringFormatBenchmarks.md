```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.821 μs** |   **9.5106 μs** |  **0.5213 μs** |  **5.800 μs** |  **5.310 μs** |  **6.352 μs** |     **872 B** |
| StringFormat       | 1      |  5.698 μs |   0.3798 μs |  0.0208 μs |  5.691 μs |  5.681 μs |  5.721 μs |     896 B |
| InterpolatedFormat | 1      |  5.297 μs |   1.3604 μs |  0.0746 μs |  5.301 μs |  5.221 μs |  5.370 μs |     872 B |
| **CompositeFormat**    | **100**    | **44.121 μs** | **215.2560 μs** | **11.7989 μs** | **37.505 μs** | **37.114 μs** | **57.743 μs** |   **14336 B** |
| StringFormat       | 100    | 37.746 μs | 151.0316 μs |  8.2786 μs | 42.374 μs | 28.189 μs | 42.675 μs |   16448 B |
| InterpolatedFormat | 100    | 32.454 μs | 219.6792 μs | 12.0414 μs | 25.698 μs | 25.307 μs | 46.356 μs |   14336 B |
