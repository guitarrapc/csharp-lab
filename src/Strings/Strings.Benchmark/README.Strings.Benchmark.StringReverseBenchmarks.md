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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **15.31 μs** | **170.02 μs** |  **9.320 μs** |  **10.204 μs** |   **9.652 μs** |  **26.06 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  88.66 μs | 193.41 μs | 10.601 μs |  84.917 μs |  80.439 μs | 100.63 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  45.39 μs | 287.15 μs | 15.740 μs |  41.287 μs |  32.110 μs |  62.78 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  19.91 μs | 195.55 μs | 10.719 μs |  13.996 μs |  13.446 μs |  32.28 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  60.90 μs | 280.91 μs | 15.398 μs |  53.108 μs |  50.953 μs |  78.64 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.59 μs | 160.99 μs |  8.824 μs |   6.572 μs |   6.421 μs |  21.78 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  34.22 μs | 246.70 μs | 13.522 μs |  26.779 μs |  26.057 μs |  49.83 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  56.18 μs |  81.13 μs |  4.447 μs |  55.983 μs |  51.835 μs |  60.72 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  13.65 μs | 115.49 μs |  6.330 μs |  10.960 μs |   9.106 μs |  20.88 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  54.14 μs | 267.04 μs | 14.637 μs |  50.303 μs |  41.797 μs |  70.31 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  33.22 μs | 306.55 μs | 16.803 μs |  27.180 μs |  20.267 μs |  52.20 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.44 μs | 151.62 μs |  8.311 μs |  13.836 μs |   9.739 μs |  25.74 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  50.06 μs | 255.97 μs | 14.030 μs |  42.102 μs |  41.812 μs |  66.26 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  13.95 μs | 197.73 μs | 10.838 μs |   8.736 μs |   6.703 μs |  26.41 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  43.41 μs | 232.07 μs | 12.720 μs |  40.419 μs |  32.455 μs |  57.36 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  98.09 μs | 199.53 μs | 10.937 μs |  93.312 μs |  90.357 μs | 110.60 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **22.00 μs** | **333.24 μs** | **18.266 μs** |  **11.922 μs** |  **11.000 μs** |  **43.09 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 318.38 μs | 277.50 μs | 15.211 μs | 316.445 μs | 304.221 μs | 334.46 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 159.89 μs |  35.16 μs |  1.927 μs | 159.480 μs | 158.208 μs | 161.99 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  61.73 μs | 184.14 μs | 10.094 μs |  61.003 μs |  52.016 μs |  72.16 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 265.89 μs | 523.41 μs | 28.690 μs | 270.610 μs | 235.134 μs | 291.93 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  17.35 μs | 242.88 μs | 13.313 μs |   9.833 μs |   9.503 μs |  32.73 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  85.53 μs | 563.89 μs | 30.908 μs |  68.918 μs |  66.483 μs | 121.19 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 307.70 μs |  89.36 μs |  4.898 μs | 310.203 μs | 302.058 μs | 310.84 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  15.60 μs | 255.37 μs | 13.998 μs |   7.609 μs |   7.428 μs |  31.76 μs |  30.08 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 134.16 μs | 319.58 μs | 17.518 μs | 134.849 μs | 116.314 μs | 151.33 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 149.53 μs | 176.37 μs |  9.667 μs | 144.396 μs | 143.505 μs | 160.68 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.16 μs | 217.11 μs | 11.900 μs |  59.219 μs |  50.343 μs |  73.91 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 239.19 μs | 804.05 μs | 44.073 μs | 228.472 μs | 201.462 μs | 287.63 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  12.91 μs | 190.59 μs | 10.447 μs |   6.932 μs |   6.832 μs |  24.98 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  75.15 μs | 274.61 μs | 15.052 μs |  66.662 μs |  66.262 μs |  92.53 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 303.05 μs | 167.21 μs |  9.166 μs | 306.466 μs | 292.671 μs | 310.02 μs |  20.25 KB |
