```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **19.07 μs** | **197.44 μs** | **10.822 μs** |  **15.599 μs** |  **10.418 μs** |  **31.21 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  74.92 μs | 231.71 μs | 12.701 μs |  70.453 μs |  65.051 μs |  89.25 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  31.63 μs | 245.84 μs | 13.475 μs |  26.174 μs |  21.745 μs |  46.98 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.36 μs | 228.95 μs | 12.549 μs |  14.116 μs |  14.106 μs |  35.85 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  50.99 μs | 244.93 μs | 13.425 μs |  43.280 μs |  43.200 μs |  66.49 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.06 μs | 152.02 μs |  8.333 μs |   7.343 μs |   7.153 μs |  21.68 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.17 μs | 290.03 μs | 15.898 μs |  28.398 μs |  27.587 μs |  55.52 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.51 μs** | **276.09 μs** | **15.134 μs** |   **9.007 μs** |   **8.547 μs** |  **34.99 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.28 μs | 291.03 μs | 15.952 μs | 302.844 μs | 289.089 μs | 320.90 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 159.31 μs |  26.59 μs |  1.458 μs | 159.448 μs | 157.785 μs | 160.69 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  71.25 μs | 304.92 μs | 16.714 μs |  66.525 μs |  57.407 μs |  89.82 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.66 μs | 494.54 μs | 27.107 μs | 233.886 μs | 211.053 μs | 265.05 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.98 μs | 218.71 μs | 11.988 μs |   8.185 μs |   7.934 μs |  28.82 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 113.86 μs | 527.97 μs | 28.940 μs | 124.914 μs |  81.022 μs | 135.64 μs |  68.69 KB |
