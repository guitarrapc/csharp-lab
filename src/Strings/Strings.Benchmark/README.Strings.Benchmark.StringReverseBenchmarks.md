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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **17.78 μs** | **194.336 μs** | **10.652 μs** |  **14.266 μs** |   **9.327 μs** |  **29.74 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  76.21 μs | 173.592 μs |  9.515 μs |  78.677 μs |  65.703 μs |  84.25 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  45.69 μs | 338.097 μs | 18.532 μs |  38.157 μs |  32.105 μs |  66.80 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  17.97 μs | 135.925 μs |  7.451 μs |  18.344 μs |  10.340 μs |  25.23 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  57.33 μs | 435.763 μs | 23.886 μs |  43.591 μs |  43.481 μs |  84.91 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.92 μs | 168.871 μs |  9.256 μs |   6.754 μs |   6.393 μs |  22.60 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  51.98 μs | 454.831 μs | 24.931 μs |  38.006 μs |  37.175 μs |  80.77 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  62.57 μs | 235.360 μs | 12.901 μs |  58.760 μs |  51.998 μs |  76.94 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  14.16 μs | 206.937 μs | 11.343 μs |   8.927 μs |   6.372 μs |  27.17 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  45.13 μs |  93.945 μs |  5.149 μs |  43.370 μs |  41.086 μs |  50.92 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  49.49 μs | 205.681 μs | 11.274 μs |  47.357 μs |  39.443 μs |  61.69 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  14.60 μs | 155.869 μs |  8.544 μs |   9.707 μs |   9.627 μs |  24.46 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  49.68 μs | 248.134 μs | 13.601 μs |  42.368 μs |  41.297 μs |  65.37 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.60 μs | 162.833 μs |  8.925 μs |   6.542 μs |   6.361 μs |  21.91 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  47.67 μs | 335.593 μs | 18.395 μs |  38.762 μs |  35.416 μs |  68.82 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  66.06 μs | 116.246 μs |  6.372 μs |  67.595 μs |  59.060 μs |  71.52 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **22.19 μs** | **342.577 μs** | **18.778 μs** |  **11.612 μs** |  **11.092 μs** |  **43.87 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 300.27 μs | 243.252 μs | 13.333 μs | 299.727 μs | 287.224 μs | 313.87 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 147.66 μs |   3.346 μs |  0.183 μs | 147.724 μs | 147.454 μs | 147.80 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  69.31 μs | 274.004 μs | 15.019 μs |  65.022 μs |  56.907 μs |  86.01 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 267.74 μs | 590.685 μs | 32.377 μs | 263.269 μs | 237.832 μs | 302.12 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.45 μs | 195.551 μs | 10.719 μs |   7.338 μs |   7.178 μs |  25.82 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  84.31 μs | 505.591 μs | 27.713 μs |  68.358 μs |  68.257 μs | 116.31 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 298.36 μs | 162.073 μs |  8.884 μs | 298.566 μs | 289.379 μs | 307.14 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  20.77 μs | 370.589 μs | 20.313 μs |  10.419 μs |   7.715 μs |  44.17 μs |  29.75 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 136.16 μs | 277.288 μs | 15.199 μs | 141.344 μs | 119.052 μs | 148.10 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 161.79 μs | 210.380 μs | 11.532 μs | 157.063 μs | 153.376 μs | 174.94 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  62.22 μs | 235.882 μs | 12.929 μs |  59.471 μs |  50.885 μs |  76.30 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 239.70 μs | 674.335 μs | 36.963 μs | 243.127 μs | 201.149 μs | 274.84 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.25 μs | 201.929 μs | 11.068 μs |   6.882 μs |   6.832 μs |  26.03 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  83.61 μs | 238.076 μs | 13.050 μs |  90.849 μs |  68.547 μs |  91.44 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 319.88 μs | 404.201 μs | 22.156 μs | 331.096 μs | 294.358 μs | 334.18 μs |  20.25 KB |
