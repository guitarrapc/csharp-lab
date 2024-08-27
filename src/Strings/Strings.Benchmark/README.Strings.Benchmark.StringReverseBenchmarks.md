```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.10 μs** |   **241.14 μs** | **13.218 μs** |  **10.570 μs** |  **10.370 μs** |  **33.36 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  78.32 μs |   162.21 μs |  8.891 μs |  76.642 μs |  70.391 μs |  87.93 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.68 μs |   236.05 μs | 12.939 μs |  38.661 μs |  22.863 μs |  48.51 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.67 μs |   186.64 μs | 10.230 μs |  14.948 μs |  10.830 μs |  30.25 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.14 μs |   319.77 μs | 17.528 μs |  45.840 μs |  44.218 μs |  75.36 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.61 μs |   188.05 μs | 10.308 μs |   7.714 μs |   7.594 μs |  25.51 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  39.76 μs |   350.40 μs | 19.207 μs |  28.724 μs |  28.614 μs |  61.94 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.05 μs** |   **275.19 μs** | **15.084 μs** |   **9.508 μs** |   **9.177 μs** |  **35.47 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 356.01 μs | 1,618.26 μs | 88.702 μs | 310.644 μs | 299.163 μs | 458.22 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 153.79 μs |    40.91 μs |  2.242 μs | 152.915 μs | 152.123 μs | 156.34 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.66 μs |   231.10 μs | 12.667 μs |  62.446 μs |  51.646 μs |  76.89 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 246.59 μs |   581.00 μs | 31.846 μs | 239.767 μs | 218.708 μs | 281.30 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  20.35 μs |   297.43 μs | 16.303 μs |  11.240 μs |  10.639 μs |  39.17 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  90.61 μs |   691.33 μs | 37.894 μs |  69.760 μs |  67.716 μs | 134.35 μs |  68.69 KB |
