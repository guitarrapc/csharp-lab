```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.054 μs** |   **0.4591 μs** |  **0.0252 μs** |  **6.031 μs** |  **6.081 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.337 μs |   3.4535 μs |  0.1893 μs |  7.204 μs |  7.553 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.204 μs |   7.6716 μs |  0.4205 μs |  5.890 μs |  6.682 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.460 μs |   0.6578 μs |  0.0361 μs |  5.430 μs |  5.500 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  6.074 μs |   9.8556 μs |  0.5402 μs |  5.690 μs |  6.692 μs |     608 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.113 μs |   5.0635 μs |  0.2775 μs |  4.859 μs |  5.410 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **49.083 μs** | **158.0997 μs** |  **8.6660 μs** | **42.461 μs** | **58.891 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 39.114 μs | 138.4987 μs |  7.5916 μs | 34.726 μs | 47.880 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 36.398 μs | 128.6910 μs |  7.0540 μs | 32.271 μs | 44.543 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 38.468 μs | 271.6283 μs | 14.8889 μs | 25.584 μs | 54.767 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 31.342 μs | 140.8395 μs |  7.7199 μs | 26.780 μs | 40.255 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 40.395 μs | 221.6725 μs | 12.1506 μs | 32.851 μs | 54.412 μs |   14336 B |
