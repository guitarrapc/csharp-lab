```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean      | Error       | StdDev    | Min       | Max       | Allocated |
|------------------- |------- |----------:|------------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **1**      |  **6.167 μs** |   **4.5239 μs** | **0.2480 μs** |  **5.887 μs** |  **6.358 μs** |     **872 B** |
| StringFormat       | 1      |  7.223 μs |   4.4276 μs | 0.2427 μs |  6.943 μs |  7.373 μs |     896 B |
| InterpolatedFormat | 1      |  5.801 μs |   0.4896 μs | 0.0268 μs |  5.771 μs |  5.822 μs |     872 B |
| **CompositeFormat**    | **100**    | **37.367 μs** | **131.6873 μs** | **7.2182 μs** | **32.762 μs** | **45.686 μs** |   **14336 B** |
| StringFormat       | 100    | 38.305 μs | 131.5947 μs | 7.2132 μs | 33.684 μs | 46.617 μs |   16736 B |
| InterpolatedFormat | 100    | 38.151 μs | 180.7958 μs | 9.9100 μs | 32.240 μs | 49.592 μs |   14336 B |
