```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.61 μs** | **175.10 μs** |  **9.598 μs** |  **10.469 μs** |   **7.784 μs** |  **25.59 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 104.55 μs | 200.18 μs | 10.972 μs | 100.277 μs |  96.360 μs | 117.02 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  44.26 μs | 292.50 μs | 16.033 μs |  37.250 μs |  32.932 μs |  62.61 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.58 μs | 144.80 μs |  7.937 μs |  15.158 μs |  11.140 μs |  26.45 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.84 μs | 320.27 μs | 17.555 μs |  42.710 μs |  42.709 μs |  73.12 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.11 μs | 177.35 μs |  9.721 μs |   7.625 μs |   7.375 μs |  24.34 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.72 μs | 260.18 μs | 14.261 μs |  27.537 μs |  27.427 μs |  52.18 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.21 μs** | **302.23 μs** | **16.566 μs** |   **9.959 μs** |   **9.328 μs** |  **38.33 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 307.72 μs | 379.94 μs | 20.826 μs | 298.517 μs | 293.077 μs | 331.56 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 155.16 μs |  73.15 μs |  4.010 μs | 156.481 μs | 150.651 μs | 158.34 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.07 μs | 227.79 μs | 12.486 μs |  60.462 μs |  50.464 μs |  75.28 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 242.86 μs | 575.28 μs | 31.533 μs | 240.118 μs | 212.787 μs | 275.67 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.93 μs | 245.74 μs | 13.470 μs |   8.315 μs |   7.984 μs |  31.48 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.48 μs | 558.33 μs | 30.604 μs |  71.753 μs |  67.936 μs | 122.75 μs |  68.69 KB |
