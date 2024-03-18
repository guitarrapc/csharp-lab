```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.70 μs** | **185.73 μs** | **10.181 μs** |   **7.894 μs** |   **7.754 μs** |  **25.46 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  74.38 μs | 223.24 μs | 12.236 μs |  70.322 μs |  64.681 μs |  88.12 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.00 μs | 345.11 μs | 18.917 μs |  26.334 μs |  25.832 μs |  58.84 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.37 μs | 144.47 μs |  7.919 μs |  14.737 μs |  11.100 μs |  26.27 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  60.88 μs | 299.91 μs | 16.439 μs |  52.282 μs |  50.519 μs |  79.83 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.66 μs | 168.79 μs |  9.252 μs |   7.534 μs |   7.113 μs |  23.34 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.61 μs | 271.04 μs | 14.857 μs |  28.154 μs |  27.903 μs |  53.76 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.10 μs** | **345.23 μs** | **18.923 μs** |  **12.474 μs** |  **11.872 μs** |  **44.95 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 306.67 μs | 297.13 μs | 16.286 μs | 304.382 μs | 291.647 μs | 323.98 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 174.01 μs |  15.04 μs |  0.824 μs | 173.544 μs | 173.534 μs | 174.97 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  78.66 μs | 457.83 μs | 25.095 μs |  83.475 μs |  51.505 μs | 101.00 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 247.42 μs | 623.10 μs | 34.154 μs | 239.607 μs | 217.846 μs | 284.80 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.81 μs | 247.58 μs | 13.571 μs |  11.472 μs |  10.479 μs |  34.47 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.69 μs | 578.15 μs | 31.690 μs |  69.078 μs |  67.726 μs | 123.28 μs |  68.69 KB |
