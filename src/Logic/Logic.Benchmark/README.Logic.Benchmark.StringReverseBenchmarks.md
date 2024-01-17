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
| **ArrayReverse**           | **10**     | **100**    |  **16.46 μs** | **206.37 μs** | **11.312 μs** |  **12.343 μs** |   **7.785 μs** |  **29.25 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.94 μs | 199.12 μs | 10.914 μs |  79.657 μs |  75.822 μs |  96.35 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.14 μs | 370.24 μs | 20.294 μs |  26.559 μs |  26.289 μs |  61.57 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.29 μs | 178.58 μs |  9.788 μs |  14.547 μs |  10.920 μs |  29.39 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.69 μs | 304.41 μs | 16.686 μs |  46.236 μs |  45.886 μs |  74.96 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.31 μs | 181.02 μs |  9.922 μs |   7.894 μs |   7.283 μs |  24.77 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  49.47 μs | 334.10 μs | 18.313 μs |  39.774 μs |  38.040 μs |  70.59 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.70 μs** | **276.39 μs** | **15.150 μs** |   **9.066 μs** |   **8.846 μs** |  **35.20 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.60 μs | 319.03 μs | 17.487 μs | 313.385 μs | 284.460 μs | 315.95 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 173.40 μs |  11.14 μs |  0.611 μs | 173.734 μs | 172.691 μs | 173.76 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  64.89 μs | 264.47 μs | 14.496 μs |  62.306 μs |  51.867 μs |  80.51 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 263.32 μs | 580.90 μs | 31.841 μs | 269.762 μs | 228.746 μs | 291.44 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.88 μs | 261.10 μs | 14.312 μs |  10.659 μs |   8.617 μs |  34.36 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  99.36 μs | 616.36 μs | 33.784 μs |  80.810 μs |  78.917 μs | 138.36 μs |  68.69 KB |
