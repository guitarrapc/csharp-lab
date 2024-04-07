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
| **ArrayReverse**           | **10**     | **100**    |  **13.64 μs** | **146.22 μs** |  **8.015 μs** |  **10.419 μs** |   **7.734 μs** |  **22.76 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  86.31 μs | 403.75 μs | 22.131 μs |  79.479 μs |  68.408 μs | 111.06 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  40.53 μs | 303.00 μs | 16.608 μs |  37.776 μs |  25.471 μs |  58.34 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  19.43 μs | 199.60 μs | 10.941 μs |  15.718 μs |  10.820 μs |  31.74 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.10 μs | 214.38 μs | 11.751 μs |  53.440 μs |  44.273 μs |  67.60 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.09 μs | 208.79 μs | 11.445 μs |   7.604 μs |   7.353 μs |  27.30 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.55 μs | 260.70 μs | 14.290 μs |  31.297 μs |  27.451 μs |  53.90 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.26 μs** | **301.55 μs** | **16.529 μs** |   **9.057 μs** |   **8.375 μs** |  **37.34 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 322.10 μs | 328.86 μs | 18.026 μs | 319.624 μs | 305.438 μs | 341.23 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 175.50 μs |  45.16 μs |  2.475 μs | 174.845 μs | 173.423 μs | 178.24 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  68.92 μs | 191.88 μs | 10.517 μs |  66.694 μs |  59.691 μs |  80.37 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 248.59 μs | 537.90 μs | 29.484 μs | 247.731 μs | 219.549 μs | 278.50 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.71 μs | 230.35 μs | 12.627 μs |   8.655 μs |   8.185 μs |  30.29 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.11 μs | 564.93 μs | 30.966 μs |  67.967 μs |  66.504 μs | 120.86 μs |  68.69 KB |
