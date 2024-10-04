```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.071 μs** |   **0.8261 μs** |  **0.0453 μs** |  **6.061 μs** |  **6.031 μs** |  **6.120 μs** |     **872 B** |
| StringFormat       | 1      |  6.482 μs |   0.1916 μs |  0.0105 μs |  6.482 μs |  6.471 μs |  6.492 μs |     896 B |
| InterpolatedFormat | 1      |  6.663 μs |   1.7403 μs |  0.0954 μs |  6.653 μs |  6.573 μs |  6.763 μs |     872 B |
| **CompositeFormat**    | **100**    | **49.301 μs** | **187.8890 μs** | **10.2988 μs** | **43.440 μs** | **43.271 μs** | **61.193 μs** |   **14336 B** |
| StringFormat       | 100    | 70.475 μs | 194.4433 μs | 10.6581 μs | 64.691 μs | 63.959 μs | 82.775 μs |   16736 B |
| InterpolatedFormat | 100    | 53.950 μs | 364.2337 μs | 19.9649 μs | 42.549 μs | 42.298 μs | 77.003 μs |   14336 B |
