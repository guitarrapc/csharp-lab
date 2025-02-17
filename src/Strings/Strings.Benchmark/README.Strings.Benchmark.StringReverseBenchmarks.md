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
| Method                 | Runtime  | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **12.14 μs** |   **163.07 μs** |  **8.938 μs** |   **7.425 μs** |   **6.553 μs** |  **22.45 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  75.04 μs |   141.85 μs |  7.775 μs |  73.638 μs |  68.068 μs |  83.43 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  31.54 μs |   239.32 μs | 13.118 μs |  26.956 μs |  21.325 μs |  46.33 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  19.46 μs |   185.95 μs | 10.192 μs |  13.605 μs |  13.544 μs |  31.23 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  54.30 μs |   244.76 μs | 13.416 μs |  47.178 μs |  45.956 μs |  69.78 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.79 μs |   164.14 μs |  8.997 μs |   6.622 μs |   6.572 μs |  22.18 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  55.33 μs |   740.23 μs | 40.575 μs |  38.041 μs |  26.258 μs | 101.68 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  56.95 μs |    72.95 μs |  3.999 μs |  57.216 μs |  52.829 μs |  60.81 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  16.35 μs |   183.57 μs | 10.062 μs |  11.561 μs |   9.577 μs |  27.91 μs |   9.81 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  50.69 μs |   136.22 μs |  7.467 μs |  53.028 μs |  42.339 μs |  56.72 μs |  17.63 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  52.11 μs |   555.83 μs | 30.467 μs |  35.736 μs |  33.332 μs |  87.26 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  20.49 μs |   197.74 μs | 10.839 μs |  14.648 μs |  13.835 μs |  33.00 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  59.53 μs |   355.15 μs | 19.467 μs |  53.140 μs |  44.053 μs |  81.38 μs |  30.91 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  14.15 μs |   204.73 μs | 11.222 μs |   8.846 μs |   6.562 μs |  27.04 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  37.34 μs |   216.90 μs | 11.889 μs |  33.473 μs |  27.873 μs |  50.69 μs |  17.63 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  58.92 μs |    82.81 μs |  4.539 μs |  58.569 μs |  54.571 μs |  63.63 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.71 μs** |   **271.48 μs** | **14.881 μs** |   **8.530 μs** |   **7.719 μs** |  **33.89 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 350.73 μs | 1,078.14 μs | 59.096 μs | 319.336 μs | 313.947 μs | 418.89 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 165.42 μs |   259.71 μs | 14.236 μs | 172.182 μs | 149.059 μs | 175.01 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  62.13 μs |   219.78 μs | 12.047 μs |  61.450 μs |  50.440 μs |  74.50 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 243.21 μs |   530.67 μs | 29.088 μs | 246.765 μs | 212.502 μs | 270.35 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  15.58 μs |   268.64 μs | 14.725 μs |   7.204 μs |   6.953 μs |  32.58 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  84.85 μs |   550.45 μs | 30.172 μs |  68.329 μs |  66.544 μs | 119.67 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 302.67 μs |   183.42 μs | 10.054 μs | 298.998 μs | 294.971 μs | 314.05 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  17.49 μs |   251.28 μs | 13.774 μs |  11.245 μs |   7.939 μs |  33.28 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 122.13 μs |   195.00 μs | 10.688 μs | 118.212 μs | 113.963 μs | 134.23 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 158.25 μs |   249.27 μs | 13.664 μs | 153.297 μs | 147.746 μs | 173.69 μs | 560.55 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.31 μs |   191.05 μs | 10.472 μs |  60.432 μs |  51.306 μs |  72.20 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 234.85 μs |   395.09 μs | 21.656 μs | 226.695 μs | 218.450 μs | 259.40 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.99 μs |   217.24 μs | 11.908 μs |   7.284 μs |   6.954 μs |  27.74 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  76.02 μs |   269.09 μs | 14.750 μs |  67.607 μs |  67.406 μs |  93.05 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 308.36 μs |   102.18 μs |  5.601 μs | 311.313 μs | 301.905 μs | 311.87 μs |  19.97 KB |
