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
| **ArrayReverse**           | **10**     | **100**    |  **13.00 μs** | **169.23 μs** |  **9.276 μs** |   **7.790 μs** |   **7.500 μs** |  **23.71 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  72.78 μs | 228.85 μs | 12.544 μs |  68.278 μs |  63.109 μs |  86.95 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  44.35 μs | 266.40 μs | 14.602 μs |  38.222 μs |  33.804 μs |  61.01 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.18 μs | 140.37 μs |  7.694 μs |  14.889 μs |  10.891 μs |  25.76 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  62.64 μs | 345.79 μs | 18.954 μs |  53.105 μs |  50.340 μs |  84.46 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.86 μs | 171.97 μs |  9.426 μs |   7.514 μs |   7.324 μs |  23.75 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.69 μs | 279.23 μs | 15.306 μs |  27.907 μs |  27.808 μs |  54.37 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.56 μs** | **276.11 μs** | **15.134 μs** |   **8.881 μs** |   **8.772 μs** |  **35.04 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 313.48 μs | 305.48 μs | 16.745 μs | 315.464 μs | 295.828 μs | 329.14 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 153.62 μs |  53.79 μs |  2.948 μs | 152.567 μs | 151.335 μs | 156.94 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.61 μs | 237.97 μs | 13.044 μs |  60.849 μs |  50.541 μs |  76.45 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 248.50 μs | 612.55 μs | 33.576 μs | 237.056 μs | 222.138 μs | 286.30 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.58 μs | 290.09 μs | 15.901 μs |  10.405 μs |   8.431 μs |  36.91 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.02 μs | 554.53 μs | 30.396 μs |  68.811 μs |  68.139 μs | 121.12 μs |  68.69 KB |
