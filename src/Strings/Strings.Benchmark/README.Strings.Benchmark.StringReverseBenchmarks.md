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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **12.08 μs** |   **171.60 μs** |  **9.406 μs** |   **6.702 μs** |   **6.601 μs** |  **22.94 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  74.90 μs |   160.95 μs |  8.822 μs |  72.115 μs |  67.806 μs |  84.78 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  32.08 μs |   256.86 μs | 14.080 μs |  26.394 μs |  21.735 μs |  48.12 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  20.17 μs |   182.72 μs | 10.015 μs |  14.476 μs |  14.307 μs |  31.74 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  61.96 μs |   305.51 μs | 16.746 μs |  53.361 μs |  51.267 μs |  81.26 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.94 μs |   175.66 μs |  9.629 μs |   6.466 μs |   6.298 μs |  23.06 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.92 μs |   263.26 μs | 14.430 μs |  27.947 μs |  27.245 μs |  52.58 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  58.81 μs |    79.78 μs |  4.373 μs |  59.051 μs |  54.322 μs |  63.06 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  14.45 μs |   202.85 μs | 11.119 μs |   9.684 μs |   6.506 μs |  27.16 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  46.68 μs |   100.18 μs |  5.491 μs |  47.455 μs |  40.842 μs |  51.74 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  41.71 μs |   181.27 μs |  9.936 μs |  40.024 μs |  32.721 μs |  52.38 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  21.46 μs |   219.01 μs | 12.005 μs |  14.737 μs |  14.316 μs |  35.32 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  51.37 μs |   271.50 μs | 14.882 μs |  43.021 μs |  42.529 μs |  68.55 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.37 μs |   155.61 μs |  8.530 μs |   6.782 μs |   6.112 μs |  21.21 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  36.98 μs |   183.03 μs | 10.032 μs |  33.823 μs |  28.903 μs |  48.21 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  65.79 μs |   285.91 μs | 15.672 μs |  61.063 μs |  53.019 μs |  83.28 μs |   9.81 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **23.33 μs** |   **362.60 μs** | **19.875 μs** |  **12.454 μs** |  **11.261 μs** |  **46.27 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 304.99 μs |   301.14 μs | 16.507 μs | 303.423 μs | 289.315 μs | 322.22 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 190.52 μs |   110.61 μs |  6.063 μs | 192.049 μs | 183.834 μs | 195.66 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    | 104.98 μs |   644.44 μs | 35.324 μs |  91.756 μs |  78.171 μs | 145.00 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 241.54 μs |   551.27 μs | 30.217 μs | 244.326 μs | 210.033 μs | 270.27 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  14.40 μs |   203.30 μs | 11.143 μs |   8.336 μs |   7.605 μs |  27.26 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  98.97 μs |   527.00 μs | 28.887 μs |  86.722 μs |  78.216 μs | 131.96 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 305.69 μs |   297.71 μs | 16.318 μs | 314.488 μs | 286.866 μs | 315.73 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  17.64 μs |   295.55 μs | 16.200 μs |   8.937 μs |   7.644 μs |  36.33 μs |  30.13 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 130.53 μs |   404.75 μs | 22.186 μs | 123.069 μs | 113.031 μs | 155.48 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 157.20 μs |   161.16 μs |  8.834 μs | 154.008 μs | 150.401 μs | 167.18 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  69.54 μs |   359.80 μs | 19.722 μs |  69.559 μs |  49.813 μs |  89.26 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 269.46 μs | 1,013.01 μs | 55.526 μs | 273.711 μs | 211.926 μs | 322.73 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.70 μs |   208.58 μs | 11.433 μs |   7.112 μs |   7.083 μs |  26.90 μs |  15.28 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  90.36 μs |   258.28 μs | 14.157 μs |  85.075 μs |  79.614 μs | 106.40 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 301.77 μs |   100.70 μs |  5.520 μs | 299.802 μs | 297.507 μs | 308.01 μs |  20.25 KB |
