```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.93 μs** | **147.89 μs** |  **8.107 μs** |  **11.320 μs** |   **7.454 μs** |  **23.02 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  72.89 μs | 145.33 μs |  7.966 μs |  70.963 μs |  66.063 μs |  81.64 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.05 μs | 350.34 μs | 19.204 μs |  26.520 μs |  25.407 μs |  59.21 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  21.46 μs | 201.67 μs | 11.054 μs |  15.343 μs |  14.813 μs |  34.22 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.73 μs | 226.26 μs | 12.402 μs |  47.649 μs |  47.490 μs |  69.05 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.86 μs | 170.34 μs |  9.337 μs |   7.593 μs |   7.353 μs |  23.64 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.34 μs | 252.00 μs | 13.813 μs |  27.776 μs |  26.956 μs |  51.28 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.11 μs** | **264.55 μs** | **14.501 μs** |   **9.006 μs** |   **8.475 μs** |  **33.85 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 310.98 μs | 323.85 μs | 17.751 μs | 319.979 μs | 290.534 μs | 322.43 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 174.81 μs |  24.20 μs |  1.326 μs | 174.587 μs | 173.605 μs | 176.23 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.48 μs | 210.95 μs | 11.563 μs |  62.286 μs |  52.558 μs |  75.59 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 247.18 μs | 514.83 μs | 28.219 μs | 243.290 μs | 221.108 μs | 277.14 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.89 μs | 235.67 μs | 12.918 μs |   8.747 μs |   8.114 μs |  30.80 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  93.17 μs | 658.94 μs | 36.119 μs |  77.705 μs |  67.366 μs | 134.45 μs |  68.69 KB |
