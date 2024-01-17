```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.091 μs** |   **5.710 μs** | **0.3130 μs** |  **5.891 μs** |  **6.452 μs** |     **872 B** |
| StringFormat       | 1      |  7.586 μs |   7.785 μs | 0.4267 μs |  7.179 μs |  8.030 μs |     896 B |
| InterpolatedFormat | 1      |  6.329 μs |   7.896 μs | 0.4328 μs |  5.832 μs |  6.622 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.456 μs** | **132.338 μs** | **7.2539 μs** | **34.239 μs** | **46.833 μs** |   **14336 B** |
| StringFormat       | 100    | 36.905 μs | 111.422 μs | 6.1074 μs | 33.132 μs | 43.952 μs |   16736 B |
| InterpolatedFormat | 100    | 34.477 μs | 119.622 μs | 6.5569 μs | 30.356 μs | 42.038 μs |   14336 B |
