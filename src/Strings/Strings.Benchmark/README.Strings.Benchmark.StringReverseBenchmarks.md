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
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **12.96 μs** | **149.15 μs** |  **8.175 μs** |  **10.200 μs** |   **6.513 μs** |  **22.15 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    | 105.28 μs | 534.23 μs | 29.283 μs | 120.468 μs |  71.526 μs | 123.85 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  35.69 μs | 234.01 μs | 12.827 μs |  38.443 μs |  21.712 μs |  46.92 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.32 μs | 143.28 μs |  7.853 μs |  13.927 μs |   9.949 μs |  25.10 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  68.67 μs | 321.31 μs | 17.612 μs |  61.962 μs |  55.400 μs |  88.65 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  15.92 μs | 199.49 μs | 10.934 μs |  10.444 μs |   8.802 μs |  28.51 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  34.89 μs | 240.88 μs | 13.203 μs |  27.556 μs |  26.975 μs |  50.13 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  66.67 μs | 145.99 μs |  8.002 μs |  63.355 μs |  60.859 μs |  75.80 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  13.37 μs | 214.38 μs | 11.751 μs |   6.844 μs |   6.322 μs |  26.93 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  50.80 μs | 256.08 μs | 14.037 μs |  45.806 μs |  39.935 μs |  66.64 μs |  17.63 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  41.17 μs | 251.38 μs | 13.779 μs |  37.030 μs |  29.936 μs |  56.55 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.66 μs | 145.95 μs |  8.000 μs |  14.658 μs |   9.849 μs |  25.47 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  57.78 μs | 299.63 μs | 16.424 μs |  56.326 μs |  42.129 μs |  74.88 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  12.62 μs | 169.63 μs |  9.298 μs |   8.586 μs |   6.021 μs |  23.25 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  50.21 μs | 374.15 μs | 20.509 μs |  38.398 μs |  38.347 μs |  73.89 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  59.18 μs | 122.40 μs |  6.709 μs |  61.200 μs |  51.693 μs |  64.65 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **18.09 μs** | **255.24 μs** | **13.991 μs** |  **11.833 μs** |   **8.316 μs** |  **34.12 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 346.90 μs | 643.21 μs | 35.256 μs | 348.836 μs | 310.715 μs | 381.15 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 180.17 μs | 536.35 μs | 29.399 μs | 172.429 μs | 155.417 μs | 212.67 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  69.05 μs | 186.23 μs | 10.208 μs |  66.014 μs |  60.705 μs |  80.43 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 282.56 μs | 737.37 μs | 40.418 μs | 300.587 μs | 236.265 μs | 310.83 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  15.52 μs | 260.18 μs | 14.262 μs |   7.364 μs |   7.215 μs |  31.99 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  89.56 μs | 480.25 μs | 26.324 μs |  82.595 μs |  67.427 μs | 118.67 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 294.06 μs | 144.57 μs |  7.925 μs | 295.677 μs | 285.448 μs | 301.05 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  21.42 μs | 327.14 μs | 17.932 μs |  11.402 μs |  10.731 μs |  42.12 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 137.22 μs | 342.10 μs | 18.752 μs | 147.406 μs | 115.577 μs | 148.67 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 149.85 μs | 138.27 μs |  7.579 μs | 146.064 μs | 144.913 μs | 158.58 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  62.09 μs | 237.34 μs | 13.009 μs |  59.533 μs |  50.556 μs |  76.19 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 245.29 μs | 594.13 μs | 32.566 μs | 258.898 μs | 208.122 μs | 268.84 μs |  87.94 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.24 μs | 208.10 μs | 11.406 μs |   6.692 μs |   6.613 μs |  26.41 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  90.14 μs | 352.87 μs | 19.342 μs |  93.867 μs |  69.201 μs | 107.34 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 317.28 μs | 227.09 μs | 12.448 μs | 311.757 μs | 308.552 μs | 331.54 μs |  20.25 KB |
