```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.70 μs** | **155.691 μs** |  **8.534 μs** |  **15.318 μs** |  **10.609 μs** |  **27.17 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  79.49 μs | 166.790 μs |  9.142 μs |  75.892 μs |  72.686 μs |  89.88 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  48.95 μs | 335.359 μs | 18.382 μs |  40.837 μs |  36.017 μs |  69.99 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  22.38 μs | 137.491 μs |  7.536 μs |  20.949 μs |  15.659 μs |  30.53 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  68.95 μs | 253.915 μs | 13.918 μs |  61.245 μs |  60.593 μs |  85.02 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.26 μs | 182.584 μs | 10.008 μs |   7.635 μs |   7.333 μs |  24.82 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.82 μs | 250.900 μs | 13.753 μs |  28.282 μs |  27.491 μs |  51.70 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.48 μs** | **294.040 μs** | **16.117 μs** |   **9.463 μs** |   **8.883 μs** |  **37.08 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 314.29 μs | 250.559 μs | 13.734 μs | 311.668 μs | 302.050 μs | 329.14 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 149.24 μs |   2.598 μs |  0.142 μs | 149.214 μs | 149.113 μs | 149.39 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.20 μs | 221.711 μs | 12.153 μs |  61.635 μs |  50.333 μs |  74.62 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 252.70 μs | 545.566 μs | 29.904 μs | 267.900 μs | 218.247 μs | 271.95 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.03 μs | 209.518 μs | 11.484 μs |   8.766 μs |   8.035 μs |  28.28 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.00 μs | 548.423 μs | 30.061 μs |  68.669 μs |  68.629 μs | 120.72 μs |  68.69 KB |
