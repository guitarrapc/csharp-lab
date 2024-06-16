```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **20.03 μs** | **217.51 μs** | **11.923 μs** |  **15.610 μs** |  **10.951 μs** |  **33.53 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  71.99 μs | 161.48 μs |  8.851 μs |  69.310 μs |  64.791 μs |  81.87 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  43.41 μs | 263.59 μs | 14.448 μs |  38.381 μs |  32.150 μs |  59.70 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.09 μs | 163.59 μs |  8.967 μs |  14.847 μs |  11.190 μs |  28.22 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.09 μs | 260.75 μs | 14.293 μs |  45.215 μs |  44.472 μs |  69.59 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.63 μs | 167.54 μs |  9.184 μs |   7.404 μs |   7.254 μs |  23.23 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.72 μs | 266.73 μs | 14.620 μs |  28.799 μs |  27.778 μs |  53.60 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.22 μs** | **270.85 μs** | **14.846 μs** |   **8.806 μs** |   **8.496 μs** |  **34.36 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 300.41 μs | 284.48 μs | 15.594 μs | 297.762 μs | 286.310 μs | 317.16 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 149.28 μs |  13.54 μs |  0.742 μs | 149.565 μs | 148.443 μs | 149.85 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.86 μs | 232.24 μs | 12.730 μs |  60.362 μs |  49.943 μs |  75.27 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 240.37 μs | 529.73 μs | 29.036 μs | 236.774 μs | 213.300 μs | 271.04 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.57 μs | 260.59 μs | 14.284 μs |  10.489 μs |   8.215 μs |  34.01 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.48 μs | 578.97 μs | 31.736 μs |  68.159 μs |  68.147 μs | 123.12 μs |  68.69 KB |
