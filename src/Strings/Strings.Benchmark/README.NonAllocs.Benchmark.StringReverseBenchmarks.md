```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.78 μs** | **159.94 μs** |  **8.767 μs** |   **7.815 μs** |   **7.624 μs** |  **22.90 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  74.99 μs | 152.48 μs |  8.358 μs |  72.417 μs |  68.219 μs |  84.33 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.26 μs | 352.94 μs | 19.346 μs |  27.677 μs |  26.515 μs |  60.59 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.17 μs | 177.43 μs |  9.725 μs |  14.573 μs |  10.755 μs |  29.18 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.23 μs | 420.26 μs | 23.036 μs |  52.374 μs |  43.938 μs |  87.38 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.69 μs | 204.13 μs | 11.189 μs |   7.403 μs |   7.063 μs |  26.61 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  49.66 μs | 320.65 μs | 17.576 μs |  41.669 μs |  37.500 μs |  69.81 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.06 μs** | **407.07 μs** | **22.313 μs** |  **11.588 μs** |   **8.822 μs** |  **48.78 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 315.84 μs | 321.46 μs | 17.620 μs | 310.459 μs | 301.544 μs | 335.53 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 179.41 μs |  85.11 μs |  4.665 μs | 181.936 μs | 174.031 μs | 182.28 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.04 μs | 200.31 μs | 10.980 μs |  62.298 μs |  52.449 μs |  74.37 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 253.15 μs | 794.22 μs | 43.534 μs | 238.184 μs | 219.077 μs | 302.19 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.40 μs | 205.24 μs | 11.250 μs |   8.106 μs |   7.715 μs |  27.39 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.66 μs | 523.08 μs | 28.672 μs |  70.674 μs |  67.578 μs | 118.72 μs |  68.69 KB |
