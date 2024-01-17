```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.92 μs** | **169.87 μs** |  **9.311 μs** |  **11.802 μs** |   **7.564 μs** |  **25.39 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  82.80 μs | 204.73 μs | 11.222 μs |  79.603 μs |  73.522 μs |  95.27 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  40.82 μs | 305.81 μs | 16.762 μs |  36.117 μs |  26.910 μs |  59.43 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.63 μs | 158.03 μs |  8.662 μs |  14.566 μs |  10.921 μs |  27.41 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.26 μs | 239.56 μs | 13.131 μs |  47.383 μs |  46.002 μs |  69.40 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.84 μs | 201.38 μs | 11.038 μs |   7.679 μs |   7.258 μs |  26.58 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  40.98 μs | 247.08 μs | 13.543 μs |  41.297 μs |  27.281 μs |  54.36 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.59 μs** | **264.34 μs** | **14.489 μs** |   **9.467 μs** |   **8.976 μs** |  **34.31 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.32 μs | 298.43 μs | 16.358 μs | 307.393 μs | 286.645 μs | 318.93 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 178.55 μs |  25.50 μs |  1.397 μs | 178.853 μs | 177.021 μs | 179.76 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  65.27 μs | 134.86 μs |  7.392 μs |  61.199 μs |  60.808 μs |  73.80 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 251.74 μs | 570.81 μs | 31.288 μs | 253.013 μs | 219.841 μs | 282.38 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.14 μs | 218.98 μs | 12.003 μs |   8.295 μs |   8.134 μs |  29.00 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  93.82 μs | 784.95 μs | 43.026 μs |  70.071 μs |  67.906 μs | 143.49 μs |  68.69 KB |
