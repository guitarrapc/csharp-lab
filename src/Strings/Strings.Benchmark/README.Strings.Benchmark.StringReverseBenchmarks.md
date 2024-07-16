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
| **ArrayReverse**           | **10**     | **100**    |  **13.68 μs** | **190.85 μs** | **10.461 μs** |   **7.663 μs** |   **7.614 μs** |  **25.76 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  78.33 μs | 140.35 μs |  7.693 μs |  78.858 μs |  70.382 μs |  85.74 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.87 μs | 272.97 μs | 14.963 μs |  26.720 μs |  21.971 μs |  49.93 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  19.47 μs | 215.16 μs | 11.793 μs |  14.618 μs |  10.871 μs |  32.91 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.51 μs | 279.98 μs | 15.347 μs |  43.091 μs |  42.209 μs |  69.22 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.47 μs | 197.73 μs | 10.838 μs |   7.394 μs |   7.024 μs |  25.98 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  46.72 μs | 394.16 μs | 21.605 μs |  40.906 μs |  28.623 μs |  70.64 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.93 μs** | **384.10 μs** | **21.054 μs** |  **12.053 μs** |  **11.502 μs** |  **48.24 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 325.94 μs | 336.38 μs | 18.438 μs | 321.321 μs | 310.249 μs | 346.25 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 159.28 μs | 134.03 μs |  7.346 μs | 162.624 μs | 150.861 μs | 164.37 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  65.79 μs | 229.66 μs | 12.588 μs |  69.931 μs |  51.657 μs |  75.79 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.52 μs | 492.20 μs | 26.979 μs | 234.730 μs | 212.047 μs | 265.79 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.90 μs | 256.73 μs | 14.072 μs |  11.311 μs |  10.250 μs |  35.14 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 101.36 μs | 587.82 μs | 32.220 μs |  88.826 μs |  77.295 μs | 137.97 μs |  68.69 KB |
