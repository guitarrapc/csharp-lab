```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.165 μs** |   **4.688 μs** | **0.2569 μs** |  **5.870 μs** |  **6.343 μs** |     **872 B** |
| StringFormat       | 1      |  6.222 μs |   7.629 μs | 0.4182 μs |  5.942 μs |  6.703 μs |     896 B |
| InterpolatedFormat | 1      |  6.729 μs |   3.291 μs | 0.1804 μs |  6.542 μs |  6.902 μs |     872 B |
| **CompositeFormat**    | **100**    | **35.770 μs** | **119.016 μs** | **6.5236 μs** | **31.639 μs** | **43.291 μs** |   **14336 B** |
| StringFormat       | 100    | 37.934 μs | 174.229 μs | 9.5501 μs | 32.370 μs | 48.962 μs |   16736 B |
| InterpolatedFormat | 100    | 34.757 μs | 135.691 μs | 7.4377 μs | 30.122 μs | 43.336 μs |   14336 B |
