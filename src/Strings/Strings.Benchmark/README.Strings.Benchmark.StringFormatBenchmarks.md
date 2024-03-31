```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev     | Median    | Min       | Max        | Allocated |
|------------------- |------- |----------:|------------:|-----------:|----------:|----------:|-----------:|----------:|
| **CompositeFormat**    | **1**      |  **5.969 μs** |   **3.9916 μs** |  **0.2188 μs** |  **5.926 μs** |  **5.776 μs** |   **6.207 μs** |     **872 B** |
| StringFormat       | 1      |  7.039 μs |   7.8745 μs |  0.4316 μs |  7.123 μs |  6.572 μs |   7.423 μs |     896 B |
| InterpolatedFormat | 1      |  6.589 μs |   0.7373 μs |  0.0404 μs |  6.582 μs |  6.553 μs |   6.633 μs |     872 B |
| **CompositeFormat**    | **100**    | **72.257 μs** | **747.1598 μs** | **40.9544 μs** | **54.591 μs** | **43.100 μs** | **119.079 μs** |   **14336 B** |
| StringFormat       | 100    | 38.426 μs | 146.7537 μs |  8.0441 μs | 34.024 μs | 33.543 μs |  47.710 μs |   16736 B |
| InterpolatedFormat | 100    | 42.449 μs |  70.5596 μs |  3.8676 μs | 40.445 μs | 39.994 μs |  46.907 μs |   14336 B |
