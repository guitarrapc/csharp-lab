```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.53 μs** | **144.472 μs** |  **7.919 μs** |   **8.161 μs** |   **7.750 μs** |  **21.67 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.42 μs | 170.525 μs |  9.347 μs |  85.229 μs |  70.773 μs |  88.27 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.07 μs | 232.055 μs | 12.720 μs |  38.468 μs |  22.317 μs |  47.41 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  19.08 μs | 136.280 μs |  7.470 μs |  20.628 μs |  10.960 μs |  25.66 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  57.19 μs | 273.419 μs | 14.987 μs |  48.791 μs |  48.280 μs |  74.49 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  17.71 μs | 250.912 μs | 13.753 μs |  10.088 μs |   9.448 μs |  33.58 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  46.26 μs | 303.143 μs | 16.616 μs |  36.849 μs |  36.478 μs |  65.44 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.60 μs** | **274.482 μs** | **15.045 μs** |   **9.348 μs** |   **8.487 μs** |  **34.97 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.10 μs | 279.592 μs | 15.325 μs | 298.651 μs | 287.139 μs | 317.50 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 150.75 μs |   6.253 μs |  0.343 μs | 150.713 μs | 150.432 μs | 151.11 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  98.86 μs | 519.391 μs | 28.470 μs | 101.490 μs |  69.160 μs | 125.92 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 234.88 μs | 529.982 μs | 29.050 μs | 232.227 μs | 207.250 μs | 265.17 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.97 μs | 193.809 μs | 10.623 μs |   9.086 μs |   8.586 μs |  27.23 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  89.37 μs | 702.510 μs | 38.507 μs |  67.286 μs |  66.985 μs | 133.83 μs |  68.69 KB |
