```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **15.90 μs** | **190.47 μs** | **10.440 μs** |  **10.239 μs** |   **9.518 μs** |  **27.95 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  48.62 μs | 168.53 μs |  9.238 μs |  44.758 μs |  41.944 μs |  59.16 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  41.57 μs | 372.57 μs | 20.422 μs |  34.876 μs |  25.337 μs |  64.50 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  28.05 μs | 324.07 μs | 17.763 μs |  20.558 μs |  15.258 μs |  48.33 μs |   9.81 KB |
| StackReverse           | 10     | 100    |  52.96 μs | 263.88 μs | 14.464 μs |  45.445 μs |  43.792 μs |  69.63 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.30 μs | 165.86 μs |  9.091 μs |   7.223 μs |   6.873 μs |  22.79 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  39.50 μs | 196.50 μs | 10.771 μs |  37.229 μs |  30.046 μs |  51.23 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **16.71 μs** | **259.61 μs** | **14.230 μs** |   **8.607 μs** |   **8.386 μs** |  **33.14 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 126.90 μs | 236.76 μs | 12.978 μs | 121.877 μs | 117.178 μs | 141.63 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 151.79 μs |  56.22 μs |  3.081 μs | 150.726 μs | 149.385 μs | 155.26 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  69.41 μs | 283.07 μs | 15.516 μs |  75.661 μs |  51.746 μs |  80.83 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 239.13 μs | 542.78 μs | 29.752 μs | 233.901 μs | 212.341 μs | 271.15 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.10 μs | 202.54 μs | 11.102 μs |   7.885 μs |   7.505 μs |  26.92 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.64 μs | 224.25 μs | 12.292 μs |  90.749 μs |  71.613 μs |  94.55 μs |  37.94 KB |
