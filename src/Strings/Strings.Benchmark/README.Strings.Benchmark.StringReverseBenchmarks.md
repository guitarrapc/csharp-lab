```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **12.99 μs** | **166.47 μs** |  **9.125 μs** |   **8.195 μs** |   **7.263 μs** |  **23.51 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  94.83 μs | 202.16 μs | 11.081 μs |  96.275 μs |  83.100 μs | 105.12 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  33.06 μs | 268.03 μs | 14.692 μs |  27.006 μs |  22.357 μs |  49.81 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.62 μs | 148.00 μs |  8.112 μs |  14.237 μs |   9.969 μs |  25.66 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  69.31 μs | 497.88 μs | 27.291 μs |  54.342 μs |  52.779 μs | 100.81 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  21.71 μs | 205.17 μs | 11.246 μs |  25.248 μs |   9.117 μs |  30.76 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  41.24 μs | 446.88 μs | 24.495 μs |  27.337 μs |  26.864 μs |  69.53 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  68.59 μs | 142.31 μs |  7.800 μs |  72.606 μs |  59.602 μs |  73.57 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  18.56 μs | 257.46 μs | 14.112 μs |  11.081 μs |   9.759 μs |  34.84 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  64.70 μs | 219.30 μs | 12.020 μs |  68.939 μs |  51.136 μs |  74.03 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  64.59 μs | 656.94 μs | 36.009 μs |  71.814 μs |  25.517 μs |  96.44 μs |  33.25 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.89 μs | 156.79 μs |  8.594 μs |  14.747 μs |   9.578 μs |  26.36 μs |   9.81 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  64.03 μs | 351.08 μs | 19.244 μs |  53.981 μs |  51.898 μs |  86.22 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  14.61 μs | 250.69 μs | 13.741 μs |   6.692 μs |   6.662 μs |  30.48 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  35.23 μs | 137.75 μs |  7.550 μs |  33.434 μs |  28.734 μs |  43.51 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  62.53 μs | 154.94 μs |  8.493 μs |  61.124 μs |  54.822 μs |  71.63 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **17.82 μs** | **251.62 μs** | **13.792 μs** |  **11.471 μs** |   **8.345 μs** |  **33.64 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 307.41 μs | 253.58 μs | 13.900 μs | 306.825 μs | 293.810 μs | 321.59 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 161.07 μs |  33.48 μs |  1.835 μs | 160.421 μs | 159.639 μs | 163.14 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  62.58 μs | 232.53 μs | 12.746 μs |  60.584 μs |  50.946 μs |  76.20 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 240.60 μs | 445.39 μs | 24.413 μs | 235.161 μs | 219.361 μs | 267.27 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  15.45 μs | 204.62 μs | 11.216 μs |  10.359 μs |   7.674 μs |  28.30 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  92.22 μs | 453.40 μs | 24.853 μs |  89.507 μs |  68.839 μs | 118.32 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 347.05 μs | 583.23 μs | 31.969 μs | 331.762 μs | 325.589 μs | 383.79 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  22.19 μs | 355.57 μs | 19.490 μs |  11.250 μs |  10.629 μs |  44.69 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 121.90 μs | 261.91 μs | 14.356 μs | 114.375 μs | 112.862 μs | 138.45 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 155.29 μs | 105.10 μs |  5.761 μs | 154.418 μs | 150.020 μs | 161.44 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  76.70 μs | 234.26 μs | 12.841 μs |  73.808 μs |  65.552 μs |  90.74 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 237.36 μs | 364.97 μs | 20.005 μs | 226.904 μs | 224.751 μs | 260.43 μs |  87.94 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  20.40 μs | 427.71 μs | 23.444 μs |   6.862 μs |   6.862 μs |  47.47 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  87.91 μs | 481.54 μs | 26.395 μs |  77.275 μs |  68.489 μs | 117.96 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 297.81 μs | 131.09 μs |  7.186 μs | 301.313 μs | 289.541 μs | 302.57 μs |  20.25 KB |
