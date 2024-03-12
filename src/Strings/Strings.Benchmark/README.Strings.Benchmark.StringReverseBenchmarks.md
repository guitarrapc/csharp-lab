```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.93 μs** | **200.29 μs** | **10.978 μs** |  **10.840 μs** |  **10.349 μs** |  **29.61 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 107.98 μs | 218.25 μs | 11.963 μs | 104.495 μs |  98.142 μs | 121.30 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.14 μs | 345.24 μs | 18.924 μs |  25.588 μs |  24.846 μs |  57.99 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.31 μs | 179.61 μs |  9.845 μs |  14.603 μs |  10.856 μs |  29.47 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.10 μs | 217.12 μs | 11.901 μs |  44.303 μs |  44.153 μs |  64.84 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.45 μs | 155.44 μs |  8.520 μs |   7.614 μs |   7.453 μs |  22.29 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  41.40 μs | 216.26 μs | 11.854 μs |  43.781 μs |  28.532 μs |  51.88 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.84 μs** | **387.54 μs** | **21.242 μs** |  **12.078 μs** |  **11.085 μs** |  **48.36 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.03 μs | 254.01 μs | 13.923 μs | 301.236 μs | 291.717 μs | 319.14 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 181.03 μs |  17.82 μs |  0.977 μs | 181.027 μs | 180.055 μs | 182.01 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  71.97 μs | 530.87 μs | 29.099 μs |  60.843 μs |  50.083 μs | 105.00 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.71 μs | 506.50 μs | 27.763 μs | 236.060 μs | 210.803 μs | 266.26 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.56 μs | 206.96 μs | 11.344 μs |   8.336 μs |   7.684 μs |  27.65 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.02 μs | 572.80 μs | 31.397 μs |  67.926 μs |  67.865 μs | 122.28 μs |  68.69 KB |
