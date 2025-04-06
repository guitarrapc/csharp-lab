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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **11.63 μs** | **167.25 μs** |  **9.168 μs** |   **6.538 μs** |   **6.147 μs** |  **22.22 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  70.91 μs | 279.84 μs | 15.339 μs |  67.507 μs |  57.559 μs |  87.67 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  41.21 μs | 257.35 μs | 14.106 μs |  35.796 μs |  30.607 μs |  57.22 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  15.03 μs | 102.64 μs |  5.626 μs |  14.126 μs |   9.917 μs |  21.06 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  49.31 μs | 222.77 μs | 12.211 μs |  42.850 μs |  41.677 μs |  63.39 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.39 μs | 142.58 μs |  7.815 μs |   7.959 μs |   5.876 μs |  20.33 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  46.00 μs | 297.17 μs | 16.289 μs |  52.870 μs |  27.402 μs |  57.73 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  55.65 μs |  79.69 μs |  4.368 μs |  55.590 μs |  51.312 μs |  60.05 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  13.82 μs | 189.25 μs | 10.373 μs |   9.086 μs |   6.662 μs |  25.72 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  56.43 μs | 146.21 μs |  8.014 μs |  53.861 μs |  50.013 μs |  65.41 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  28.41 μs | 211.32 μs | 11.583 μs |  25.719 μs |  18.405 μs |  41.10 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  18.51 μs | 114.94 μs |  6.300 μs |  14.989 μs |  14.768 μs |  25.79 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  60.23 μs | 222.54 μs | 12.198 μs |  62.248 μs |  47.148 μs |  71.29 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.29 μs | 166.92 μs |  9.149 μs |   6.181 μs |   5.832 μs |  21.85 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  33.41 μs | 100.46 μs |  5.506 μs |  30.667 μs |  29.805 μs |  39.74 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  57.20 μs | 128.73 μs |  7.056 μs |  57.577 μs |  49.963 μs |  64.06 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **21.62 μs** | **310.99 μs** | **17.046 μs** |  **11.852 μs** |  **11.713 μs** |  **41.31 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 308.74 μs | 342.48 μs | 18.772 μs | 301.065 μs | 295.014 μs | 330.13 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 161.02 μs | 132.79 μs |  7.279 μs | 162.956 μs | 152.968 μs | 167.13 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  70.02 μs | 252.16 μs | 13.821 μs |  67.748 μs |  57.478 μs |  84.84 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 238.81 μs | 501.13 μs | 27.469 μs | 237.377 μs | 212.079 μs | 266.96 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  17.07 μs | 265.35 μs | 14.545 μs |  10.364 μs |   7.088 μs |  33.76 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  85.54 μs | 513.44 μs | 28.143 μs |  69.682 μs |  68.900 μs | 118.03 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 324.02 μs |  81.51 μs |  4.468 μs | 322.425 μs | 320.572 μs | 329.07 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  20.67 μs | 356.02 μs | 19.514 μs |  10.957 μs |   7.920 μs |  43.14 μs |  30.13 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 121.72 μs | 260.09 μs | 14.256 μs | 115.932 μs | 111.274 μs | 137.96 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 142.82 μs | 179.96 μs |  9.864 μs | 138.749 μs | 135.644 μs | 154.07 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  60.87 μs | 211.66 μs | 11.602 μs |  59.631 μs |  49.944 μs |  73.05 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 232.62 μs | 448.74 μs | 24.597 μs | 228.489 μs | 210.345 μs | 259.02 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  11.88 μs | 178.40 μs |  9.779 μs |   6.322 μs |   6.153 μs |  23.17 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  70.62 μs | 240.98 μs | 13.209 μs |  63.078 μs |  62.908 μs |  85.87 μs |  37.94 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 289.80 μs | 218.51 μs | 11.977 μs | 296.327 μs | 275.978 μs | 297.10 μs |  20.25 KB |
