```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.93 μs** |   **161.11 μs** |  **8.831 μs** |  **10.499 μs** |   **7.333 μs** |  **23.96 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  88.46 μs |   202.66 μs | 11.108 μs |  84.817 μs |  79.638 μs | 100.94 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  34.04 μs |   341.87 μs | 18.739 μs |  23.444 μs |  22.994 μs |  55.67 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.16 μs |   149.68 μs |  8.205 μs |  13.546 μs |  11.381 μs |  26.55 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  49.03 μs |   231.57 μs | 12.693 μs |  42.077 μs |  41.326 μs |  63.68 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.23 μs |   163.23 μs |  8.947 μs |   7.608 μs |   6.547 μs |  22.55 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  34.90 μs |   248.96 μs | 13.647 μs |  28.038 μs |  26.053 μs |  50.62 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **15.78 μs** |   **251.26 μs** | **13.773 μs** |   **7.936 μs** |   **7.714 μs** |  **31.68 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 291.74 μs |   258.96 μs | 14.194 μs | 289.669 μs | 278.698 μs | 306.86 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 181.61 μs |   172.93 μs |  9.479 μs | 186.627 μs | 170.679 μs | 187.53 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  58.02 μs |   212.60 μs | 11.653 μs |  56.205 μs |  47.389 μs |  70.48 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 228.27 μs |   526.51 μs | 28.860 μs | 242.470 μs | 195.062 μs | 247.28 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  13.51 μs |   192.24 μs | 10.537 μs |   7.573 μs |   7.283 μs |  25.68 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 106.66 μs | 1,087.91 μs | 59.632 μs |  76.282 μs |  68.337 μs | 175.37 μs |  68.69 KB |
