```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.61 μs** | **205.31 μs** | **11.254 μs** |  **10.479 μs** |   **9.747 μs** |  **29.59 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  85.98 μs | 271.02 μs | 14.856 μs |  79.819 μs |  75.190 μs | 102.92 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.25 μs | 389.12 μs | 21.329 μs |  26.238 μs |  25.637 μs |  62.88 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.80 μs | 153.99 μs |  8.440 μs |  14.997 μs |  11.110 μs |  27.28 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.05 μs | 225.49 μs | 12.360 μs |  46.477 μs |  45.364 μs |  67.31 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.95 μs | 204.89 μs | 11.231 μs |   9.758 μs |   9.178 μs |  28.91 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.70 μs | 273.68 μs | 15.001 μs |  28.338 μs |  27.738 μs |  54.02 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.05 μs** | **277.49 μs** | **15.210 μs** |   **9.793 μs** |   **8.752 μs** |  **35.60 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 302.08 μs | 277.88 μs | 15.231 μs | 301.362 μs | 287.225 μs | 317.66 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 187.04 μs |  43.43 μs |  2.381 μs | 187.135 μs | 184.619 μs | 189.38 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.18 μs | 205.86 μs | 11.284 μs |  60.473 μs |  51.846 μs |  74.22 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 250.28 μs | 586.96 μs | 32.173 μs | 244.307 μs | 221.514 μs | 285.02 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.92 μs | 241.95 μs | 13.262 μs |   8.621 μs |   7.920 μs |  31.23 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.26 μs | 572.61 μs | 31.387 μs |  69.670 μs |  68.618 μs | 123.50 μs |  68.69 KB |
