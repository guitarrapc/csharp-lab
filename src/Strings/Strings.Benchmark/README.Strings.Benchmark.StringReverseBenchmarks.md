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
| **ArrayReverse**           | **10**     | **100**    |  **18.75 μs** | **199.82 μs** | **10.953 μs** |  **14.978 μs** |  **10.178 μs** |  **31.09 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  84.57 μs | 223.07 μs | 12.227 μs |  78.036 μs |  76.994 μs |  98.67 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.43 μs | 264.46 μs | 14.496 μs |  26.009 μs |  22.262 μs |  49.03 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.28 μs | 170.40 μs |  9.340 μs |  14.868 μs |  11.120 μs |  28.84 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.50 μs | 268.30 μs | 14.706 μs |  43.786 μs |  42.264 μs |  68.46 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.15 μs | 180.20 μs |  9.878 μs |   7.699 μs |   7.197 μs |  24.55 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  50.61 μs | 318.17 μs | 17.440 μs |  41.572 μs |  39.550 μs |  70.72 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.06 μs** | **280.56 μs** | **15.379 μs** |   **9.307 μs** |   **9.056 μs** |  **35.82 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 311.33 μs | 330.03 μs | 18.090 μs | 315.792 μs | 291.427 μs | 326.77 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 156.73 μs | 106.19 μs |  5.821 μs | 158.412 μs | 150.256 μs | 161.53 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  72.15 μs | 301.68 μs | 16.536 μs |  67.647 μs |  58.330 μs |  90.47 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 238.77 μs | 493.05 μs | 27.026 μs | 236.693 μs | 212.838 μs | 266.77 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.68 μs | 207.96 μs | 11.399 μs |   8.256 μs |   7.946 μs |  27.84 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 102.04 μs | 660.82 μs | 36.222 μs |  83.217 μs |  79.109 μs | 143.80 μs |  68.69 KB |
