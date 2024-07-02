```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.52 μs** | **144.41 μs** |  **7.916 μs** |  **16.962 μs** |  **11.503 μs** |  **27.10 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  85.82 μs | 284.98 μs | 15.621 μs |  79.163 μs |  74.635 μs | 103.67 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  42.42 μs | 276.17 μs | 15.138 μs |  36.623 μs |  31.032 μs |  59.60 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.52 μs | 185.10 μs | 10.146 μs |  14.718 μs |  10.821 μs |  30.02 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.90 μs | 249.26 μs | 13.663 μs |  45.375 μs |  42.730 μs |  67.61 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.78 μs | 174.40 μs |  9.559 μs |   7.369 μs |   7.159 μs |  23.82 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.33 μs | 244.33 μs | 13.393 μs |  28.843 μs |  28.363 μs |  51.80 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.87 μs** | **315.66 μs** | **17.302 μs** |   **9.172 μs** |   **8.591 μs** |  **38.85 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 307.47 μs | 281.29 μs | 15.419 μs | 307.393 μs | 292.095 μs | 322.93 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 173.01 μs | 669.36 μs | 36.690 μs | 151.903 μs | 151.744 μs | 215.37 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  64.95 μs | 213.47 μs | 11.701 μs |  61.360 μs |  55.457 μs |  78.02 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 263.34 μs | 624.63 μs | 34.238 μs | 271.125 μs | 225.880 μs | 293.01 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.84 μs | 240.80 μs | 13.199 μs |   8.467 μs |   7.975 μs |  31.08 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  94.81 μs | 499.69 μs | 27.390 μs |  90.763 μs |  69.665 μs | 124.00 μs |  68.69 KB |
