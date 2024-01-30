```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **7.120 μs** |  **13.270 μs** |  **0.7274 μs** |  **7.495 μs** |  **6.282 μs** |  **7.583 μs** |     **872 B** |
| StringFormat       | 1      |  6.380 μs |   2.252 μs |  0.1234 μs |  6.346 μs |  6.277 μs |  6.516 μs |     896 B |
| InterpolatedFormat | 1      |  5.834 μs |   2.187 μs |  0.1199 μs |  5.780 μs |  5.750 μs |  5.971 μs |     872 B |
| **CompositeFormat**    | **100**    | **48.559 μs** | **513.432 μs** | **28.1429 μs** | **32.316 μs** | **32.306 μs** | **81.056 μs** |   **14336 B** |
| StringFormat       | 100    | 51.836 μs | 211.509 μs | 11.5935 μs | 45.364 μs | 44.924 μs | 65.221 μs |   16736 B |
| InterpolatedFormat | 100    | 34.792 μs | 148.754 μs |  8.1537 μs | 30.337 μs | 29.837 μs | 44.203 μs |   14336 B |
