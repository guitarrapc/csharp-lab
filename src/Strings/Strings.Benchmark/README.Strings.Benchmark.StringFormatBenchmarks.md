```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.157 μs** |   **0.1827 μs** |  **0.0100 μs** |  **6.157 μs** |  **6.146 μs** |  **6.167 μs** |     **872 B** |
| StringFormat       | 1      |  7.344 μs |  18.5139 μs |  1.0148 μs |  7.194 μs |  6.412 μs |  8.425 μs |     896 B |
| InterpolatedFormat | 1      |  5.815 μs |   3.8011 μs |  0.2084 μs |  5.926 μs |  5.575 μs |  5.945 μs |     872 B |
| **CompositeFormat**    | **100**    | **51.834 μs** | **204.9015 μs** | **11.2313 μs** | **46.949 μs** | **43.873 μs** | **64.681 μs** |   **14336 B** |
| StringFormat       | 100    | 45.304 μs | 395.7337 μs | 21.6915 μs | 32.921 μs | 32.641 μs | 70.351 μs |   16736 B |
| InterpolatedFormat | 100    | 47.780 μs | 214.4678 μs | 11.7557 μs | 41.899 μs | 40.126 μs | 61.316 μs |   14336 B |
