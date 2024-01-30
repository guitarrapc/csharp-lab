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
| **CompositeFormat**    | **1**      |  **6.762 μs** |   **2.5541 μs** |  **0.1400 μs** |  **6.622 μs** |  **6.902 μs** |     **872 B** |
| StringFormat       | 1      |  7.344 μs |   0.6268 μs |  0.0344 μs |  7.324 μs |  7.384 μs |     896 B |
| InterpolatedFormat | 1      |  5.740 μs |   1.8959 μs |  0.1039 μs |  5.680 μs |  5.860 μs |     872 B |
| **CompositeFormat**    | **100**    | **51.029 μs** | **217.4647 μs** | **11.9200 μs** | **43.962 μs** | **64.791 μs** |   **14336 B** |
| StringFormat       | 100    | 38.081 μs | 125.5897 μs |  6.8840 μs | 33.883 μs | 46.026 μs |   16736 B |
| InterpolatedFormat | 100    | 49.338 μs | 242.5974 μs | 13.2976 μs | 41.397 μs | 64.690 μs |   14336 B |
