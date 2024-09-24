```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.01 μs** | **130.08 μs** |  **7.130 μs** |  **12.082 μs** |   **8.035 μs** |  **21.90 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 100.78 μs | 396.82 μs | 21.751 μs |  99.076 μs |  79.929 μs | 123.33 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.19 μs | 185.32 μs | 10.158 μs |  40.477 μs |  27.082 μs |  47.01 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  24.50 μs | 201.66 μs | 11.054 μs |  21.140 μs |  15.509 μs |  36.84 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.73 μs | 225.86 μs | 12.380 μs |  48.020 μs |  47.159 μs |  69.02 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.41 μs | 159.29 μs |  8.731 μs |   7.394 μs |   7.343 μs |  22.49 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.53 μs | 251.80 μs | 13.802 μs |  27.992 μs |  27.131 μs |  51.46 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **28.34 μs** | **302.47 μs** | **16.580 μs** |  **27.942 μs** |  **11.962 μs** |  **45.11 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 331.63 μs | 259.65 μs | 14.232 μs | 327.849 μs | 319.664 μs | 347.37 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 159.04 μs | 107.70 μs |  5.903 μs | 156.053 μs | 155.231 μs | 165.84 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.89 μs | 253.14 μs | 13.876 μs |  59.928 μs |  52.423 μs |  79.31 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 235.99 μs | 513.96 μs | 28.172 μs | 233.339 μs | 209.243 μs | 265.40 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.22 μs | 266.96 μs | 14.633 μs |  11.021 μs |   8.576 μs |  35.06 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 107.38 μs | 614.00 μs | 33.656 μs |  98.995 μs |  78.716 μs | 144.44 μs |  68.69 KB |
