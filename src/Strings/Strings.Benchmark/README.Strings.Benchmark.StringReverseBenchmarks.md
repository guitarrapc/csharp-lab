```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error       | StdDev     | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|------------:|-----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **17.38 μs** |   **164.95 μs** |   **9.041 μs** |  **14.386 μs** |  **10.219 μs** |  **27.54 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  71.85 μs |   222.46 μs |  12.194 μs |  67.087 μs |  62.748 μs |  85.70 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  39.61 μs |   351.01 μs |  19.240 μs |  31.298 μs |  25.918 μs |  61.60 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.67 μs |   148.07 μs |   8.116 μs |  14.267 μs |  10.030 μs |  25.72 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  51.41 μs |   254.97 μs |  13.976 μs |  43.676 μs |  43.005 μs |  67.54 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  13.79 μs |   172.93 μs |   9.479 μs |   8.486 μs |   8.155 μs |  24.74 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.80 μs |   259.07 μs |  14.200 μs |  27.902 μs |  27.311 μs |  52.20 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  55.63 μs |    72.85 μs |   3.993 μs |  56.205 μs |  51.386 μs |  59.31 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  14.74 μs |   205.98 μs |  11.290 μs |   9.789 μs |   6.774 μs |  27.66 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  56.69 μs |   297.47 μs |  16.306 μs |  52.127 μs |  43.151 μs |  74.79 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  29.75 μs |   241.05 μs |  13.213 μs |  24.264 μs |  20.167 μs |  44.82 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  17.83 μs |   172.51 μs |   9.456 μs |  14.267 μs |  10.680 μs |  28.55 μs |   9.81 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  59.05 μs |   385.93 μs |  21.154 μs |  49.092 μs |  44.714 μs |  83.35 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.71 μs |   164.14 μs |   8.997 μs |   6.963 μs |   6.071 μs |  22.08 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  44.32 μs |   299.03 μs |  16.391 μs |  37.589 μs |  32.370 μs |  63.01 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  64.21 μs |   158.89 μs |   8.709 μs |  62.001 μs |  56.822 μs |  73.81 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **23.87 μs** |   **380.69 μs** |  **20.867 μs** |  **11.827 μs** |  **11.817 μs** |  **47.97 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 310.24 μs |   280.62 μs |  15.382 μs | 306.964 μs | 296.755 μs | 326.99 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 163.58 μs |   132.61 μs |   7.269 μs | 160.521 μs | 158.347 μs | 171.88 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  69.50 μs |   252.56 μs |  13.844 μs |  62.798 μs |  60.284 μs |  85.42 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 330.54 μs | 1,896.11 μs | 103.932 μs | 365.604 μs | 213.609 μs | 412.40 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.54 μs |   202.89 μs |  11.121 μs |   7.233 μs |   7.003 μs |  26.38 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  86.40 μs |   518.39 μs |  28.415 μs |  70.397 μs |  69.595 μs | 119.21 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 294.29 μs |   214.87 μs |  11.778 μs | 296.354 μs | 281.617 μs | 304.90 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.73 μs |   272.89 μs |  14.958 μs |   8.155 μs |   8.035 μs |  34.00 μs |  30.13 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 130.88 μs |   537.91 μs |  29.485 μs | 114.194 μs | 113.513 μs | 164.92 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 144.73 μs |    11.33 μs |   0.621 μs | 144.726 μs | 144.106 μs | 145.35 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  63.24 μs |   276.35 μs |  15.148 μs |  58.480 μs |  51.037 μs |  80.19 μs |  30.13 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 244.24 μs |   660.35 μs |  36.196 μs | 256.901 μs | 203.411 μs | 272.40 μs |  87.94 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.40 μs |   197.32 μs |  10.816 μs |   7.353 μs |   6.963 μs |  25.89 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  87.41 μs |   331.01 μs |  18.144 μs |  94.311 μs |  66.831 μs | 101.09 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 301.97 μs |   393.72 μs |  21.581 μs | 296.626 μs | 283.560 μs | 325.72 μs |  20.25 KB |
