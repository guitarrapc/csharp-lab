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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **12.86 μs** | **133.94 μs** |  **7.342 μs** |  **10.791 μs** |   **6.783 μs** |  **21.02 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  82.88 μs | 191.85 μs | 10.516 μs |  81.734 μs |  72.977 μs |  93.92 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  31.01 μs | 241.06 μs | 13.213 μs |  25.717 μs |  21.259 μs |  46.05 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  15.06 μs | 162.33 μs |  8.898 μs |  10.028 μs |   9.827 μs |  25.34 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  53.57 μs | 256.17 μs | 14.042 μs |  45.545 μs |  45.374 μs |  69.78 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.86 μs | 158.58 μs |  8.692 μs |   7.113 μs |   6.572 μs |  21.89 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.80 μs | 267.15 μs | 14.643 μs |  27.616 μs |  27.076 μs |  52.70 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  60.27 μs |  83.62 μs |  4.584 μs |  60.297 μs |  55.669 μs |  64.84 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  13.02 μs | 146.16 μs |  8.012 μs |  11.010 μs |   6.211 μs |  21.85 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  50.01 μs | 185.96 μs | 10.193 μs |  55.764 μs |  38.241 μs |  56.02 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  36.29 μs | 200.02 μs | 10.964 μs |  35.998 μs |  25.468 μs |  47.39 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  17.04 μs | 164.58 μs |  9.021 μs |  14.487 μs |   9.569 μs |  27.06 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  50.57 μs | 303.21 μs | 16.620 μs |  41.579 μs |  40.387 μs |  69.75 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  13.21 μs | 215.34 μs | 11.803 μs |   6.493 μs |   6.302 μs |  26.84 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  36.50 μs | 122.92 μs |  6.738 μs |  33.207 μs |  32.035 μs |  44.25 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  62.38 μs | 188.02 μs | 10.306 μs |  59.382 μs |  53.901 μs |  73.85 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.39 μs** | **258.55 μs** | **14.172 μs** |   **8.326 μs** |   **8.086 μs** |  **32.75 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 333.96 μs | 112.37 μs |  6.159 μs | 331.919 μs | 329.075 μs | 340.88 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 161.03 μs | 213.82 μs | 11.720 μs | 156.002 μs | 152.666 μs | 174.43 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  62.02 μs | 234.68 μs | 12.864 μs |  59.440 μs |  50.634 μs |  75.97 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 238.79 μs | 547.61 μs | 30.016 μs | 235.210 μs | 210.723 μs | 270.44 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.56 μs | 194.72 μs | 10.673 μs |   7.643 μs |   7.152 μs |  25.88 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    | 110.90 μs | 429.45 μs | 23.539 μs | 104.626 μs |  91.139 μs | 136.94 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 315.65 μs | 347.99 μs | 19.075 μs | 317.314 μs | 295.804 μs | 333.85 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  18.02 μs | 262.12 μs | 14.368 μs |  11.703 μs |   7.895 μs |  34.47 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 129.60 μs | 264.79 μs | 14.514 μs | 121.677 μs | 120.775 μs | 146.35 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 152.53 μs | 275.21 μs | 15.085 μs | 145.371 μs | 142.366 μs | 169.87 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.25 μs | 212.90 μs | 11.670 μs |  59.697 μs |  50.440 μs |  73.62 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 237.00 μs | 687.71 μs | 37.695 μs | 227.486 μs | 204.973 μs | 278.54 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  21.98 μs | 241.75 μs | 13.251 μs |  27.843 μs |   6.803 μs |  31.28 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  99.10 μs | 475.89 μs | 26.085 μs | 112.911 μs |  69.018 μs | 115.39 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 330.97 μs | 115.77 μs |  6.346 μs | 332.292 μs | 324.066 μs | 336.55 μs |  19.97 KB |
