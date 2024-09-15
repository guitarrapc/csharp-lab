```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.33 μs** | **154.59 μs** |  **8.473 μs** |  **15.849 μs** |  **11.381 μs** |  **27.77 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.13 μs | 131.61 μs |  7.214 μs |  72.477 μs |  69.621 μs |  83.30 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.35 μs | 264.25 μs | 14.484 μs |  26.310 μs |  21.871 μs |  48.88 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.48 μs | 116.79 μs |  6.402 μs |  15.149 μs |  14.428 μs |  25.86 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.08 μs | 245.08 μs | 13.434 μs |  44.563 μs |  44.083 μs |  67.59 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.37 μs | 157.15 μs |  8.614 μs |   7.514 μs |   7.274 μs |  22.31 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.14 μs | 264.90 μs | 14.520 μs |  28.093 μs |  27.422 μs |  52.90 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.93 μs** | **258.96 μs** | **14.194 μs** |  **12.899 μs** |   **8.742 μs** |  **35.14 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 302.66 μs | 213.82 μs | 11.720 μs | 300.864 μs | 291.937 μs | 315.17 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 155.18 μs |  53.13 μs |  2.912 μs | 154.581 μs | 152.617 μs | 158.35 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.04 μs | 197.39 μs | 10.820 μs |  61.907 μs |  52.830 μs |  74.38 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.12 μs | 537.47 μs | 29.461 μs | 234.310 μs | 209.162 μs | 267.88 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.52 μs | 208.04 μs | 11.404 μs |   8.166 μs |   7.705 μs |  27.68 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  93.53 μs | 494.19 μs | 27.088 μs |  89.859 μs |  68.469 μs | 122.27 μs |  68.69 KB |
