```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **18.07 μs** |   **178.91 μs** |  **9.806 μs** |  **15.418 μs** |   **9.868 μs** |  **28.93 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  84.48 μs |   390.09 μs | 21.382 μs |  83.636 μs |  63.528 μs | 106.27 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  42.69 μs |   271.12 μs | 14.861 μs |  37.039 μs |  31.489 μs |  59.55 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  22.83 μs |   184.71 μs | 10.125 μs |  19.627 μs |  14.686 μs |  34.16 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  59.21 μs |   288.61 μs | 15.820 μs |  56.696 μs |  44.793 μs |  76.13 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.64 μs |   160.63 μs |  8.805 μs |   6.638 μs |   6.477 μs |  21.81 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  51.04 μs |   534.23 μs | 29.283 μs |  41.076 μs |  28.042 μs |  84.01 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  66.34 μs |   103.86 μs |  5.693 μs |  66.915 μs |  60.382 μs |  71.72 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  17.82 μs |   188.33 μs | 10.323 μs |  12.373 μs |  11.361 μs |  29.73 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  62.27 μs |   465.78 μs | 25.531 μs |  51.436 μs |  43.942 μs |  91.43 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.16 μs |   241.51 μs | 13.238 μs |  24.696 μs |  20.528 μs |  45.26 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  17.33 μs |   137.20 μs |  7.520 μs |  17.192 μs |   9.878 μs |  24.92 μs |   9.81 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  50.82 μs |   252.81 μs | 13.857 μs |  43.321 μs |  42.319 μs |  66.81 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.57 μs |   167.26 μs |  9.168 μs |   6.333 μs |   6.212 μs |  22.15 μs |   5.13 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  55.28 μs |   257.84 μs | 14.133 μs |  49.524 μs |  44.935 μs |  71.38 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  56.96 μs |    59.46 μs |  3.259 μs |  56.706 μs |  53.841 μs |  60.34 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **17.56 μs** |   **264.06 μs** | **14.474 μs** |   **9.893 μs** |   **8.541 μs** |  **34.26 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 375.20 μs | 1,145.38 μs | 62.782 μs | 368.861 μs | 315.832 μs | 440.91 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 214.72 μs |   969.97 μs | 53.168 μs | 201.968 μs | 169.096 μs | 273.11 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  71.01 μs |   275.81 μs | 15.118 μs |  67.097 μs |  58.239 μs |  87.70 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 248.95 μs |   380.98 μs | 20.883 μs | 244.118 μs | 230.911 μs | 271.83 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  14.50 μs |   186.28 μs | 10.211 μs |   9.949 μs |   7.365 μs |  26.20 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    | 102.41 μs |   603.32 μs | 33.070 μs |  83.972 μs |  82.669 μs | 140.59 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 358.92 μs | 1,652.01 μs | 90.552 μs | 319.588 μs | 294.680 μs | 462.49 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  17.37 μs |   276.04 μs | 15.131 μs |   9.698 μs |   7.603 μs |  34.80 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 175.42 μs |   811.37 μs | 44.474 μs | 179.996 μs | 128.841 μs | 217.44 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 153.74 μs |   202.31 μs | 11.089 μs | 147.927 μs | 146.775 μs | 166.53 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  67.86 μs |   300.55 μs | 16.474 μs |  59.351 μs |  57.387 μs |  86.85 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 244.14 μs |   829.34 μs | 45.459 μs | 226.633 μs | 210.042 μs | 295.75 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  16.05 μs |   253.31 μs | 13.885 μs |   9.137 μs |   6.973 μs |  32.03 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  85.91 μs |   267.40 μs | 14.657 μs |  92.524 μs |  69.109 μs |  96.09 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 375.79 μs | 1,634.93 μs | 89.616 μs | 337.171 μs | 311.965 μs | 478.25 μs |  20.25 KB |
