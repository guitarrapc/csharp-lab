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
| **ArrayReverse**           | **10**     | **100**    |  **12.92 μs** | **160.61 μs** |  **8.804 μs** |   **8.086 μs** |   **7.595 μs** |  **23.08 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  82.35 μs | 223.23 μs | 12.236 μs |  76.810 μs |  73.864 μs |  96.38 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.36 μs | 347.54 μs | 19.050 μs |  25.637 μs |  25.096 μs |  58.36 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  21.14 μs | 191.70 μs | 10.508 μs |  15.178 μs |  14.968 μs |  33.27 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.00 μs | 232.91 μs | 12.767 μs |  46.687 μs |  46.567 μs |  68.74 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.15 μs | 183.14 μs | 10.039 μs |   7.454 μs |   7.263 μs |  24.75 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.95 μs | 241.96 μs | 13.263 μs |  32.451 μs |  28.323 μs |  53.08 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.40 μs** | **264.33 μs** | **14.489 μs** |   **9.527 μs** |   **8.556 μs** |  **34.12 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.84 μs | 260.04 μs | 14.254 μs | 301.534 μs | 287.738 μs | 316.24 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 179.41 μs | 139.25 μs |  7.633 μs | 175.948 μs | 174.125 μs | 188.16 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.26 μs | 206.38 μs | 11.312 μs |  62.081 μs |  52.584 μs |  75.12 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 260.94 μs | 671.32 μs | 36.797 μs | 247.062 μs | 233.095 μs | 302.65 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.48 μs | 200.30 μs | 10.979 μs |   8.236 μs |   8.056 μs |  27.16 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  97.43 μs | 565.65 μs | 31.005 μs |  81.833 μs |  77.325 μs | 133.14 μs |  68.69 KB |
