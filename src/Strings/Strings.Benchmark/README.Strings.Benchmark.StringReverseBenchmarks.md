```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.94 μs** | **177.23 μs** |  **9.714 μs** |  **14.613 μs** |  **10.325 μs** |  **28.88 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.12 μs | 267.58 μs | 14.667 μs |  75.606 μs |  73.734 μs | 100.02 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.55 μs | 254.02 μs | 13.924 μs |  26.930 μs |  22.322 μs |  48.41 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.01 μs | 208.20 μs | 11.412 μs |  14.772 μs |  14.071 μs |  34.18 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.47 μs | 325.96 μs | 17.867 μs |  51.933 μs |  50.390 μs |  82.08 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.85 μs | 233.92 μs | 12.822 μs |   9.598 μs |   9.307 μs |  31.66 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.19 μs | 246.62 μs | 13.518 μs |  28.464 μs |  28.304 μs |  51.80 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.37 μs** | **295.07 μs** | **16.174 μs** |   **9.378 μs** |   **8.687 μs** |  **37.04 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 303.70 μs | 259.13 μs | 14.204 μs | 299.521 μs | 292.047 μs | 319.52 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 158.83 μs | 257.75 μs | 14.128 μs | 150.942 μs | 150.401 μs | 175.14 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.37 μs | 258.59 μs | 14.174 μs |  59.642 μs |  49.752 μs |  77.71 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 260.62 μs | 588.14 μs | 32.238 μs | 255.284 μs | 231.388 μs | 295.20 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  30.08 μs | 322.17 μs | 17.659 μs |  34.535 μs |  10.619 μs |  45.08 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.56 μs | 617.93 μs | 33.871 μs |  67.466 μs |  66.544 μs | 125.67 μs |  68.69 KB |
