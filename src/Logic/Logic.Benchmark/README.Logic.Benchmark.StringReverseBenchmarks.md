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
| **ArrayReverse**           | **10**     | **100**    |  **14.23 μs** | **157.98 μs** |  **8.659 μs** |  **11.280 μs** |   **7.425 μs** |  **23.97 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  85.94 μs | 242.67 μs | 13.301 μs |  81.843 μs |  75.169 μs | 100.81 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  55.56 μs | 377.39 μs | 20.686 μs |  52.307 μs |  36.698 μs |  77.68 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.48 μs | 145.33 μs |  7.966 μs |  14.868 μs |  11.142 μs |  26.42 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  56.00 μs | 254.74 μs | 13.963 μs |  47.975 μs |  47.895 μs |  72.12 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.78 μs | 191.99 μs | 10.523 μs |   8.009 μs |   7.399 μs |  25.92 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.60 μs | 282.18 μs | 15.467 μs |  29.470 μs |  27.896 μs |  55.44 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.74 μs** | **280.30 μs** | **15.364 μs** |   **9.037 μs** |   **8.696 μs** |  **35.48 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 307.40 μs | 181.16 μs |  9.930 μs | 311.831 μs | 296.022 μs | 314.34 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 187.86 μs |  66.91 μs |  3.668 μs | 189.473 μs | 183.662 μs | 190.44 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  76.79 μs | 288.51 μs | 15.814 μs |  82.219 μs |  58.974 μs |  89.17 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 250.89 μs | 534.93 μs | 29.322 μs | 247.451 μs | 223.446 μs | 281.79 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.84 μs | 207.23 μs | 11.359 μs |   8.465 μs |   8.094 μs |  27.95 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  90.14 μs | 505.12 μs | 27.687 μs |  81.251 μs |  67.997 μs | 121.19 μs |  68.69 KB |
