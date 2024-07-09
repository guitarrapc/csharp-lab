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
| **ArrayReverse**           | **10**     | **100**    |  **17.62 μs** | **158.09 μs** |  **8.665 μs** |  **14.988 μs** |  **10.569 μs** |  **27.29 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  71.10 μs | 121.43 μs |  6.656 μs |  70.001 μs |  65.062 μs |  78.24 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  31.86 μs | 248.81 μs | 13.638 μs |  26.018 μs |  22.121 μs |  47.45 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.15 μs | 212.43 μs | 11.644 μs |  14.707 μs |  14.156 μs |  34.59 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.73 μs | 249.25 μs | 13.662 μs |  48.541 μs |  47.158 μs |  71.48 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.67 μs | 170.07 μs |  9.322 μs |   7.353 μs |   7.222 μs |  23.43 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  47.81 μs | 314.14 μs | 17.219 μs |  38.633 μs |  37.130 μs |  67.68 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.26 μs** | **376.97 μs** | **20.663 μs** |  **12.593 μs** |  **12.072 μs** |  **48.12 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.04 μs | 294.31 μs | 16.132 μs | 299.970 μs | 285.462 μs | 317.67 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 150.90 μs |  34.73 μs |  1.903 μs | 151.048 μs | 148.923 μs | 152.72 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  71.20 μs | 297.45 μs | 16.304 μs |  66.736 μs |  57.587 μs |  89.27 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 253.50 μs | 582.24 μs | 31.914 μs | 248.014 μs | 224.680 μs | 287.80 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.84 μs | 214.23 μs | 11.743 μs |   8.156 μs |   7.956 μs |  28.39 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  93.78 μs | 815.29 μs | 44.689 μs |  68.779 μs |  67.186 μs | 145.37 μs |  68.69 KB |
