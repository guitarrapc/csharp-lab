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
| Method                 | Runtime  | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **16.75 μs** |   **232.27 μs** | **12.732 μs** |   **9.708 μs** |   **9.097 μs** |  **31.45 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  72.19 μs |   170.94 μs |  9.370 μs |  70.763 μs |  63.620 μs |  82.19 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  41.43 μs |   254.43 μs | 13.946 μs |  35.957 μs |  31.058 μs |  57.29 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  23.29 μs |   298.29 μs | 16.350 μs |  13.957 μs |  13.746 μs |  42.17 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  56.23 μs |   228.79 μs | 12.541 μs |  48.992 μs |  48.992 μs |  70.71 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  12.52 μs |   153.64 μs |  8.422 μs |   8.907 μs |   6.502 μs |  22.14 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  47.32 μs |   297.52 μs | 16.308 μs |  38.142 μs |  37.660 μs |  66.14 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  67.73 μs |   104.20 μs |  5.712 μs |  70.081 μs |  61.214 μs |  71.89 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.91 μs |   139.77 μs |  7.661 μs |  10.730 μs |   6.581 μs |  21.43 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  62.33 μs |   157.89 μs |  8.655 μs |  64.050 μs |  52.949 μs |  70.00 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  32.93 μs |   331.69 μs | 18.181 μs |  25.048 μs |  20.018 μs |  53.72 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.50 μs |   142.55 μs |  7.814 μs |  14.007 μs |  10.239 μs |  25.26 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  52.55 μs |   241.52 μs | 13.239 μs |  50.544 μs |  40.425 μs |  66.67 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.32 μs |   159.72 μs |  8.755 μs |   6.332 μs |   6.202 μs |  21.43 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  38.08 μs |   233.36 μs | 12.791 μs |  33.212 μs |  28.433 μs |  52.59 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  58.58 μs |    68.00 μs |  3.727 μs |  58.599 μs |  54.842 μs |  62.30 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.62 μs** |   **272.00 μs** | **14.909 μs** |   **8.126 μs** |   **7.896 μs** |  **33.83 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 373.17 μs | 1,538.80 μs | 84.347 μs | 329.985 μs | 319.163 μs | 470.37 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 218.95 μs |   695.29 μs | 38.111 μs | 238.502 μs | 175.034 μs | 243.32 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  59.98 μs |   207.86 μs | 11.393 μs |  58.499 μs |  49.392 μs |  72.03 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 250.28 μs |   561.57 μs | 30.782 μs | 247.224 μs | 221.135 μs | 282.47 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  14.43 μs |   181.74 μs |  9.962 μs |   9.954 μs |   7.489 μs |  25.84 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  84.46 μs |   517.26 μs | 28.353 μs |  68.299 μs |  67.888 μs | 117.20 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 294.93 μs |   126.06 μs |  6.910 μs | 298.840 μs | 286.948 μs | 298.99 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  18.21 μs |   311.46 μs | 17.072 μs |   8.407 μs |   8.296 μs |  37.92 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 198.12 μs | 1,196.75 μs | 65.598 μs | 229.901 μs | 122.690 μs | 241.78 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 156.32 μs |   191.46 μs | 10.495 μs | 151.324 μs | 149.251 μs | 168.38 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  66.12 μs |   235.14 μs | 12.889 μs |  72.998 μs |  51.256 μs |  74.12 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 231.69 μs |   402.68 μs | 22.072 μs | 225.113 μs | 213.651 μs | 256.30 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  16.45 μs |   257.35 μs | 14.106 μs |   9.728 μs |   6.963 μs |  32.66 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  75.86 μs |   305.98 μs | 16.772 μs |  66.234 μs |  66.124 μs |  95.23 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 309.76 μs |   237.12 μs | 12.997 μs | 316.042 μs | 294.812 μs | 318.42 μs |  20.25 KB |
