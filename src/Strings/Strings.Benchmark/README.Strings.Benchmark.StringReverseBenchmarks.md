```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.22 μs** | **155.91 μs** |  **8.546 μs** |  **16.611 μs** |  **10.600 μs** |  **27.46 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  77.23 μs | 166.57 μs |  9.130 μs |  74.809 μs |  69.549 μs |  87.32 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  31.89 μs | 237.13 μs | 12.998 μs |  26.659 μs |  22.321 μs |  46.69 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  23.17 μs | 175.51 μs |  9.620 μs |  20.428 μs |  15.219 μs |  33.86 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.65 μs | 262.57 μs | 14.392 μs |  45.074 μs |  43.632 μs |  69.25 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.91 μs | 203.67 μs | 11.164 μs |   7.473 μs |   7.453 μs |  26.80 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.33 μs | 238.23 μs | 13.058 μs |  28.102 μs |  27.481 μs |  50.40 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.72 μs** | **439.70 μs** | **24.101 μs** |  **12.432 μs** |   **9.236 μs** |  **52.49 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 324.55 μs | 200.04 μs | 10.965 μs | 330.766 μs | 311.891 μs | 331.00 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 159.73 μs | 161.47 μs |  8.851 μs | 162.673 μs | 149.780 μs | 166.73 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  64.14 μs | 264.97 μs | 14.524 μs |  60.762 μs |  51.606 μs |  80.06 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 304.77 μs | 586.06 μs | 32.124 μs | 308.954 μs | 270.764 μs | 334.60 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.08 μs | 168.56 μs |  9.239 μs |  11.041 μs |  10.450 μs |  26.74 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  94.85 μs | 612.67 μs | 33.583 μs |  79.107 μs |  72.024 μs | 133.41 μs |  68.69 KB |
