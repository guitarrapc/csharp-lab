```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.53 μs** | **166.89 μs** |  **9.148 μs** |  **11.201 μs** |   **7.514 μs** |  **24.88 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.16 μs | 282.79 μs | 15.501 μs |  80.542 μs |  69.141 μs |  99.81 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.43 μs | 356.24 μs | 19.527 μs |  26.590 μs |  25.728 μs |  59.97 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.40 μs | 146.74 μs |  8.043 μs |  14.708 μs |  11.041 μs |  26.44 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.67 μs | 243.66 μs | 13.356 μs |  48.451 μs |  47.479 μs |  71.08 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.27 μs | 192.82 μs | 10.569 μs |   7.283 μs |   7.062 μs |  25.48 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.78 μs | 242.63 μs | 13.299 μs |  31.409 μs |  27.010 μs |  51.93 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.77 μs** | **274.67 μs** | **15.056 μs** |   **9.317 μs** |   **8.847 μs** |  **35.16 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 314.81 μs | 348.03 μs | 19.077 μs | 311.424 μs | 297.648 μs | 335.35 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 177.85 μs | 138.71 μs |  7.603 μs | 173.877 μs | 173.065 μs | 186.62 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  73.38 μs | 285.37 μs | 15.642 μs |  70.272 μs |  59.521 μs |  90.34 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 233.60 μs | 495.57 μs | 27.164 μs | 233.148 μs | 206.668 μs | 260.99 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.43 μs | 195.39 μs | 10.710 μs |  10.679 μs |   7.915 μs |  27.69 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  91.40 μs | 517.90 μs | 28.388 μs |  82.374 μs |  68.618 μs | 123.20 μs |  68.69 KB |
