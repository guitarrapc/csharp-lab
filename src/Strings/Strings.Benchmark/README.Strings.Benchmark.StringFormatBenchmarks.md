```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.181 μs** |   **2.402 μs** |  **0.1317 μs** |  **6.040 μs** |  **6.301 μs** |     **872 B** |
| StringFormat       | 1      |  7.235 μs |   2.545 μs |  0.1395 μs |  7.074 μs |  7.325 μs |     896 B |
| InterpolatedFormat | 1      |  5.844 μs |   2.440 μs |  0.1337 μs |  5.690 μs |  5.931 μs |     872 B |
| **CompositeFormat**    | **100**    | **35.313 μs** | **123.872 μs** |  **6.7899 μs** | **31.199 μs** | **43.150 μs** |   **14336 B** |
| StringFormat       | 100    | 44.305 μs |   7.398 μs |  0.4055 μs | 43.912 μs | 44.722 μs |   16736 B |
| InterpolatedFormat | 100    | 60.646 μs | 219.615 μs | 12.0378 μs | 51.966 μs | 74.388 μs |   14336 B |
