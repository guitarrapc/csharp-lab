```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **12.81 μs** | **134.64 μs** |  **7.380 μs** |  **10.980 μs** |   **6.512 μs** |  **20.93 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  99.41 μs | 321.51 μs | 17.623 μs |  99.335 μs |  81.822 μs | 117.07 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  30.56 μs | 235.49 μs | 12.908 μs |  25.487 μs |  20.959 μs |  45.23 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.10 μs | 138.67 μs |  7.601 μs |  14.021 μs |   9.762 μs |  24.53 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  54.90 μs | 251.41 μs | 13.781 μs |  46.947 μs |  46.938 μs |  70.81 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.50 μs | 153.02 μs |  8.388 μs |   6.683 μs |   6.623 μs |  21.18 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  38.77 μs | 214.83 μs | 11.776 μs |  37.810 μs |  27.501 μs |  50.99 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  59.97 μs | 207.12 μs | 11.353 μs |  56.194 μs |  50.995 μs |  72.74 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.07 μs | 136.89 μs |  7.504 μs |   9.602 μs |   6.106 μs |  20.49 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  57.18 μs |  92.12 μs |  5.050 μs |  54.873 μs |  53.691 μs |  62.97 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  34.93 μs | 258.89 μs | 14.191 μs |  36.157 μs |  20.168 μs |  48.47 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  21.49 μs | 163.37 μs |  8.955 μs |  20.087 μs |  13.325 μs |  31.07 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  54.19 μs | 223.78 μs | 12.266 μs |  53.229 μs |  42.439 μs |  66.91 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  12.34 μs | 153.83 μs |  8.432 μs |   8.982 μs |   6.106 μs |  21.94 μs |   5.13 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  51.20 μs | 184.47 μs | 10.111 μs |  48.385 μs |  42.795 μs |  62.42 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  62.32 μs | 179.78 μs |  9.854 μs |  59.671 μs |  54.060 μs |  73.23 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.75 μs** | **263.51 μs** | **14.444 μs** |   **8.566 μs** |   **8.265 μs** |  **33.43 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 312.85 μs | 294.45 μs | 16.140 μs | 309.748 μs | 298.487 μs | 330.32 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 168.70 μs | 101.12 μs |  5.543 μs | 167.962 μs | 163.564 μs | 174.57 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  73.63 μs | 496.77 μs | 27.230 μs |  67.786 μs |  49.803 μs | 103.31 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 237.30 μs | 561.35 μs | 30.770 μs | 232.412 μs | 209.269 μs | 270.22 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  18.64 μs | 322.34 μs | 17.669 μs |  10.049 μs |   6.913 μs |  38.96 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  88.37 μs | 480.48 μs | 26.337 μs |  78.516 μs |  68.377 μs | 118.21 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 305.75 μs | 210.58 μs | 11.543 μs | 311.351 μs | 292.476 μs | 313.43 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.84 μs | 249.74 μs | 13.689 μs |  10.591 μs |   7.395 μs |  32.54 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 131.15 μs | 329.30 μs | 18.050 μs | 136.375 μs | 111.058 μs | 146.00 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 151.44 μs | 273.04 μs | 14.966 μs | 143.286 μs | 142.325 μs | 168.71 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.65 μs | 211.37 μs | 11.586 μs |  59.951 μs |  51.015 μs |  74.00 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 237.71 μs | 753.72 μs | 41.314 μs | 226.752 μs | 202.978 μs | 283.40 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  20.80 μs | 432.52 μs | 23.708 μs |   7.253 μs |   6.982 μs |  48.18 μs |  15.28 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  88.35 μs | 620.71 μs | 34.023 μs |  69.609 μs |  67.826 μs | 127.63 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 309.08 μs | 114.57 μs |  6.280 μs | 308.014 μs | 303.395 μs | 315.82 μs |  20.25 KB |
