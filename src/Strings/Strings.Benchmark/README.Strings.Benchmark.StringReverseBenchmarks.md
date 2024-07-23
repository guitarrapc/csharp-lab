```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.87 μs** | **166.838 μs** |  **9.145 μs** |   **7.614 μs** |   **7.573 μs** |  **23.43 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  77.38 μs | 171.572 μs |  9.404 μs |  78.896 μs |  67.306 μs |  85.93 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  43.36 μs | 263.281 μs | 14.431 μs |  38.181 μs |  32.240 μs |  59.67 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.56 μs | 152.371 μs |  8.352 μs |  14.788 μs |  10.940 μs |  26.94 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.47 μs | 265.247 μs | 14.539 μs |  44.673 μs |  43.501 μs |  69.25 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.29 μs | 211.930 μs | 11.617 μs |   9.788 μs |   9.387 μs |  29.70 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  38.36 μs | 286.424 μs | 15.700 μs |  29.524 μs |  29.064 μs |  56.48 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.11 μs** | **367.375 μs** | **20.137 μs** |  **12.764 μs** |  **12.203 μs** |  **47.36 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 306.58 μs | 290.115 μs | 15.902 μs | 304.046 μs | 292.104 μs | 323.60 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 151.10 μs |   7.591 μs |  0.416 μs | 151.091 μs | 150.690 μs | 151.52 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.07 μs | 234.906 μs | 12.876 μs |  60.112 μs |  50.283 μs |  75.81 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 243.54 μs | 549.556 μs | 30.123 μs | 238.194 μs | 216.443 μs | 275.97 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.12 μs | 257.071 μs | 14.091 μs |   8.296 μs |   7.685 μs |  32.39 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.02 μs | 609.952 μs | 33.434 μs |  69.258 μs |  66.213 μs | 125.58 μs |  68.69 KB |
