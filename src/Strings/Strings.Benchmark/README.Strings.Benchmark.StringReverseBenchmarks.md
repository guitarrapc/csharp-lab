```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.32 μs** | **205.80 μs** | **11.281 μs** |  **10.921 μs** |  **10.700 μs** |  **30.35 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  80.19 μs | 418.23 μs | 22.924 μs |  69.450 μs |  64.601 μs | 106.51 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  59.46 μs | 755.31 μs | 41.401 μs |  38.873 μs |  32.391 μs | 107.12 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  20.37 μs | 185.85 μs | 10.187 μs |  14.758 μs |  14.227 μs |  32.13 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.30 μs | 234.69 μs | 12.864 μs |  47.834 μs |  45.951 μs |  69.11 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.00 μs | 174.67 μs |  9.574 μs |   7.655 μs |   7.294 μs |  24.05 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.66 μs | 286.96 μs | 15.729 μs |  27.933 μs |  27.221 μs |  54.81 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.60 μs** | **265.80 μs** | **14.569 μs** |   **9.397 μs** |   **8.986 μs** |  **34.42 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.52 μs | 348.04 μs | 19.077 μs | 299.280 μs | 288.610 μs | 325.67 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 152.95 μs |  48.95 μs |  2.683 μs | 153.982 μs | 149.905 μs | 154.97 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.79 μs | 209.58 μs | 11.488 μs |  61.486 μs |  52.017 μs |  74.88 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 246.27 μs | 574.06 μs | 31.466 μs | 248.556 μs | 213.730 μs | 276.54 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.82 μs | 240.77 μs | 13.197 μs |   8.285 μs |   8.115 μs |  31.06 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 101.10 μs | 605.94 μs | 33.214 μs |  82.344 μs |  81.513 μs | 139.45 μs |  68.69 KB |
