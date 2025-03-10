```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **13.11 μs** | **140.70 μs** |  **7.712 μs** |  **10.911 μs** |   **6.734 μs** |  **21.68 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  85.75 μs | 217.13 μs | 11.901 μs |  82.735 μs |  75.641 μs |  98.86 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  34.45 μs | 293.38 μs | 16.081 μs |  29.895 μs |  21.139 μs |  52.32 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.57 μs | 150.33 μs |  8.240 μs |  13.926 μs |   9.979 μs |  25.81 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  52.08 μs | 265.83 μs | 14.571 μs |  43.692 μs |  43.651 μs |  68.91 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  12.89 μs | 191.83 μs | 10.515 μs |   7.138 μs |   6.497 μs |  25.02 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  41.97 μs | 477.37 μs | 26.166 μs |  27.071 μs |  26.660 μs |  72.19 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  61.10 μs | 156.27 μs |  8.565 μs |  60.760 μs |  52.705 μs |  69.83 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  14.55 μs | 201.47 μs | 11.043 μs |   9.633 μs |   6.817 μs |  27.20 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  55.60 μs | 284.68 μs | 15.604 μs |  54.081 μs |  40.806 μs |  71.90 μs |  17.63 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  29.68 μs | 237.58 μs | 13.023 μs |  24.736 μs |  19.857 μs |  44.45 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.50 μs | 149.80 μs |  8.211 μs |  14.348 μs |   9.588 μs |  25.58 μs |   9.81 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  53.17 μs | 266.84 μs | 14.627 μs |  44.894 μs |  44.565 μs |  70.06 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  12.47 μs | 190.38 μs | 10.435 μs |   6.501 μs |   6.382 μs |  24.52 μs |   5.13 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  36.23 μs | 157.84 μs |  8.652 μs |  34.314 μs |  28.704 μs |  45.69 μs |  17.63 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  58.73 μs |  85.18 μs |  4.669 μs |  58.801 μs |  54.022 μs |  63.36 μs |   9.81 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **22.71 μs** | **356.19 μs** | **19.524 μs** |  **11.743 μs** |  **11.142 μs** |  **45.26 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 320.19 μs | 376.69 μs | 20.648 μs | 312.455 μs | 304.520 μs | 343.58 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 171.43 μs | 413.26 μs | 22.652 μs | 159.580 μs | 157.165 μs | 197.55 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  61.56 μs | 213.66 μs | 11.711 μs |  59.552 μs |  50.976 μs |  74.14 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 249.80 μs | 644.53 μs | 35.329 μs | 269.154 μs | 209.021 μs | 271.22 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.78 μs | 201.98 μs | 11.071 μs |   7.655 μs |   7.125 μs |  26.56 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  84.02 μs | 544.50 μs | 29.846 μs |  67.441 μs |  66.148 μs | 118.48 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 332.67 μs | 591.45 μs | 32.419 μs | 331.391 μs | 300.903 μs | 365.70 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.20 μs | 265.54 μs | 14.555 μs |   8.005 μs |   7.585 μs |  33.00 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 121.17 μs | 224.39 μs | 12.299 μs | 115.046 μs | 113.143 μs | 135.33 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 162.90 μs | 336.58 μs | 18.449 μs | 165.325 μs | 143.363 μs | 180.02 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  76.35 μs | 428.39 μs | 23.481 μs |  85.159 μs |  49.733 μs |  94.15 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 258.56 μs | 744.66 μs | 40.818 μs | 235.708 μs | 234.294 μs | 305.69 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  16.89 μs | 274.94 μs | 15.070 μs |   9.463 μs |   6.968 μs |  34.23 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  93.52 μs | 248.19 μs | 13.604 μs |  95.499 μs |  79.037 μs | 106.03 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 407.88 μs | 192.92 μs | 10.574 μs | 402.043 μs | 401.512 μs | 420.09 μs |  20.25 KB |
