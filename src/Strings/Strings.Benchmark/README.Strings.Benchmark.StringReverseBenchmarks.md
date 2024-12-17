```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.26 μs** | **166.73 μs** |  **9.139 μs** |   **6.998 μs** |   **6.978 μs** |  **22.82 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  72.88 μs | 594.99 μs | 32.613 μs |  55.719 μs |  52.434 μs | 110.49 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  31.25 μs | 258.37 μs | 14.162 μs |  25.358 μs |  20.990 μs |  47.41 μs |  33.25 KB |
| ReverseXor             | 10     | 100    |  20.51 μs | 196.82 μs | 10.788 μs |  14.322 μs |  14.242 μs |  32.97 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.78 μs | 230.19 μs | 12.617 μs |  51.307 μs |  42.590 μs |  67.46 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.51 μs | 210.33 μs | 11.529 μs |   7.134 μs |   6.583 μs |  26.82 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.26 μs | 156.87 μs |  8.598 μs |  32.581 μs |  28.314 μs |  44.87 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.48 μs** | **273.09 μs** | **14.969 μs** |   **9.322 μs** |   **8.370 μs** |  **34.76 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 126.57 μs | 237.96 μs | 13.043 μs | 119.584 μs | 118.503 μs | 141.62 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 142.49 μs |  15.93 μs |  0.873 μs | 142.428 μs | 141.656 μs | 143.40 μs | 560.59 KB |
| ReverseXor             | 64     | 100    |  63.69 μs | 227.93 μs | 12.493 μs |  61.084 μs |  52.709 μs |  77.28 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 228.44 μs | 528.99 μs | 28.996 μs | 224.171 μs | 201.820 μs | 259.34 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.54 μs | 202.23 μs | 11.085 μs |   8.636 μs |   7.664 μs |  27.33 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  90.05 μs | 308.53 μs | 16.912 μs |  81.012 μs |  79.570 μs | 109.56 μs |  38.22 KB |
