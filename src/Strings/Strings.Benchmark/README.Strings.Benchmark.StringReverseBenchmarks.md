```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.63 μs** | **161.58 μs** |  **8.857 μs** |   **7.665 μs** |   **7.364 μs** |  **22.85 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  79.61 μs | 114.46 μs |  6.274 μs |  80.341 μs |  73.008 μs |  85.49 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.35 μs | 265.12 μs | 14.532 μs |  25.778 μs |  22.271 μs |  49.01 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  27.06 μs | 278.44 μs | 15.262 μs |  29.712 μs |  10.645 μs |  40.82 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  58.41 μs | 368.62 μs | 20.206 μs |  51.437 μs |  42.620 μs |  81.18 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.74 μs | 167.88 μs |  9.202 μs |   7.594 μs |   7.263 μs |  23.36 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.84 μs | 313.81 μs | 17.201 μs |  39.559 μs |  38.267 μs |  68.68 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.75 μs** | **299.29 μs** | **16.405 μs** |   **9.728 μs** |   **8.846 μs** |  **37.69 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 325.52 μs | 337.83 μs | 18.518 μs | 321.544 μs | 309.320 μs | 345.71 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 160.02 μs | 101.09 μs |  5.541 μs | 158.778 μs | 155.211 μs | 166.08 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.70 μs | 244.74 μs | 13.415 μs |  60.304 μs |  50.636 μs |  77.14 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 238.02 μs | 511.41 μs | 28.032 μs | 234.170 μs | 212.118 μs | 267.78 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.68 μs | 262.06 μs | 14.365 μs |  10.755 μs |  10.024 μs |  35.26 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  95.07 μs | 590.56 μs | 32.371 μs |  84.790 μs |  69.080 μs | 131.33 μs |  68.69 KB |
