```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.80 μs** | **276.45 μs** | **15.153 μs** |   **8.235 μs** |   **7.864 μs** |  **34.29 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  76.70 μs | 127.83 μs |  7.007 μs |  76.282 μs |  69.911 μs |  83.91 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  43.73 μs | 280.74 μs | 15.388 μs |  37.565 μs |  32.385 μs |  61.25 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.23 μs | 151.00 μs |  8.277 μs |  14.668 μs |  10.531 μs |  26.48 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  62.00 μs | 321.28 μs | 17.611 μs |  51.977 μs |  51.687 μs |  82.33 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.65 μs | 222.20 μs | 12.180 μs |   9.748 μs |   9.497 μs |  30.72 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.33 μs | 292.85 μs | 16.052 μs |  28.258 μs |  27.878 μs |  55.87 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.00 μs** | **388.67 μs** | **21.304 μs** |  **11.846 μs** |  **11.546 μs** |  **48.59 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 313.98 μs | 318.21 μs | 17.442 μs | 310.017 μs | 298.856 μs | 333.06 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 150.29 μs |  10.47 μs |  0.574 μs | 150.049 μs | 149.869 μs | 150.94 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.45 μs | 201.34 μs | 11.036 μs |  60.232 μs |  51.076 μs |  73.05 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.87 μs | 492.18 μs | 26.978 μs | 235.218 μs | 210.763 μs | 264.64 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.79 μs | 208.90 μs | 11.451 μs |   9.568 μs |   8.796 μs |  29.00 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.77 μs | 577.34 μs | 31.646 μs |  67.936 μs |  67.064 μs | 122.31 μs |  68.69 KB |
