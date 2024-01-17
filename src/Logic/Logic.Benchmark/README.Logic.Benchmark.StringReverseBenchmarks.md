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
| **ArrayReverse**           | **10**     | **100**    |  **14.65 μs** | **159.16 μs** |  **8.724 μs** |  **11.391 μs** |   **8.025 μs** |  **24.54 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  77.09 μs | 168.46 μs |  9.234 μs |  79.338 μs |  66.945 μs |  85.00 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.44 μs | 359.63 μs | 19.712 μs |  27.336 μs |  26.785 μs |  61.20 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  28.56 μs | 481.41 μs | 26.388 μs |  15.229 μs |  11.492 μs |  58.95 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  63.15 μs | 402.70 μs | 22.074 μs |  53.911 μs |  47.188 μs |  88.34 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.13 μs | 194.51 μs | 10.662 μs |   8.756 μs |   7.224 μs |  26.41 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.02 μs | 254.86 μs | 13.970 μs |  27.622 μs |  26.309 μs |  51.14 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **25.93 μs** | **404.54 μs** | **22.174 μs** |  **13.756 μs** |  **12.513 μs** |  **51.53 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 303.46 μs | 273.93 μs | 15.015 μs | 301.163 μs | 289.722 μs | 319.49 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 184.28 μs | 171.37 μs |  9.393 μs | 183.404 μs | 175.359 μs | 194.08 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  64.53 μs | 256.08 μs | 14.037 μs |  61.971 μs |  51.943 μs |  79.66 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.68 μs | 488.52 μs | 26.778 μs | 235.756 μs | 211.922 μs | 265.37 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.53 μs | 249.29 μs | 13.664 μs |  10.860 μs |  10.419 μs |  34.30 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.15 μs | 558.41 μs | 30.608 μs |  71.212 μs |  69.750 μs | 123.48 μs |  68.69 KB |
