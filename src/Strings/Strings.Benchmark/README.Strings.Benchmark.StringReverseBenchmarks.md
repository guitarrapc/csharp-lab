```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.14 μs** | **159.09 μs** |  **8.720 μs** |   **7.114 μs** |   **7.105 μs** |  **22.21 μs** |   **9.81 KB** |
| EnumerableReverse      | 10     | 100    |  64.00 μs | 131.46 μs |  7.206 μs |  67.728 μs |  55.695 μs |  68.58 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  36.97 μs | 195.33 μs | 10.706 μs |  39.294 μs |  25.288 μs |  46.32 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  20.35 μs | 192.06 μs | 10.528 μs |  14.522 μs |  14.031 μs |  32.51 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.41 μs | 211.83 μs | 11.611 μs |  57.368 μs |  42.950 μs |  65.92 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.18 μs | 170.56 μs |  9.349 μs |   6.928 μs |   6.647 μs |  22.98 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  38.09 μs | 113.10 μs |  6.199 μs |  35.758 μs |  33.392 μs |  45.12 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **16.95 μs** | **266.35 μs** | **14.599 μs** |   **8.531 μs** |   **8.511 μs** |  **33.81 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 135.12 μs | 394.72 μs | 21.636 μs | 123.502 μs | 121.769 μs | 160.08 μs |  37.94 KB |
| RecursiveReverse       | 64     | 100    | 157.07 μs |  40.76 μs |  2.234 μs | 157.366 μs | 154.700 μs | 159.14 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.32 μs | 218.19 μs | 11.960 μs |  59.702 μs |  50.255 μs |  74.01 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 246.41 μs | 650.74 μs | 35.669 μs | 226.740 μs | 224.907 μs | 287.58 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  13.92 μs | 201.42 μs | 11.041 μs |   7.695 μs |   7.404 μs |  26.67 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  75.84 μs | 294.19 μs | 16.125 μs |  66.751 μs |  66.320 μs |  94.46 μs |  38.22 KB |
