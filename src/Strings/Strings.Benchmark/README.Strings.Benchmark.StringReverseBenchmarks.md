```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.87 μs** | **196.380 μs** | **10.764 μs** |  **11.411 μs** |   **9.938 μs** |  **29.27 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.72 μs | 242.972 μs | 13.318 μs |  77.174 μs |  71.263 μs |  96.71 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.47 μs | 260.089 μs | 14.256 μs |  26.439 μs |  22.221 μs |  48.75 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  22.16 μs | 237.662 μs | 13.027 μs |  14.666 μs |  14.607 μs |  37.20 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  50.80 μs | 216.335 μs | 11.858 μs |  44.753 μs |  43.180 μs |  64.46 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  17.00 μs | 239.744 μs | 13.141 μs |   9.679 μs |   9.148 μs |  32.17 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  42.84 μs | 285.413 μs | 15.644 μs |  39.559 μs |  29.099 μs |  59.87 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.09 μs** | **350.520 μs** | **19.213 μs** |  **12.163 μs** |  **11.833 μs** |  **45.27 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 308.10 μs | 336.334 μs | 18.436 μs | 317.202 μs | 286.885 μs | 320.22 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 149.36 μs |   2.222 μs |  0.122 μs | 149.380 μs | 149.229 μs | 149.47 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.88 μs | 251.823 μs | 13.803 μs |  60.288 μs |  50.550 μs |  77.79 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 242.09 μs | 519.296 μs | 28.464 μs | 239.447 μs | 215.032 μs | 271.78 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.17 μs | 218.939 μs | 12.001 μs |   8.406 μs |   8.076 μs |  29.02 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.45 μs | 598.359 μs | 32.798 μs |  68.427 μs |  66.624 μs | 124.31 μs |  68.69 KB |
