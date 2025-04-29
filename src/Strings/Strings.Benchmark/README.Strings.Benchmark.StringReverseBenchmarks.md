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
| Method                 | Runtime  | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **12.94 μs** | **140.726 μs** |  **7.714 μs** |  **10.780 μs** |   **6.532 μs** |  **21.50 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  75.92 μs | 328.309 μs | 17.996 μs |  67.376 μs |  63.779 μs |  96.59 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  31.02 μs | 245.457 μs | 13.454 μs |  25.508 μs |  21.200 μs |  46.36 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  17.58 μs | 180.488 μs |  9.893 μs |  14.157 μs |   9.860 μs |  28.73 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  64.59 μs | 286.520 μs | 15.705 μs |  56.285 μs |  54.783 μs |  82.70 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  17.63 μs | 349.671 μs | 19.167 μs |   6.622 μs |   6.513 μs |  39.76 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  47.24 μs | 439.264 μs | 24.078 μs |  41.444 μs |  26.584 μs |  73.68 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  56.29 μs |  79.898 μs |  4.379 μs |  56.185 μs |  51.967 μs |  60.72 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.45 μs | 196.963 μs | 10.796 μs |   6.252 μs |   6.181 μs |  24.92 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  67.66 μs | 368.145 μs | 20.179 μs |  65.332 μs |  48.751 μs |  88.91 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  49.71 μs | 306.098 μs | 16.778 μs |  55.538 μs |  30.793 μs |  62.79 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  20.40 μs | 188.328 μs | 10.323 μs |  14.587 μs |  14.297 μs |  32.32 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  51.45 μs | 239.884 μs | 13.149 μs |  44.454 μs |  43.273 μs |  66.61 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.58 μs | 164.986 μs |  9.043 μs |   6.443 μs |   6.273 μs |  22.02 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  35.25 μs | 114.800 μs |  6.293 μs |  32.666 μs |  30.663 μs |  42.42 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  54.84 μs |  88.874 μs |  4.871 μs |  54.663 μs |  50.064 μs |  59.80 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.26 μs** | **262.720 μs** | **14.401 μs** |   **7.965 μs** |   **7.934 μs** |  **32.89 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 322.10 μs | 203.004 μs | 11.127 μs | 321.666 μs | 311.195 μs | 333.44 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 149.05 μs |   8.137 μs |  0.446 μs | 149.044 μs | 148.604 μs | 149.50 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  72.83 μs | 279.192 μs | 15.303 μs |  69.229 μs |  59.642 μs |  89.61 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 239.32 μs | 494.124 μs | 27.085 μs | 242.957 μs | 210.596 μs | 264.40 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.57 μs | 197.223 μs | 10.810 μs |   7.544 μs |   7.113 μs |  26.05 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  84.65 μs | 513.449 μs | 28.144 μs |  68.459 μs |  68.348 μs | 117.15 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 296.29 μs | 141.931 μs |  7.780 μs | 300.215 μs | 287.330 μs | 301.33 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  17.47 μs | 260.882 μs | 14.300 μs |  10.930 μs |   7.614 μs |  33.87 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 124.02 μs | 217.023 μs | 11.896 μs | 118.002 μs | 116.328 μs | 137.72 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 165.19 μs | 224.127 μs | 12.285 μs | 161.885 μs | 154.892 μs | 178.79 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  62.42 μs | 248.824 μs | 13.639 μs |  59.813 μs |  50.275 μs |  77.18 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 230.52 μs | 556.948 μs | 30.528 μs | 227.517 μs | 201.598 μs | 262.43 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  19.77 μs | 361.007 μs | 19.788 μs |   9.848 μs |   6.913 μs |  42.56 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  89.00 μs | 300.156 μs | 16.453 μs |  94.698 μs |  70.453 μs | 101.84 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 314.43 μs | 403.658 μs | 22.126 μs | 311.947 μs | 293.652 μs | 337.69 μs |  20.25 KB |
