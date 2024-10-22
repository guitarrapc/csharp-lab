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
| **ArrayReverse**           | **10**     | **100**    |  **13.95 μs** | **157.31 μs** |  **8.623 μs** |  **10.670 μs** |   **7.453 μs** |  **23.73 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  82.08 μs | 214.68 μs | 11.767 μs |  77.376 μs |  73.388 μs |  95.47 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.64 μs | 270.18 μs | 14.810 μs |  26.164 μs |  22.177 μs |  49.59 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.22 μs | 141.79 μs |  7.772 μs |  14.662 μs |  11.056 μs |  25.95 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  49.87 μs | 256.11 μs | 14.038 μs |  42.020 μs |  41.508 μs |  66.07 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.13 μs | 183.67 μs | 10.068 μs |   7.333 μs |   7.303 μs |  24.76 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.16 μs | 267.65 μs | 14.671 μs |  27.901 μs |  27.481 μs |  53.10 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.20 μs** | **379.44 μs** | **20.798 μs** |  **12.915 μs** |  **11.482 μs** |  **48.20 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 317.81 μs | 203.00 μs | 11.127 μs | 315.290 μs | 308.166 μs | 329.99 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 155.92 μs | 206.53 μs | 11.321 μs | 150.411 μs | 148.417 μs | 168.95 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.13 μs | 239.43 μs | 13.124 μs |  61.685 μs |  50.785 μs |  76.91 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.67 μs | 563.22 μs | 30.872 μs | 233.236 μs | 209.262 μs | 270.52 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.53 μs | 234.35 μs | 12.846 μs |   8.336 μs |   7.885 μs |  30.36 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  91.07 μs | 730.91 μs | 40.063 μs |  68.683 μs |  67.201 μs | 137.32 μs |  68.69 KB |
