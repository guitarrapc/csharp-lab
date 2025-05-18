```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.237 μs** |   **2.4203 μs** |  **0.1327 μs** |  **6.287 μs** |  **6.087 μs** |  **6.338 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  7.211 μs |   4.2196 μs |  0.2313 μs |  7.224 μs |  6.973 μs |  7.435 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  6.245 μs |   7.8087 μs |  0.4280 μs |  6.471 μs |  5.752 μs |  6.513 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  5.783 μs |  11.0420 μs |  0.6052 μs |  5.449 μs |  5.419 μs |  6.482 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.490 μs |   1.1097 μs |  0.0608 μs |  5.460 μs |  5.450 μs |  5.560 μs |     896 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.271 μs |   0.3740 μs |  0.0205 μs |  5.271 μs |  5.250 μs |  5.291 μs |     584 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **40.729 μs** | **231.8548 μs** | **12.7087 μs** | **33.492 μs** | **33.291 μs** | **55.404 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 44.340 μs | 318.2670 μs | 17.4453 μs | 34.319 μs | 34.218 μs | 64.484 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 45.004 μs | 332.7979 μs | 18.2418 μs | 37.881 μs | 31.399 μs | 65.733 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 32.304 μs | 178.6768 μs |  9.7939 μs | 26.780 μs | 26.520 μs | 43.612 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 32.645 μs | 144.9350 μs |  7.9444 μs | 28.083 μs | 28.033 μs | 41.818 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 31.285 μs | 200.4801 μs | 10.9890 μs | 25.417 μs | 24.475 μs | 43.962 μs |   14336 B |
