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
| **ArrayReverse**           | **10**     | **100**    |  **16.79 μs** | **181.21 μs** |  **9.933 μs** |  **11.201 μs** |  **10.920 μs** |  **28.26 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  84.09 μs | 239.51 μs | 13.129 μs |  78.912 μs |  74.344 μs |  99.02 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.31 μs | 436.28 μs | 23.914 μs |  26.569 μs |  22.532 μs |  65.82 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.28 μs | 142.04 μs |  7.786 μs |  15.329 μs |  10.660 μs |  25.86 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.77 μs | 216.04 μs | 11.842 μs |  45.124 μs |  44.744 μs |  65.44 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.51 μs | 189.13 μs | 10.367 μs |   7.664 μs |   7.383 μs |  25.48 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  43.63 μs | 500.95 μs | 27.459 μs |  27.832 μs |  27.731 μs |  75.34 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.43 μs** | **325.04 μs** | **17.817 μs** |  **12.334 μs** |  **11.953 μs** |  **43.00 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 325.71 μs | 652.14 μs | 35.746 μs | 313.812 μs | 297.432 μs | 365.89 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 159.40 μs |  17.67 μs |  0.969 μs | 159.119 μs | 158.607 μs | 160.48 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  70.41 μs | 238.36 μs | 13.066 μs |  70.172 μs |  57.459 μs |  83.59 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 239.46 μs | 527.21 μs | 28.898 μs | 236.432 μs | 212.196 μs | 269.75 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.52 μs | 252.49 μs | 13.840 μs |   8.676 μs |   8.385 μs |  32.50 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  89.21 μs | 605.57 μs | 33.193 μs |  72.536 μs |  67.667 μs | 127.44 μs |  68.69 KB |
