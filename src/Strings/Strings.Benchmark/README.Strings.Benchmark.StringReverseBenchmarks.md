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
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **17.49 μs** | **222.39 μs** | **12.190 μs** |  **10.970 μs** |   **9.938 μs** |  **31.55 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  70.96 μs | 174.75 μs |  9.579 μs |  67.727 μs |  63.409 μs |  81.73 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  39.40 μs | 510.41 μs | 27.977 μs |  25.276 μs |  21.299 μs |  71.62 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.40 μs | 141.13 μs |  7.736 μs |  14.056 μs |  10.108 μs |  25.04 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  62.44 μs | 345.09 μs | 18.916 μs |  52.487 μs |  50.584 μs |  84.26 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  12.25 μs | 184.05 μs | 10.088 μs |   6.543 μs |   6.301 μs |  23.89 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  51.39 μs | 433.56 μs | 23.765 μs |  37.770 μs |  37.560 μs |  78.83 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  56.55 μs |  68.87 μs |  3.775 μs |  57.117 μs |  52.517 μs |  60.00 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  11.29 μs | 157.67 μs |  8.642 μs |   6.387 μs |   6.207 μs |  21.27 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  48.15 μs | 144.38 μs |  7.914 μs |  44.493 μs |  42.721 μs |  57.23 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  32.66 μs | 288.35 μs | 15.805 μs |  27.210 μs |  20.308 μs |  50.47 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.46 μs | 147.63 μs |  8.092 μs |  14.337 μs |   9.649 μs |  25.41 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  59.09 μs | 278.96 μs | 15.291 μs |  51.587 μs |  49.002 μs |  76.68 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  15.83 μs | 258.62 μs | 14.176 μs |   8.676 μs |   6.662 μs |  32.16 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  49.02 μs | 211.25 μs | 11.579 μs |  45.104 μs |  39.914 μs |  62.05 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  63.79 μs | 109.58 μs |  6.006 μs |  64.890 μs |  57.316 μs |  69.18 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.24 μs** | **264.29 μs** | **14.487 μs** |   **7.904 μs** |   **7.854 μs** |  **32.97 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 304.68 μs | 195.92 μs | 10.739 μs | 301.051 μs | 296.221 μs | 316.76 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 148.36 μs |  10.33 μs |  0.566 μs | 148.362 μs | 147.791 μs | 148.92 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  61.39 μs | 233.25 μs | 12.785 μs |  58.650 μs |  50.194 μs |  75.32 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 259.92 μs | 720.46 μs | 39.491 μs | 262.368 μs | 219.268 μs | 298.14 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  15.13 μs | 246.46 μs | 13.509 μs |   7.420 μs |   7.248 μs |  30.73 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    | 100.95 μs | 538.74 μs | 29.530 μs |  84.537 μs |  83.275 μs | 135.04 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 318.61 μs | 141.90 μs |  7.778 μs | 321.349 μs | 309.837 μs | 324.65 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.96 μs | 283.72 μs | 15.552 μs |   8.085 μs |   7.874 μs |  34.91 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 138.39 μs | 306.23 μs | 16.786 μs | 130.813 μs | 126.736 μs | 157.63 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 152.93 μs | 117.91 μs |  6.463 μs | 150.932 μs | 147.706 μs | 160.16 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.59 μs | 219.05 μs | 12.007 μs |  59.770 μs |  50.603 μs |  74.41 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 251.98 μs | 828.39 μs | 45.407 μs | 243.603 μs | 211.343 μs | 300.99 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  18.70 μs | 326.54 μs | 17.899 μs |   9.672 μs |   7.119 μs |  39.32 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  74.16 μs | 277.60 μs | 15.216 μs |  65.412 μs |  65.342 μs |  91.73 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 304.51 μs | 125.87 μs |  6.899 μs | 300.861 μs | 300.211 μs | 312.47 μs |  20.25 KB |
