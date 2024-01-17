```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **15.33 μs** | **174.90 μs** |  **9.587 μs** |  **12.384 μs** |   **7.555 μs** |  **26.04 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  78.05 μs | 148.03 μs |  8.114 μs |  80.670 μs |  68.947 μs |  84.53 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.65 μs | 361.72 μs | 19.827 μs |  28.424 μs |  26.029 μs |  61.50 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.81 μs | 148.62 μs |  8.146 μs |  15.188 μs |  11.291 μs |  26.94 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  59.42 μs | 296.72 μs | 16.264 μs |  54.532 μs |  46.156 μs |  77.56 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.75 μs | 165.93 μs |  9.095 μs |   7.544 μs |   7.453 μs |  23.25 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  47.62 μs | 296.49 μs | 16.252 μs |  39.143 μs |  37.369 μs |  66.36 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.49 μs** | **252.20 μs** | **13.824 μs** |  **12.159 μs** |   **8.972 μs** |  **34.35 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 299.33 μs | 299.58 μs | 16.421 μs | 297.844 μs | 283.709 μs | 316.45 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 176.85 μs |  65.87 μs |  3.611 μs | 174.935 μs | 174.604 μs | 181.02 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.23 μs | 225.53 μs | 12.362 μs |  61.474 μs |  51.846 μs |  76.38 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 241.20 μs | 575.21 μs | 31.529 μs | 236.349 μs | 212.375 μs | 274.87 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  19.28 μs | 283.15 μs | 15.520 μs |  11.020 μs |   9.628 μs |  37.18 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.65 μs | 538.84 μs | 29.536 μs |  68.858 μs |  68.337 μs | 119.75 μs |  68.69 KB |
