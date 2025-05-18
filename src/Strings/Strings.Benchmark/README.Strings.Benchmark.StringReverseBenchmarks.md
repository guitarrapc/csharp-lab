```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **13.28 μs** |   **142.26 μs** |  **7.798 μs** |  **11.332 μs** |   **6.633 μs** |  **21.86 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  80.82 μs |   206.78 μs | 11.335 μs |  77.575 μs |  71.463 μs |  93.42 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  32.13 μs |   228.53 μs | 12.527 μs |  27.622 μs |  22.482 μs |  46.29 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  20.20 μs |   186.18 μs | 10.205 μs |  14.517 μs |  14.096 μs |  31.98 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  71.32 μs |   306.77 μs | 16.815 μs |  61.725 μs |  61.505 μs |  90.74 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.76 μs |   156.19 μs |  8.561 μs |   6.853 μs |   6.772 μs |  21.64 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  37.55 μs |   285.64 μs | 15.657 μs |  30.016 μs |  27.090 μs |  55.55 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  60.59 μs |    58.98 μs |  3.233 μs |  60.212 μs |  57.567 μs |  64.00 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.18 μs |   141.38 μs |  7.749 μs |   9.517 μs |   6.111 μs |  20.91 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  62.22 μs |   241.06 μs | 13.213 μs |  62.797 μs |  48.731 μs |  75.14 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  31.44 μs |   282.37 μs | 15.478 μs |  24.816 μs |  20.368 μs |  49.12 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.67 μs |   144.74 μs |  7.934 μs |  14.557 μs |  10.008 μs |  25.45 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  64.58 μs |   319.20 μs | 17.497 μs |  56.795 μs |  52.327 μs |  84.62 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  14.54 μs |   182.96 μs | 10.028 μs |   9.136 μs |   8.366 μs |  26.11 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  44.04 μs |   183.22 μs | 10.043 μs |  47.719 μs |  32.672 μs |  51.72 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  56.29 μs |    67.81 μs |  3.717 μs |  56.314 μs |  52.568 μs |  60.00 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.50 μs** |   **260.48 μs** | **14.278 μs** |   **8.506 μs** |   **8.005 μs** |  **32.98 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 310.02 μs |   299.57 μs | 16.421 μs | 309.212 μs | 294.024 μs | 326.83 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 148.70 μs |    23.93 μs |  1.312 μs | 148.266 μs | 147.654 μs | 150.17 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  59.55 μs |   208.64 μs | 11.436 μs |  57.478 μs |  49.283 μs |  71.87 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 235.04 μs |   451.96 μs | 24.774 μs | 233.706 μs | 210.964 μs | 260.46 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.65 μs |   189.80 μs | 10.403 μs |   7.705 μs |   7.575 μs |  25.66 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  85.62 μs |   511.17 μs | 28.019 μs |  70.022 μs |  68.879 μs | 117.97 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 416.64 μs | 1,405.20 μs | 77.024 μs | 460.999 μs | 327.701 μs | 461.22 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  17.16 μs |   298.41 μs | 16.357 μs |   7.944 μs |   7.494 μs |  36.05 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 126.85 μs |   255.72 μs | 14.017 μs | 119.353 μs | 118.171 μs | 143.02 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 149.20 μs |   227.02 μs | 12.444 μs | 142.672 μs | 141.379 μs | 163.55 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.51 μs |   240.42 μs | 13.178 μs |  58.428 μs |  50.154 μs |  75.96 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 240.60 μs |   505.38 μs | 27.701 μs | 244.632 μs | 211.110 μs | 266.07 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  15.90 μs |   243.79 μs | 13.363 μs |   9.337 μs |   7.093 μs |  31.28 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  82.67 μs |   434.15 μs | 23.797 μs |  69.129 μs |  68.729 μs | 110.15 μs |  37.94 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 300.19 μs |   255.16 μs | 13.986 μs | 299.579 μs | 286.525 μs | 314.48 μs |  20.25 KB |
