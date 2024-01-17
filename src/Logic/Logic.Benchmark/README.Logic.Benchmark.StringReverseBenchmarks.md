```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median    | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.99 μs** | **255.32 μs** | **13.995 μs** |  **10.94 μs** |  **10.871 μs** |  **35.15 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  74.93 μs | 149.31 μs |  8.184 μs |  72.83 μs |  67.998 μs |  83.96 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  48.65 μs | 361.12 μs | 19.794 μs |  38.55 μs |  35.936 μs |  71.45 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  19.85 μs | 114.18 μs |  6.259 μs |  16.63 μs |  15.864 μs |  27.07 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  59.97 μs | 357.12 μs | 19.575 μs |  51.65 μs |  45.935 μs |  82.33 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.15 μs | 191.81 μs | 10.514 μs |  10.33 μs |   9.828 μs |  28.28 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.05 μs | 262.64 μs | 14.396 μs |  28.11 μs |  27.370 μs |  52.67 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.68 μs** | **255.06 μs** | **13.981 μs** |  **12.28 μs** |   **9.052 μs** |  **34.72 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.90 μs | 298.29 μs | 16.350 μs | 299.71 μs | 286.759 μs | 319.24 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 218.94 μs | 902.23 μs | 49.454 μs | 193.81 μs | 187.098 μs | 275.91 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  64.02 μs | 258.47 μs | 14.168 μs |  61.45 μs |  51.316 μs |  79.30 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.80 μs | 470.24 μs | 25.775 μs | 234.43 μs | 212.295 μs | 263.68 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.67 μs | 233.05 μs | 12.774 μs |  12.60 μs |   8.206 μs |  32.20 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.57 μs | 587.69 μs | 32.213 μs |  69.65 μs |  68.307 μs | 124.76 μs |  68.69 KB |
