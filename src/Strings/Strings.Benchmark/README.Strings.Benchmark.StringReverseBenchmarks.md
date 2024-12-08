```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.81 μs** | **196.227 μs** | **10.756 μs** |   **7.655 μs** |   **7.544 μs** |  **26.23 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.82 μs | 288.712 μs | 15.825 μs |  76.985 μs |  72.556 μs | 101.91 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  33.04 μs | 280.686 μs | 15.385 μs |  26.154 μs |  22.306 μs |  50.67 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.93 μs | 167.856 μs |  9.201 μs |  14.972 μs |  10.575 μs |  28.25 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.70 μs | 237.535 μs | 13.020 μs |  45.269 μs |  43.155 μs |  66.69 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.36 μs | 151.511 μs |  8.305 μs |   9.784 μs |   7.449 μs |  22.86 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.48 μs | 315.383 μs | 17.287 μs |  27.981 μs |  27.031 μs |  57.44 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.09 μs** | **287.742 μs** | **15.772 μs** |   **9.197 μs** |   **8.767 μs** |  **36.30 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 314.91 μs | 267.857 μs | 14.682 μs | 314.487 μs | 300.451 μs | 329.81 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 149.55 μs |   0.918 μs |  0.050 μs | 149.559 μs | 149.499 μs | 149.60 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  66.71 μs | 270.651 μs | 14.835 μs |  67.846 μs |  51.336 μs |  80.94 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 259.86 μs | 856.932 μs | 46.971 μs | 268.716 μs | 209.096 μs | 301.78 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.67 μs | 204.573 μs | 11.213 μs |   8.315 μs |   8.085 μs |  27.62 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.34 μs | 561.809 μs | 30.795 μs |  69.956 μs |  67.201 μs | 121.86 μs |  68.69 KB |
