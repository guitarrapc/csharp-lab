```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **15.53 μs** | **182.03 μs** |  **9.978 μs** |  **12.428 μs** |   **7.479 μs** |  **26.70 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.29 μs | 190.22 μs | 10.427 μs |  72.767 μs |  66.364 μs |  86.75 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  39.18 μs | 356.35 μs | 19.533 μs |  28.127 μs |  27.676 μs |  61.73 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.05 μs | 161.56 μs |  8.856 μs |  15.209 μs |  10.970 μs |  27.98 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.50 μs | 258.40 μs | 14.164 μs |  45.461 μs |  45.191 μs |  69.86 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  17.63 μs | 232.93 μs | 12.768 μs |  10.471 μs |  10.050 μs |  32.37 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  51.98 μs | 408.88 μs | 22.412 μs |  39.956 μs |  38.143 μs |  77.84 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.43 μs** | **268.61 μs** | **14.724 μs** |   **9.168 μs** |   **8.687 μs** |  **34.43 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 305.76 μs | 231.47 μs | 12.688 μs | 302.549 μs | 294.994 μs | 319.75 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 207.35 μs | 923.85 μs | 50.640 μs | 179.832 μs | 176.436 μs | 265.80 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.98 μs | 228.63 μs | 12.532 μs |  63.309 μs |  51.797 μs |  76.83 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 239.86 μs | 505.72 μs | 27.720 μs | 238.860 μs | 212.651 μs | 268.06 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  23.63 μs | 472.47 μs | 25.897 μs |   8.872 μs |   8.491 μs |  53.54 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.47 μs | 537.39 μs | 29.456 μs |  72.686 μs |  70.262 μs | 122.45 μs |  68.69 KB |
