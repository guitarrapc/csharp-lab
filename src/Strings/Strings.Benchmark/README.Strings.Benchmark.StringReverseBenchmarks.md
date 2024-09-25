```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.29 μs** | **184.73 μs** | **10.126 μs** |  **10.560 μs** |  **10.329 μs** |  **27.98 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.97 μs | 248.30 μs | 13.610 μs |  69.780 μs |  66.564 μs |  91.58 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  31.98 μs | 234.23 μs | 12.839 μs |  27.160 μs |  22.241 μs |  46.53 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  15.81 μs | 154.92 μs |  8.491 μs |  10.990 μs |  10.830 μs |  25.62 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.14 μs | 237.11 μs | 12.997 μs |  44.654 μs |  44.614 μs |  67.14 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.15 μs | 207.98 μs | 11.400 μs |   9.908 μs |   7.324 μs |  28.23 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.34 μs | 237.97 μs | 13.044 μs |  28.202 μs |  27.421 μs |  50.39 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **20.05 μs** | **353.88 μs** | **19.398 μs** |   **9.198 μs** |   **8.517 μs** |  **42.45 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 314.91 μs | 453.99 μs | 24.885 μs | 326.484 μs | 286.349 μs | 331.90 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 153.77 μs | 125.20 μs |  6.863 μs | 150.207 μs | 149.414 μs | 161.68 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  70.78 μs | 252.64 μs | 13.848 μs |  67.195 μs |  59.081 μs |  86.07 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 256.77 μs | 579.11 μs | 31.743 μs | 248.644 μs | 229.879 μs | 291.79 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.43 μs | 197.46 μs | 10.823 μs |   8.556 μs |   7.813 μs |  26.92 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.13 μs | 543.57 μs | 29.795 μs |  68.508 μs |  67.345 μs | 119.52 μs |  68.69 KB |
