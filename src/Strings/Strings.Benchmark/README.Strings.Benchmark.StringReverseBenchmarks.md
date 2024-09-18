```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.61 μs** | **265.24 μs** | **14.539 μs** |  **10.575 μs** |   **7.929 μs** |  **34.33 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 104.97 μs | 143.49 μs |  7.865 μs | 103.883 μs |  97.703 μs | 113.32 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  33.32 μs | 272.23 μs | 14.922 μs |  27.287 μs |  22.366 μs |  50.32 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.51 μs | 134.08 μs |  7.350 μs |  20.284 μs |  14.844 μs |  29.39 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  56.55 μs | 253.81 μs | 13.912 μs |  48.821 μs |  48.210 μs |  72.61 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.68 μs | 160.50 μs |  8.797 μs |   9.903 μs |   7.408 μs |  23.74 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.48 μs | 268.52 μs | 14.719 μs |  28.314 μs |  27.652 μs |  53.47 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.56 μs** | **379.84 μs** | **20.821 μs** |  **11.711 μs** |   **9.407 μs** |  **46.57 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 300.08 μs | 266.64 μs | 14.615 μs | 299.338 μs | 285.843 μs | 315.05 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 156.87 μs | 104.36 μs |  5.720 μs | 155.248 μs | 152.132 μs | 163.22 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.54 μs | 209.57 μs | 11.487 μs |  61.013 μs |  51.886 μs |  74.71 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 243.72 μs | 536.54 μs | 29.410 μs | 246.654 μs | 212.952 μs | 271.55 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.55 μs | 197.98 μs | 10.852 μs |   8.746 μs |   7.834 μs |  27.07 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.75 μs | 541.81 μs | 29.698 μs |  69.699 μs |  67.535 μs | 120.02 μs |  68.69 KB |
