```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.81 μs** | **164.213 μs** |  **9.001 μs** |   **7.700 μs** |   **7.519 μs** |  **23.20 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  84.48 μs | 277.145 μs | 15.191 μs |  78.136 μs |  73.497 μs | 101.82 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  43.16 μs | 287.501 μs | 15.759 μs |  36.938 μs |  31.468 μs |  61.08 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.36 μs | 151.199 μs |  8.288 μs |  14.346 μs |  11.010 μs |  26.74 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.99 μs | 202.846 μs | 11.119 μs |  54.322 μs |  42.711 μs |  64.94 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.18 μs | 155.229 μs |  8.509 μs |   9.152 μs |   7.439 μs |  22.96 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  38.16 μs | 293.314 μs | 16.078 μs |  28.924 μs |  28.834 μs |  56.73 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.55 μs** | **269.040 μs** | **14.747 μs** |   **9.043 μs** |   **9.031 μs** |  **34.58 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 316.35 μs | 265.499 μs | 14.553 μs | 314.327 μs | 302.915 μs | 331.81 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 149.47 μs |   1.592 μs |  0.087 μs | 149.450 μs | 149.399 μs | 149.57 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.59 μs | 220.158 μs | 12.068 μs |  60.603 μs |  50.053 μs |  74.13 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 262.76 μs | 691.786 μs | 37.919 μs | 276.037 μs | 219.982 μs | 292.25 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.66 μs | 264.687 μs | 14.508 μs |  10.450 μs |   8.176 μs |  34.37 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 100.64 μs | 847.261 μs | 46.441 μs |  79.788 μs |  68.287 μs | 153.86 μs |  68.69 KB |
