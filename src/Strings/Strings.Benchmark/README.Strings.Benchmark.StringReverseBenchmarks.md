```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **15.15 μs** |   **233.54 μs** | **12.801 μs** |   **7.835 μs** |   **7.694 μs** |  **29.94 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  77.65 μs |   221.77 μs | 12.156 μs |  72.425 μs |  68.989 μs |  91.55 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  33.52 μs |   238.67 μs | 13.082 μs |  28.858 μs |  23.408 μs |  48.30 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  16.19 μs |   152.07 μs |  8.335 μs |  11.382 μs |  11.382 μs |  25.82 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  82.23 μs |   421.88 μs | 23.124 μs |  75.150 μs |  63.479 μs | 108.07 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.44 μs |   153.59 μs |  8.419 μs |   7.609 μs |   7.540 μs |  22.16 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.58 μs |   285.09 μs | 15.627 μs |  27.662 μs |  27.451 μs |  54.62 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.25 μs** |   **328.66 μs** | **18.015 μs** |  **11.867 μs** |  **11.837 μs** |  **43.05 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 313.70 μs |   230.42 μs | 12.630 μs | 314.326 μs | 300.771 μs | 326.01 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 158.83 μs |   237.26 μs | 13.005 μs | 153.687 μs | 149.189 μs | 173.62 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.12 μs |   236.77 μs | 12.978 μs |  60.568 μs |  51.602 μs |  77.18 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 266.35 μs | 1,129.97 μs | 61.938 μs | 257.911 μs | 209.071 μs | 332.08 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.73 μs |   201.54 μs | 11.047 μs |   8.520 μs |   8.189 μs |  27.49 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.92 μs |   528.26 μs | 28.956 μs |  68.624 μs |  67.791 μs | 118.36 μs |  68.69 KB |
