```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.39 μs** | **237.40 μs** | **13.013 μs** |  **11.191 μs** |  **10.570 μs** |  **33.41 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  76.01 μs | 151.56 μs |  8.308 μs |  74.363 μs |  68.642 μs |  85.01 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  48.13 μs | 353.42 μs | 19.372 μs |  37.560 μs |  36.347 μs |  70.49 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.65 μs | 155.38 μs |  8.517 μs |  14.969 μs |  10.791 μs |  27.18 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.51 μs | 261.95 μs | 14.358 μs |  47.438 μs |  46.997 μs |  72.08 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.11 μs | 151.07 μs |  8.280 μs |   7.404 μs |   7.253 μs |  21.67 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  39.19 μs | 331.14 μs | 18.151 μs |  29.005 μs |  28.413 μs |  60.14 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.12 μs** | **265.77 μs** | **14.568 μs** |   **8.757 μs** |   **8.666 μs** |  **33.94 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 299.51 μs | 279.74 μs | 15.334 μs | 297.162 μs | 285.490 μs | 315.89 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 181.19 μs | 220.03 μs | 12.061 μs | 174.715 μs | 173.743 μs | 195.10 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  66.89 μs | 343.31 μs | 18.818 μs |  61.515 μs |  51.336 μs |  87.80 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.08 μs | 540.70 μs | 29.638 μs | 231.701 μs | 208.868 μs | 267.66 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.34 μs | 212.14 μs | 11.628 μs |   8.866 μs |   8.385 μs |  28.76 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.75 μs | 538.36 μs | 29.509 μs |  70.001 μs |  69.430 μs | 120.83 μs |  68.69 KB |
