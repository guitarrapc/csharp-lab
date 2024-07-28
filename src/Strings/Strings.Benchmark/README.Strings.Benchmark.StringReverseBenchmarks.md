```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.42 μs** | **183.09 μs** | **10.036 μs** |   **7.695 μs** |   **7.555 μs** |  **25.01 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  78.38 μs | 129.91 μs |  7.121 μs |  76.743 μs |  72.225 μs |  86.18 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  44.41 μs | 292.67 μs | 16.042 μs |  38.241 μs |  32.360 μs |  62.62 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.65 μs | 158.58 μs |  8.693 μs |  14.647 μs |  10.850 μs |  27.44 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.57 μs | 236.98 μs | 12.990 μs |  44.568 μs |  43.587 μs |  66.56 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.99 μs | 274.49 μs | 15.046 μs |   9.308 μs |   7.335 μs |  34.33 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  49.62 μs | 265.87 μs | 14.573 μs |  41.268 μs |  41.137 μs |  66.44 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.34 μs** | **273.84 μs** | **15.010 μs** |   **8.726 μs** |   **8.627 μs** |  **34.67 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 314.41 μs | 280.44 μs | 15.372 μs | 312.121 μs | 300.310 μs | 330.80 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 166.57 μs | 523.00 μs | 28.667 μs | 150.181 μs | 149.860 μs | 199.67 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  72.44 μs | 311.89 μs | 17.096 μs |  68.417 μs |  57.717 μs |  91.19 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 254.25 μs | 588.55 μs | 32.261 μs | 254.494 μs | 221.874 μs | 286.39 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.93 μs | 269.49 μs | 14.772 μs |  10.605 μs |  10.195 μs |  35.98 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.70 μs | 574.25 μs | 31.477 μs |  68.217 μs |  66.844 μs | 122.04 μs |  68.69 KB |
