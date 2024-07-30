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
| **ArrayReverse**           | **10**     | **100**    |  **14.25 μs** | **178.94 μs** |  **9.809 μs** |   **9.297 μs** |   **7.905 μs** |  **25.55 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  86.10 μs | 250.94 μs | 13.755 μs |  80.870 μs |  75.721 μs | 101.70 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.96 μs | 248.80 μs | 13.637 μs |  27.462 μs |  22.933 μs |  48.49 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.27 μs | 202.45 μs | 11.097 μs |  15.449 μs |  14.288 μs |  34.06 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.51 μs | 235.71 μs | 12.920 μs |  47.147 μs |  46.956 μs |  69.43 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.07 μs | 191.33 μs | 10.488 μs |   8.585 μs |   7.454 μs |  26.16 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.82 μs | 264.66 μs | 14.507 μs |  29.755 μs |  29.144 μs |  54.57 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.47 μs** | **261.36 μs** | **14.326 μs** |  **11.722 μs** |   **8.766 μs** |  **34.92 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 298.62 μs | 273.66 μs | 15.000 μs | 296.862 μs | 284.580 μs | 314.43 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 159.21 μs |  87.99 μs |  4.823 μs | 160.119 μs | 153.998 μs | 163.51 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.42 μs | 229.91 μs | 12.602 μs |  61.204 μs |  50.475 μs |  75.59 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 250.74 μs | 579.57 μs | 31.768 μs | 247.251 μs | 220.862 μs | 284.11 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.36 μs | 252.37 μs | 13.833 μs |   8.776 μs |   7.984 μs |  32.33 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  94.04 μs | 628.21 μs | 34.434 μs |  81.581 μs |  67.566 μs | 132.97 μs |  68.69 KB |
