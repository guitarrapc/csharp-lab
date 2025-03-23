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
| Method                 | Runtime  | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **12.88 μs** | **135.444 μs** |  **7.424 μs** |  **11.030 μs** |   **6.562 μs** |  **21.06 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  97.67 μs | 381.832 μs | 20.930 μs |  97.653 μs |  76.744 μs | 118.60 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  30.70 μs | 237.936 μs | 13.042 μs |  25.498 μs |  21.069 μs |  45.55 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.28 μs | 148.355 μs |  8.132 μs |  13.705 μs |   9.748 μs |  25.39 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  51.61 μs | 276.357 μs | 15.148 μs |  43.271 μs |  42.469 μs |  69.10 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  12.73 μs | 200.525 μs | 10.991 μs |   6.553 μs |   6.212 μs |  25.42 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  47.09 μs | 319.123 μs | 17.492 μs |  37.640 μs |  36.358 μs |  67.28 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  60.96 μs |  77.359 μs |  4.240 μs |  60.684 μs |  56.867 μs |  65.33 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  14.18 μs | 197.064 μs | 10.802 μs |   9.473 μs |   6.527 μs |  26.53 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  50.20 μs | 281.941 μs | 15.454 μs |  42.515 μs |  40.100 μs |  67.99 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  40.16 μs | 326.272 μs | 17.884 μs |  45.825 μs |  20.127 μs |  54.52 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.11 μs | 142.887 μs |  7.832 μs |  13.635 μs |   9.808 μs |  24.88 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  50.87 μs | 260.408 μs | 14.274 μs |  43.071 μs |  42.200 μs |  67.35 μs |  31.84 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  14.13 μs | 215.322 μs | 11.803 μs |   8.455 μs |   6.242 μs |  27.70 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  48.58 μs | 207.272 μs | 11.361 μs |  45.786 μs |  38.873 μs |  61.08 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  53.53 μs |  69.318 μs |  3.800 μs |  53.811 μs |  49.604 μs |  57.19 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.20 μs** | **265.069 μs** | **14.529 μs** |   **8.014 μs** |   **7.604 μs** |  **32.97 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 300.36 μs | 250.151 μs | 13.712 μs | 299.902 μs | 286.876 μs | 314.29 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 154.73 μs | 117.612 μs |  6.447 μs | 151.403 μs | 150.631 μs | 162.16 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  74.47 μs | 642.622 μs | 35.224 μs |  58.350 μs |  50.184 μs | 114.87 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 236.48 μs | 522.928 μs | 28.663 μs | 233.999 μs | 209.133 μs | 266.30 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.47 μs | 198.873 μs | 10.901 μs |   7.283 μs |   7.073 μs |  26.06 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  94.35 μs | 671.066 μs | 36.783 μs |  79.478 μs |  67.336 μs | 136.24 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 317.10 μs | 257.121 μs | 14.094 μs | 323.926 μs | 300.893 μs | 326.48 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  24.79 μs | 292.292 μs | 16.022 μs |  27.251 μs |   7.685 μs |  39.44 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 147.28 μs | 564.025 μs | 30.916 μs | 132.047 μs | 126.928 μs | 182.85 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 144.51 μs |   8.703 μs |  0.477 μs | 144.675 μs | 143.974 μs | 144.88 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  70.45 μs | 336.692 μs | 18.455 μs |  59.933 μs |  59.662 μs |  91.76 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 248.25 μs | 595.083 μs | 32.619 μs | 253.108 μs | 213.475 μs | 278.17 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  16.59 μs | 261.748 μs | 14.347 μs |   9.618 μs |   7.063 μs |  33.09 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  75.21 μs | 254.543 μs | 13.952 μs |  67.216 μs |  67.096 μs |  91.32 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 291.78 μs | 118.454 μs |  6.493 μs | 294.868 μs | 284.317 μs | 296.15 μs |  20.25 KB |
