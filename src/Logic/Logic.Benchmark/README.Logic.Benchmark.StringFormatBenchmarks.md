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
| **CompositeFormat**    | **1**      |  **5.898 μs** |   **3.748 μs** | **0.2055 μs** |  **5.701 μs** |  **6.111 μs** |     **872 B** |
| StringFormat       | 1      |  7.340 μs |   4.064 μs | 0.2228 μs |  7.083 μs |  7.484 μs |     896 B |
| InterpolatedFormat | 1      |  5.652 μs |   1.530 μs | 0.0839 μs |  5.555 μs |  5.705 μs |     872 B |
| **CompositeFormat**    | **100**    | **36.084 μs** | **119.436 μs** | **6.5467 μs** | **32.151 μs** | **43.642 μs** |   **14336 B** |
| StringFormat       | 100    | 36.961 μs | 127.482 μs | 6.9877 μs | 32.907 μs | 45.029 μs |   16736 B |
| InterpolatedFormat | 100    | 34.982 μs | 111.662 μs | 6.1206 μs | 31.359 μs | 42.049 μs |   14336 B |
