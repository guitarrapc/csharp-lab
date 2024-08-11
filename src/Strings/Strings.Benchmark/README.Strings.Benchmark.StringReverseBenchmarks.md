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
| **ArrayReverse**           | **10**     | **100**    |  **17.12 μs** | **212.38 μs** | **11.641 μs** |  **10.415 μs** |  **10.384 μs** |  **30.56 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.36 μs | 149.68 μs |  8.205 μs |  82.083 μs |  72.816 μs |  89.18 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  33.36 μs | 287.60 μs | 15.764 μs |  26.279 μs |  22.382 μs |  51.43 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.92 μs | 143.56 μs |  7.869 μs |  19.221 μs |  10.905 μs |  26.63 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  59.50 μs | 370.54 μs | 20.310 μs |  52.299 μs |  43.763 μs |  82.42 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.63 μs | 201.47 μs | 11.043 μs |   9.412 μs |   9.091 μs |  28.38 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.68 μs | 269.32 μs | 14.762 μs |  28.503 μs |  27.811 μs |  53.72 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.50 μs** | **259.29 μs** | **14.213 μs** |   **9.398 μs** |   **9.197 μs** |  **33.91 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 324.78 μs | 321.93 μs | 17.646 μs | 333.925 μs | 304.440 μs | 335.98 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 151.27 μs |  11.07 μs |  0.607 μs | 151.623 μs | 150.572 μs | 151.62 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.87 μs | 234.98 μs | 12.880 μs |  61.419 μs |  50.781 μs |  76.42 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 239.68 μs | 496.52 μs | 27.216 μs | 238.821 μs | 212.904 μs | 267.32 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  21.80 μs | 427.24 μs | 23.418 μs |   8.421 μs |   8.130 μs |  48.84 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  92.48 μs | 660.84 μs | 36.223 μs |  76.212 μs |  67.236 μs | 133.98 μs |  68.69 KB |
