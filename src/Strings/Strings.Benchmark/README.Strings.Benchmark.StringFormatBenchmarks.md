```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error      | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |------- |----------:|-----------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      | **12.503 μs** | **165.931 μs** |  **9.0952 μs** |  **8.356 μs** |  **6.221 μs** | **22.933 μs** |     **872 B** |
| StringFormat       | 1      |  6.612 μs |   2.936 μs |  0.1609 μs |  6.633 μs |  6.442 μs |  6.763 μs |     896 B |
| InterpolatedFormat | 1      |  6.342 μs |   4.916 μs |  0.2695 μs |  6.262 μs |  6.121 μs |  6.642 μs |     872 B |
| **CompositeFormat**    | **100**    | **38.255 μs** | **163.628 μs** |  **8.9690 μs** | **33.131 μs** | **33.022 μs** | **48.611 μs** |   **14336 B** |
| StringFormat       | 100    | 70.599 μs | 119.219 μs |  6.5348 μs | 68.689 μs | 65.232 μs | 77.876 μs |   16736 B |
| InterpolatedFormat | 100    | 50.427 μs | 246.768 μs | 13.5262 μs | 42.899 μs | 42.339 μs | 66.042 μs |   14336 B |
