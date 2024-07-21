```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **19.60 μs** | **197.68 μs** | **10.835 μs** |  **16.651 μs** |  **10.550 μs** |  **31.61 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  86.44 μs | 255.28 μs | 13.993 μs |  78.506 μs |  78.226 μs | 102.60 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.63 μs | 243.95 μs | 13.372 μs |  27.141 μs |  22.873 μs |  47.87 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.59 μs | 149.52 μs |  8.196 μs |  15.359 μs |  10.741 μs |  26.67 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  65.38 μs | 508.89 μs | 27.894 μs |  55.374 μs |  43.862 μs |  96.89 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.65 μs | 191.07 μs | 10.473 μs |   7.645 μs |   7.554 μs |  25.74 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.32 μs | 314.55 μs | 17.241 μs |  39.403 μs |  37.369 μs |  68.20 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.66 μs** | **294.44 μs** | **16.139 μs** |   **9.718 μs** |   **8.967 μs** |  **37.29 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 315.96 μs | 236.29 μs | 12.952 μs | 311.934 μs | 305.502 μs | 330.45 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 169.04 μs | 253.77 μs | 13.910 μs | 162.704 μs | 159.418 μs | 184.99 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  64.58 μs | 265.03 μs | 14.527 μs |  61.244 μs |  52.017 μs |  80.49 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 386.69 μs | 675.17 μs | 37.008 μs | 376.004 μs | 356.206 μs | 427.87 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.74 μs | 208.81 μs | 11.445 μs |   8.295 μs |   7.965 μs |  27.95 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.91 μs | 513.09 μs | 28.124 μs |  69.881 μs |  69.461 μs | 118.38 μs |  68.69 KB |
