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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **11.71 μs** | **161.78 μs** |  **8.868 μs** |   **6.702 μs** |   **6.482 μs** |  **21.95 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  83.04 μs | 196.11 μs | 10.749 μs |  80.109 μs |  74.068 μs |  94.96 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  31.11 μs | 250.41 μs | 13.726 μs |  25.401 μs |  21.165 μs |  46.77 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  15.90 μs | 137.17 μs |  7.519 μs |  13.591 μs |   9.803 μs |  24.30 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  61.81 μs | 324.15 μs | 17.768 μs |  52.559 μs |  50.575 μs |  82.29 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.75 μs | 170.18 μs |  9.328 μs |   6.451 μs |   6.281 μs |  22.52 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  36.08 μs | 281.83 μs | 15.448 μs |  27.321 μs |  27.010 μs |  53.92 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  56.09 μs |  64.06 μs |  3.511 μs |  56.300 μs |  52.483 μs |  59.50 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  13.03 μs | 160.61 μs |  8.804 μs |   9.638 μs |   6.422 μs |  23.02 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  53.29 μs | 206.17 μs | 11.301 μs |  49.977 μs |  44.017 μs |  65.88 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  34.52 μs | 259.76 μs | 14.239 μs |  35.035 μs |  20.027 μs |  48.49 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  21.37 μs | 167.15 μs |  9.162 μs |  18.595 μs |  13.915 μs |  31.60 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  51.59 μs | 247.44 μs | 13.563 μs |  43.992 μs |  43.521 μs |  67.25 μs |  30.91 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.74 μs | 175.62 μs |  9.626 μs |   6.332 μs |   6.032 μs |  22.85 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  34.90 μs | 134.46 μs |  7.370 μs |  33.092 μs |  28.594 μs |  43.00 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  59.69 μs | 211.25 μs | 11.580 μs |  55.077 μs |  51.120 μs |  72.86 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.34 μs** | **265.60 μs** | **14.558 μs** |   **8.227 μs** |   **7.655 μs** |  **33.15 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 302.63 μs | 306.93 μs | 16.824 μs | 307.993 μs | 283.779 μs | 316.12 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 149.31 μs |  28.04 μs |  1.537 μs | 148.808 μs | 148.095 μs | 151.04 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  61.59 μs | 215.30 μs | 11.802 μs |  59.691 μs |  50.845 μs |  74.22 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 238.79 μs | 520.40 μs | 28.525 μs | 242.702 μs | 208.508 μs | 265.15 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.70 μs | 198.89 μs | 10.902 μs |   7.580 μs |   7.229 μs |  26.28 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    | 105.60 μs | 544.35 μs | 29.838 μs |  88.795 μs |  87.954 μs | 140.05 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 300.86 μs | 169.91 μs |  9.313 μs | 304.988 μs | 290.200 μs | 307.40 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  23.69 μs | 400.50 μs | 21.953 μs |  11.691 μs |  10.359 μs |  49.03 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 130.75 μs | 188.58 μs | 10.337 μs | 134.249 μs | 119.121 μs | 138.89 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 150.60 μs | 225.50 μs | 12.360 μs | 144.370 μs | 142.597 μs | 164.84 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  76.56 μs | 440.60 μs | 24.151 μs |  69.329 μs |  56.855 μs | 103.50 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 238.44 μs | 578.98 μs | 31.736 μs | 250.441 μs | 202.452 μs | 262.42 μs |  87.94 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  14.22 μs | 186.03 μs | 10.197 μs |  10.165 μs |   6.678 μs |  25.82 μs |  15.28 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  80.57 μs | 240.74 μs | 13.196 μs |  80.710 μs |  67.304 μs |  93.69 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 322.05 μs | 192.30 μs | 10.541 μs | 325.706 μs | 310.167 μs | 330.27 μs |  20.25 KB |
