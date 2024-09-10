```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **19.35 μs** | **196.53 μs** | **10.772 μs** |  **15.884 μs** |  **10.745 μs** |  **31.43 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  76.19 μs | 129.30 μs |  7.087 μs |  79.157 μs |  68.107 μs |  81.32 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.55 μs | 259.78 μs | 14.239 μs |  26.529 μs |  22.311 μs |  48.81 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.26 μs | 147.17 μs |  8.067 μs |  14.659 μs |  10.820 μs |  26.31 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.37 μs | 307.75 μs | 16.869 μs |  44.864 μs |  44.402 μs |  73.85 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.14 μs | 182.52 μs | 10.004 μs |   7.435 μs |   7.284 μs |  24.69 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.47 μs | 255.89 μs | 14.026 μs |  27.852 μs |  26.901 μs |  51.66 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.13 μs** | **294.44 μs** | **16.139 μs** |   **8.996 μs** |   **8.636 μs** |  **36.77 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 310.92 μs | 139.19 μs |  7.630 μs | 313.395 μs | 302.365 μs | 317.01 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 152.88 μs |  61.61 μs |  3.377 μs | 152.395 μs | 149.770 μs | 156.47 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  71.51 μs | 266.78 μs | 14.623 μs |  67.505 μs |  59.300 μs |  87.71 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.83 μs | 512.83 μs | 28.110 μs | 234.749 μs | 209.812 μs | 265.92 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.72 μs | 210.27 μs | 11.526 μs |   8.336 μs |   7.795 μs |  28.02 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.09 μs | 563.91 μs | 30.910 μs |  70.241 μs |  68.257 μs | 122.76 μs |  68.69 KB |
