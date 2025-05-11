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
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **19.69 μs** | **319.68 μs** | **17.523 μs** |  **10.109 μs** |   **9.046 μs** |  **39.91 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  76.58 μs | 294.95 μs | 16.167 μs |  70.260 μs |  64.519 μs |  94.95 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  45.88 μs | 264.22 μs | 14.483 μs |  41.006 μs |  34.454 μs |  62.16 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  17.55 μs | 177.62 μs |  9.736 μs |  14.247 μs |   9.889 μs |  28.50 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  51.69 μs | 280.77 μs | 15.390 μs |  42.980 μs |  42.629 μs |  69.46 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.45 μs | 157.67 μs |  8.642 μs |   6.582 μs |   6.341 μs |  21.43 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  50.08 μs | 282.76 μs | 15.499 μs |  41.458 μs |  40.817 μs |  67.98 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  62.86 μs | 292.26 μs | 16.020 μs |  55.723 μs |  51.656 μs |  81.21 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.52 μs | 137.80 μs |  7.553 μs |  10.710 μs |   6.041 μs |  20.82 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  43.62 μs |  83.26 μs |  4.564 μs |  41.737 μs |  40.294 μs |  48.82 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  31.86 μs | 283.01 μs | 15.513 μs |  25.457 μs |  20.579 μs |  49.55 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  17.96 μs | 194.02 μs | 10.635 μs |  14.181 μs |   9.733 μs |  29.97 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  52.28 μs | 265.27 μs | 14.540 μs |  44.077 μs |  43.687 μs |  69.06 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  13.71 μs | 208.47 μs | 11.427 μs |   7.915 μs |   6.351 μs |  26.88 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  37.26 μs | 159.95 μs |  8.768 μs |  36.879 μs |  28.684 μs |  46.21 μs |  17.63 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  59.85 μs | 143.76 μs |  7.880 μs |  60.492 μs |  51.666 μs |  67.39 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **21.98 μs** | **333.20 μs** | **18.264 μs** |  **11.751 μs** |  **11.130 μs** |  **43.07 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 328.78 μs | 488.37 μs | 26.769 μs | 337.819 μs | 298.656 μs | 349.85 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 155.90 μs | 157.70 μs |  8.644 μs | 151.618 μs | 150.226 μs | 165.84 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  67.73 μs | 284.02 μs | 15.568 μs |  61.300 μs |  56.410 μs |  85.48 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 236.47 μs | 511.38 μs | 28.030 μs | 241.380 μs | 206.314 μs | 261.73 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.68 μs | 194.83 μs | 10.679 μs |   7.665 μs |   7.364 μs |  26.01 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  99.55 μs | 644.17 μs | 35.309 μs |  79.528 μs |  78.806 μs | 140.32 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 301.08 μs | 283.56 μs | 15.543 μs | 303.104 μs | 284.620 μs | 315.51 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  20.41 μs | 345.61 μs | 18.944 μs |   9.829 μs |   9.117 μs |  42.28 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 130.13 μs | 286.70 μs | 15.715 μs | 128.610 μs | 115.235 μs | 146.55 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 160.33 μs | 333.53 μs | 18.282 μs | 157.044 μs | 143.919 μs | 180.04 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  65.78 μs | 182.92 μs | 10.027 μs |  60.412 μs |  59.590 μs |  77.35 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 241.90 μs | 678.42 μs | 37.186 μs | 248.768 μs | 201.762 μs | 275.18 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.32 μs | 195.89 μs | 10.737 μs |   7.303 μs |   6.944 μs |  25.72 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  76.11 μs | 266.72 μs | 14.620 μs |  68.928 μs |  66.474 μs |  92.93 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 293.32 μs | 137.36 μs |  7.529 μs | 296.393 μs | 284.741 μs | 298.83 μs |  20.25 KB |
