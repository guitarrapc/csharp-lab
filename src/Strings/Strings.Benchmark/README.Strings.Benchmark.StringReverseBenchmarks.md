```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **12.51 μs** | **183.67 μs** | **10.068 μs** |   **6.712 μs** |   **6.682 μs** |  **24.14 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  97.32 μs | 350.12 μs | 19.191 μs |  97.161 μs |  78.216 μs | 116.60 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  32.65 μs | 265.00 μs | 14.525 μs |  27.576 μs |  21.334 μs |  49.03 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.37 μs | 142.85 μs |  7.830 μs |  14.037 μs |   9.979 μs |  25.11 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  53.26 μs | 215.34 μs | 11.804 μs |  46.612 μs |  46.282 μs |  66.89 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  12.94 μs | 155.04 μs |  8.498 μs |   9.367 μs |   6.812 μs |  22.64 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  44.22 μs | 264.76 μs | 14.512 μs |  51.536 μs |  27.501 μs |  53.61 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  65.67 μs | 112.18 μs |  6.149 μs |  65.328 μs |  59.706 μs |  71.99 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  11.42 μs | 156.45 μs |  8.576 μs |   6.522 μs |   6.412 μs |  21.32 μs |   9.81 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  43.94 μs |  90.61 μs |  4.966 μs |  42.459 μs |  39.875 μs |  49.47 μs |  17.63 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  29.99 μs | 250.85 μs | 13.750 μs |  24.124 μs |  20.138 μs |  45.70 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  19.83 μs | 186.17 μs | 10.205 μs |  14.232 μs |  13.640 μs |  31.60 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  48.63 μs | 237.75 μs | 13.032 μs |  41.156 μs |  41.057 μs |  63.68 μs |  30.91 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  14.06 μs | 216.70 μs | 11.878 μs |   7.995 μs |   6.433 μs |  27.74 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  41.52 μs | 146.17 μs |  8.012 μs |  44.062 μs |  32.550 μs |  47.96 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  66.64 μs | 106.40 μs |  5.832 μs |  66.495 μs |  60.884 μs |  72.55 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **22.21 μs** | **335.43 μs** | **18.386 μs** |  **11.733 μs** |  **11.462 μs** |  **43.44 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 307.81 μs | 275.07 μs | 15.077 μs | 306.082 μs | 293.668 μs | 323.67 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 149.09 μs |  10.80 μs |  0.592 μs | 149.214 μs | 148.441 μs | 149.60 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  62.17 μs | 238.60 μs | 13.079 μs |  59.145 μs |  50.870 μs |  76.50 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 246.93 μs | 582.75 μs | 31.942 μs | 234.037 μs | 223.457 μs | 283.31 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  17.44 μs | 239.85 μs | 13.147 μs |  10.099 μs |   9.608 μs |  32.62 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    | 102.53 μs | 498.32 μs | 27.315 μs |  95.849 μs |  79.178 μs | 132.57 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 297.76 μs | 198.11 μs | 10.859 μs | 298.889 μs | 286.385 μs | 308.02 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.06 μs | 264.07 μs | 14.475 μs |   7.715 μs |   7.684 μs |  32.77 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 121.10 μs | 274.98 μs | 15.073 μs | 112.620 μs | 112.169 μs | 138.50 μs |  37.94 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 155.32 μs |  23.39 μs |  1.282 μs | 155.320 μs | 154.038 μs | 156.60 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.31 μs | 219.24 μs | 12.017 μs |  59.441 μs |  50.344 μs |  74.16 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 259.53 μs | 584.40 μs | 32.033 μs | 250.944 μs | 232.660 μs | 294.98 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  18.66 μs | 275.26 μs | 15.088 μs |  10.220 μs |   9.678 μs |  36.08 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  76.42 μs | 231.43 μs | 12.686 μs |  71.194 μs |  67.176 μs |  90.88 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 317.55 μs | 439.48 μs | 24.089 μs | 315.960 μs | 294.290 μs | 342.39 μs |  20.25 KB |
