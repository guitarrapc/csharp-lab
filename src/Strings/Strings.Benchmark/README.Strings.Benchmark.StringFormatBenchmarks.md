```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean      | Error       | StdDev     | Median    | Min       | Max       | Allocated |
|------------------- |--------- |------- |----------:|------------:|-----------:|----------:|----------:|----------:|----------:|
| **CompositeFormat**    | **.NET 8.0** | **1**      |  **6.325 μs** |  **16.6046 μs** |  **0.9102 μs** |  **5.861 μs** |  **5.741 μs** |  **7.374 μs** |     **872 B** |
| StringFormat       | .NET 8.0 | 1      |  6.289 μs |   4.7663 μs |  0.2613 μs |  6.276 μs |  6.035 μs |  6.557 μs |     896 B |
| InterpolatedFormat | .NET 8.0 | 1      |  5.717 μs |   1.2943 μs |  0.0709 μs |  5.730 μs |  5.640 μs |  5.780 μs |     872 B |
| CompositeFormat    | .NET 9.0 | 1      |  6.331 μs |  13.4940 μs |  0.7397 μs |  5.961 μs |  5.850 μs |  7.183 μs |     872 B |
| StringFormat       | .NET 9.0 | 1      |  5.988 μs |   4.0808 μs |  0.2237 μs |  6.091 μs |  5.731 μs |  6.141 μs |     608 B |
| InterpolatedFormat | .NET 9.0 | 1      |  5.141 μs |   0.8227 μs |  0.0451 μs |  5.144 μs |  5.095 μs |  5.184 μs |     872 B |
| **CompositeFormat**    | **.NET 8.0** | **100**    | **65.110 μs** | **240.9111 μs** | **13.2052 μs** | **60.908 μs** | **54.517 μs** | **79.904 μs** |   **14336 B** |
| StringFormat       | .NET 8.0 | 100    | 42.769 μs | 292.3713 μs | 16.0259 μs | 33.622 μs | 33.412 μs | 61.274 μs |   16736 B |
| InterpolatedFormat | .NET 8.0 | 100    | 37.677 μs | 170.4087 μs |  9.3407 μs | 32.450 μs | 32.120 μs | 48.461 μs |   14336 B |
| CompositeFormat    | .NET 9.0 | 100    | 44.892 μs | 267.9897 μs | 14.6894 μs | 36.714 μs | 36.112 μs | 61.850 μs |   14336 B |
| StringFormat       | .NET 9.0 | 100    | 50.080 μs | 133.3295 μs |  7.3082 μs | 45.906 μs | 45.816 μs | 58.519 μs |   16736 B |
| InterpolatedFormat | .NET 9.0 | 100    | 30.287 μs | 188.0531 μs | 10.3078 μs | 24.426 μs | 24.246 μs | 42.189 μs |   14336 B |
