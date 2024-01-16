```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.88 μs** | **166.76 μs** |  **9.141 μs** |  **11.592 μs** |   **7.835 μs** |  **25.21 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  72.99 μs | 127.27 μs |  6.976 μs |  71.234 μs |  67.067 μs |  80.68 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.82 μs | 372.82 μs | 20.435 μs |  26.289 μs |  25.757 μs |  61.41 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.04 μs | 155.25 μs |  8.510 μs |  15.548 μs |  11.060 μs |  27.52 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.81 μs | 249.04 μs | 13.650 μs |  46.172 μs |  45.681 μs |  69.57 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  18.42 μs | 274.65 μs | 15.055 μs |  10.048 μs |   9.407 μs |  35.80 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.72 μs | 248.95 μs | 13.646 μs |  28.483 μs |  27.210 μs |  51.46 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.53 μs** | **299.42 μs** | **16.412 μs** |   **9.438 μs** |   **8.667 μs** |  **37.47 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 320.48 μs | 264.59 μs | 14.503 μs | 318.456 μs | 307.094 μs | 335.89 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 176.29 μs |  25.22 μs |  1.383 μs | 176.520 μs | 174.806 μs | 177.54 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.35 μs | 212.84 μs | 11.667 μs |  61.544 μs |  52.689 μs |  75.81 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 235.80 μs | 503.65 μs | 27.607 μs | 235.760 μs | 208.219 μs | 263.43 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.85 μs | 211.33 μs | 11.584 μs |   8.280 μs |   8.049 μs |  28.23 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.55 μs | 530.14 μs | 29.059 μs |  70.232 μs |  69.310 μs | 120.10 μs |  68.69 KB |
