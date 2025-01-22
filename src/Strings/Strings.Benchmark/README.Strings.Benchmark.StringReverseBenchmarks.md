```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.03 μs** | **159.03 μs** |  **8.717 μs** |   **7.043 μs** |   **6.943 μs** |  **22.09 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  60.38 μs | 156.56 μs |  8.581 μs |  56.896 μs |  54.080 μs |  70.15 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  35.22 μs | 241.54 μs | 13.240 μs |  29.915 μs |  25.447 μs |  50.28 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  23.30 μs | 180.67 μs |  9.903 μs |  20.529 μs |  15.079 μs |  34.30 μs |   9.44 KB |
| StackReverse           | 10     | 100    |  59.52 μs | 348.04 μs | 19.077 μs |  55.303 μs |  42.901 μs |  80.35 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.24 μs | 168.91 μs |  9.258 μs |   6.917 μs |   6.867 μs |  22.93 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  52.87 μs | 182.44 μs | 10.000 μs |  57.067 μs |  41.458 μs |  60.09 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.44 μs** | **278.44 μs** | **15.262 μs** |   **8.636 μs** |   **8.625 μs** |  **35.06 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 146.49 μs | 408.31 μs | 22.381 μs | 157.705 μs | 120.716 μs | 161.04 μs |  37.94 KB |
| RecursiveReverse       | 64     | 100    | 175.25 μs | 114.57 μs |  6.280 μs | 177.853 μs | 168.085 μs | 179.81 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  64.86 μs | 256.70 μs | 14.071 μs |  67.480 μs |  49.657 μs |  77.43 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 241.94 μs | 586.27 μs | 32.136 μs | 237.503 μs | 212.255 μs | 276.06 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.91 μs | 227.09 μs | 12.448 μs |   7.734 μs |   7.714 μs |  29.28 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  92.97 μs | 467.30 μs | 25.614 μs |  82.594 μs |  74.178 μs | 122.15 μs |  38.22 KB |
