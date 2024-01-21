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
| **CompositeFormat**    | **1**      |  **6.038 μs** |   **3.942 μs** |  **0.2161 μs** |  **5.791 μs** |  **6.192 μs** |     **872 B** |
| StringFormat       | 1      |  7.911 μs |   7.399 μs |  0.4056 μs |  7.464 μs |  8.255 μs |     896 B |
| InterpolatedFormat | 1      |  6.693 μs |   2.877 μs |  0.1577 μs |  6.553 μs |  6.864 μs |     872 B |
| **CompositeFormat**    | **100**    | **52.331 μs** | **304.724 μs** | **16.7029 μs** | **42.368 μs** | **71.615 μs** |   **14336 B** |
| StringFormat       | 100    | 38.486 μs | 148.398 μs |  8.1342 μs | 33.453 μs | 47.870 μs |   16736 B |
| InterpolatedFormat | 100    | 35.302 μs | 128.907 μs |  7.0658 μs | 31.168 μs | 43.461 μs |   14336 B |
