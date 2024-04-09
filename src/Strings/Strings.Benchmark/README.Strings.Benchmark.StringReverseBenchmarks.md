```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.49 μs** | **171.885 μs** |  **9.422 μs** |  **15.816 μs** |  **10.694 μs** |  **28.96 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  72.35 μs | 156.042 μs |  8.553 μs |  70.552 μs |  64.831 μs |  81.65 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  40.01 μs | 306.982 μs | 16.827 μs |  36.840 μs |  24.997 μs |  58.20 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.70 μs | 134.034 μs |  7.347 μs |  14.837 μs |  14.086 μs |  27.17 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  63.32 μs | 321.995 μs | 17.650 μs |  54.072 μs |  52.209 μs |  83.67 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.27 μs | 225.568 μs | 12.364 μs |   8.997 μs |   7.303 μs |  29.52 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.77 μs | 272.648 μs | 14.945 μs |  30.748 μs |  27.632 μs |  54.93 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.53 μs** | **246.573 μs** | **13.516 μs** |  **13.064 μs** |   **8.606 μs** |  **33.92 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 495.07 μs | 910.198 μs | 49.891 μs | 495.651 μs | 444.896 μs | 544.67 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 174.85 μs |   6.929 μs |  0.380 μs | 174.657 μs | 174.608 μs | 175.29 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  71.50 μs | 294.600 μs | 16.148 μs |  67.337 μs |  57.849 μs |  89.33 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 248.06 μs | 532.432 μs | 29.184 μs | 243.242 μs | 221.591 μs | 279.36 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.34 μs | 226.229 μs | 12.400 μs |   8.527 μs |   7.845 μs |  29.66 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.77 μs | 565.668 μs | 31.006 μs |  67.206 μs |  66.524 μs | 120.57 μs |  68.69 KB |
