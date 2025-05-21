```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **16.56 μs** | **225.36 μs** | **12.353 μs** |   **9.688 μs** |   **9.166 μs** |  **30.82 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  69.29 μs | 146.69 μs |  8.040 μs |  67.255 μs |  62.466 μs |  78.16 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  36.01 μs | 239.17 μs | 13.110 μs |  40.276 μs |  21.300 μs |  46.46 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.04 μs | 137.35 μs |  7.529 μs |  13.976 μs |   9.758 μs |  24.39 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  55.94 μs | 311.09 μs | 17.052 μs |  46.727 μs |  45.484 μs |  75.62 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  13.00 μs | 162.17 μs |  8.889 μs |   9.127 μs |   6.712 μs |  23.17 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.16 μs | 261.46 μs | 14.331 μs |  27.030 μs |  26.739 μs |  51.71 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  58.62 μs |  59.59 μs |  3.266 μs |  59.049 μs |  55.163 μs |  61.65 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  13.67 μs | 115.51 μs |  6.332 μs |  10.549 μs |   9.508 μs |  20.96 μs |   9.81 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  51.25 μs | 156.40 μs |  8.573 μs |  50.013 μs |  43.361 μs |  60.37 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  43.50 μs | 455.07 μs | 24.944 μs |  33.572 μs |  25.056 μs |  71.88 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  19.57 μs | 191.27 μs | 10.484 μs |  13.616 μs |  13.425 μs |  31.68 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  51.56 μs | 287.00 μs | 15.732 μs |  42.660 μs |  42.290 μs |  69.72 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.28 μs | 160.05 μs |  8.773 μs |   6.332 μs |   6.101 μs |  21.41 μs |   5.13 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  36.67 μs | 180.84 μs |  9.912 μs |  33.171 μs |  28.984 μs |  47.86 μs |  17.63 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  54.78 μs |  68.10 μs |  3.733 μs |  54.461 μs |  51.225 μs |  58.67 μs |   9.81 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.40 μs** | **262.67 μs** | **14.398 μs** |   **8.205 μs** |   **7.964 μs** |  **33.02 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 304.98 μs | 351.74 μs | 19.280 μs | 314.221 μs | 282.824 μs | 317.91 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 161.84 μs | 264.95 μs | 14.523 μs | 158.470 μs | 149.304 μs | 177.76 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  60.73 μs | 198.89 μs | 10.902 μs |  59.100 μs |  50.735 μs |  72.36 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 263.04 μs | 526.69 μs | 28.869 μs | 271.837 μs | 230.800 μs | 286.49 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  15.34 μs | 255.21 μs | 13.989 μs |   7.345 μs |   7.174 μs |  31.49 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    | 103.08 μs | 469.16 μs | 25.716 μs |  98.760 μs |  79.805 μs | 130.69 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 306.25 μs | 115.49 μs |  6.331 μs | 309.388 μs | 298.959 μs | 310.39 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  22.37 μs | 413.13 μs | 22.645 μs |  11.060 μs |   7.604 μs |  48.44 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 147.51 μs | 276.52 μs | 15.157 μs | 148.838 μs | 131.736 μs | 161.96 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 141.07 μs |  12.20 μs |  0.669 μs | 140.893 μs | 140.502 μs | 141.81 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  72.83 μs | 465.38 μs | 25.509 μs |  59.000 μs |  57.227 μs | 102.27 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 245.16 μs | 672.96 μs | 36.887 μs | 263.823 μs | 202.669 μs | 268.98 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.27 μs | 199.71 μs | 10.947 μs |   6.973 μs |   6.924 μs |  25.91 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  82.82 μs | 269.49 μs | 14.772 μs |  90.258 μs |  65.812 μs |  92.40 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 290.22 μs | 127.09 μs |  6.966 μs | 292.917 μs | 282.307 μs | 295.43 μs |  20.25 KB |
