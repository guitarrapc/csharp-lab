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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **17.68 μs** | **155.74 μs** |  **8.537 μs** |  **15.779 μs** |  **10.258 μs** |  **27.01 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  72.93 μs | 146.41 μs |  8.025 μs |  71.329 μs |  65.829 μs |  81.64 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  31.68 μs | 268.61 μs | 14.723 μs |  25.378 μs |  21.150 μs |  48.50 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  19.92 μs | 180.51 μs |  9.894 μs |  14.276 μs |  14.146 μs |  31.35 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  51.94 μs | 210.92 μs | 11.561 μs |  47.689 μs |  43.100 μs |  65.02 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.64 μs | 163.14 μs |  8.942 μs |   6.723 μs |   6.232 μs |  21.96 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  41.74 μs | 465.80 μs | 25.532 μs |  27.030 μs |  26.970 μs |  71.22 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  57.80 μs |  87.09 μs |  4.774 μs |  60.412 μs |  52.288 μs |  60.69 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.78 μs | 139.03 μs |  7.621 μs |  10.899 μs |   6.281 μs |  21.17 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  45.32 μs |  95.60 μs |  5.240 μs |  45.324 μs |  40.084 μs |  50.56 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.44 μs | 245.78 μs | 13.472 μs |  25.183 μs |  20.393 μs |  45.75 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.35 μs | 143.74 μs |  7.879 μs |  14.476 μs |   9.577 μs |  25.00 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  50.13 μs | 254.92 μs | 13.973 μs |  42.790 μs |  41.357 μs |  66.24 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  13.00 μs | 172.47 μs |  9.453 μs |   8.888 μs |   6.302 μs |  23.82 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  50.34 μs | 406.85 μs | 22.301 μs |  48.551 μs |  28.983 μs |  73.48 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  57.13 μs |  82.83 μs |  4.540 μs |  59.232 μs |  51.917 μs |  60.23 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.25 μs** | **263.96 μs** | **14.468 μs** |   **8.095 μs** |   **7.694 μs** |  **32.95 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 315.65 μs | 291.23 μs | 15.963 μs | 316.402 μs | 299.330 μs | 331.23 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 187.22 μs | 172.15 μs |  9.436 μs | 184.636 μs | 179.345 μs | 197.68 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  68.26 μs | 133.26 μs |  7.304 μs |  69.880 μs |  60.284 μs |  74.62 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 265.29 μs | 611.67 μs | 33.528 μs | 265.447 μs | 231.684 μs | 298.74 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.39 μs | 192.02 μs | 10.525 μs |   7.424 μs |   7.194 μs |  25.54 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  87.45 μs | 515.47 μs | 28.255 μs |  76.743 μs |  66.114 μs | 119.49 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 299.12 μs | 127.48 μs |  6.988 μs | 302.104 μs | 291.135 μs | 304.12 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  21.11 μs | 368.27 μs | 20.186 μs |  11.000 μs |   7.974 μs |  44.35 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 124.03 μs | 299.76 μs | 16.431 μs | 117.219 μs | 112.109 μs | 142.78 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 161.50 μs | 247.02 μs | 13.540 μs | 154.349 μs | 153.026 μs | 177.11 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.86 μs | 231.18 μs | 12.672 μs |  59.341 μs |  50.634 μs |  75.60 μs |  30.13 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 243.17 μs | 351.75 μs | 19.281 μs | 232.445 μs | 231.633 μs | 265.43 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.45 μs | 198.07 μs | 10.857 μs |   7.524 μs |   6.842 μs |  25.98 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  87.46 μs | 544.11 μs | 29.825 μs |  73.727 μs |  66.975 μs | 121.68 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 331.13 μs | 137.25 μs |  7.523 μs | 334.556 μs | 322.503 μs | 336.33 μs |  19.97 KB |
