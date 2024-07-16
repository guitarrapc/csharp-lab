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
| **ArrayReverse**           | **10**     | **100**    |  **17.00 μs** | **204.36 μs** | **11.202 μs** |  **10.570 μs** |  **10.499 μs** |  **29.94 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  78.08 μs | 131.26 μs |  7.195 μs |  77.956 μs |  70.942 μs |  85.33 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.13 μs | 256.21 μs | 14.044 μs |  26.019 μs |  22.173 μs |  48.19 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.83 μs | 157.36 μs |  8.625 μs |  15.038 μs |  10.942 μs |  27.50 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  62.52 μs | 301.77 μs | 16.541 μs |  53.975 μs |  52.002 μs |  81.59 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.28 μs | 152.36 μs |  8.351 μs |   7.605 μs |   7.314 μs |  21.92 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.46 μs | 273.12 μs | 14.970 μs |  27.952 μs |  27.691 μs |  53.75 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.46 μs** | **273.76 μs** | **15.006 μs** |   **8.956 μs** |   **8.635 μs** |  **34.78 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 320.13 μs | 294.05 μs | 16.118 μs | 327.313 μs | 301.665 μs | 331.40 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 151.58 μs |  37.99 μs |  2.082 μs | 151.153 μs | 149.750 μs | 153.85 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  73.74 μs | 239.67 μs | 13.137 μs |  75.541 μs |  59.801 μs |  85.89 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 243.23 μs | 593.23 μs | 32.517 μs | 240.340 μs | 212.248 μs | 277.09 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.61 μs | 204.61 μs | 11.215 μs |   8.486 μs |   7.784 μs |  27.55 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.11 μs | 590.64 μs | 32.375 μs |  67.457 μs |  67.377 μs | 123.49 μs |  68.69 KB |
