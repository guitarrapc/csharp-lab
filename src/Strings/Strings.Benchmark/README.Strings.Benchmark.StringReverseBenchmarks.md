```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.10 μs** | **206.31 μs** | **11.308 μs** |  **10.605 μs** |  **10.544 μs** |  **30.16 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  84.41 μs | 160.00 μs |  8.770 μs |  80.421 μs |  78.348 μs |  94.47 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.55 μs | 263.18 μs | 14.426 μs |  26.424 μs |  22.196 μs |  49.03 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  22.22 μs | 245.83 μs | 13.475 μs |  14.708 μs |  14.167 μs |  37.77 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.40 μs | 242.93 μs | 13.316 μs |  44.775 μs |  44.654 μs |  67.78 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.37 μs | 177.75 μs |  9.743 μs |   8.966 μs |   8.525 μs |  25.62 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.67 μs | 261.29 μs | 14.322 μs |  27.421 μs |  27.381 μs |  52.21 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.48 μs** | **277.93 μs** | **15.234 μs** |   **8.886 μs** |   **8.475 μs** |  **35.06 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 317.00 μs | 265.70 μs | 14.564 μs | 317.675 μs | 302.108 μs | 331.21 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 160.73 μs |  17.39 μs |  0.953 μs | 160.552 μs | 159.871 μs | 161.75 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.36 μs | 215.05 μs | 11.788 μs |  60.188 μs |  51.812 μs |  75.09 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 238.37 μs | 543.17 μs | 29.773 μs | 235.012 μs | 210.415 μs | 269.68 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.38 μs | 218.49 μs | 11.976 μs |   8.516 μs |   8.407 μs |  29.20 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.11 μs | 565.80 μs | 31.014 μs |  68.689 μs |  67.726 μs | 121.92 μs |  68.69 KB |
