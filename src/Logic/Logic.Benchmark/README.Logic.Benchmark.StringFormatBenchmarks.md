```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.947 μs** |   **1.536 μs** |  **0.0842 μs** |  **5.850 μs** |  **6.001 μs** |     **872 B** |
| StringFormat       | 1      |  7.615 μs |   1.746 μs |  0.0957 μs |  7.554 μs |  7.725 μs |     896 B |
| InterpolatedFormat | 1      |  7.047 μs |   3.932 μs |  0.2155 μs |  6.833 μs |  7.264 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.028 μs** | **101.036 μs** |  **5.5381 μs** | **33.784 μs** | **44.293 μs** |   **14336 B** |
| StringFormat       | 100    | 39.697 μs | 183.385 μs | 10.0520 μs | 33.502 μs | 51.295 μs |   16736 B |
| InterpolatedFormat | 100    | 36.086 μs | 148.143 μs |  8.1202 μs | 31.214 μs | 45.460 μs |   14336 B |
