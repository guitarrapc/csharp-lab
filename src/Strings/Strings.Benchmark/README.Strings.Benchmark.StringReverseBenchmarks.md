```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.95 μs** | **171.620 μs** |  **9.407 μs** |  **15.749 μs** |   **9.838 μs** |  **28.26 μs** |   **9.81 KB** |
| EnumerableReverse      | 10     | 100    |  48.15 μs | 219.212 μs | 12.016 μs |  43.521 μs |  39.142 μs |  61.80 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  32.78 μs | 253.480 μs | 13.894 μs |  27.911 μs |  21.971 μs |  48.45 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  28.83 μs | 446.890 μs | 24.496 μs |  15.008 μs |  14.376 μs |  57.12 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.09 μs | 253.233 μs | 13.881 μs |  43.511 μs |  42.639 μs |  67.11 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.88 μs | 177.778 μs |  9.745 μs |   9.608 μs |   6.993 μs |  25.03 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.48 μs | 189.813 μs | 10.404 μs |  46.698 μs |  39.084 μs |  59.66 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.09 μs** | **272.590 μs** | **14.942 μs** |   **8.657 μs** |   **8.276 μs** |  **34.34 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 136.73 μs | 214.750 μs | 11.771 μs | 142.871 μs | 123.154 μs | 144.15 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 144.23 μs |   8.665 μs |  0.475 μs | 144.469 μs | 143.678 μs | 144.53 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.57 μs | 212.432 μs | 11.644 μs |  59.833 μs |  50.885 μs |  73.98 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 229.64 μs | 541.697 μs | 29.692 μs | 226.352 μs | 201.726 μs | 260.84 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  13.88 μs | 193.490 μs | 10.606 μs |   7.865 μs |   7.655 μs |  26.13 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  99.62 μs | 319.982 μs | 17.539 μs | 104.434 μs |  80.179 μs | 114.25 μs |  38.22 KB |
