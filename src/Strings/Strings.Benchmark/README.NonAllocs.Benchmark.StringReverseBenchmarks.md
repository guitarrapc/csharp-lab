```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.77 μs** | **165.36 μs** |  **9.064 μs** |   **7.564 μs** |   **7.504 μs** |  **23.23 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  73.34 μs | 148.65 μs |  8.148 μs |  71.224 μs |  66.454 μs |  82.33 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  39.44 μs | 421.84 μs | 23.122 μs |  26.710 μs |  25.488 μs |  66.13 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  15.89 μs | 164.30 μs |  9.006 μs |  10.900 μs |  10.489 μs |  26.29 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.30 μs | 230.88 μs | 12.656 μs |  46.236 μs |  45.746 μs |  67.91 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.41 μs | 213.51 μs | 11.703 μs |   9.989 μs |   9.318 μs |  29.92 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  46.48 μs | 393.56 μs | 21.572 μs |  42.499 μs |  27.181 μs |  69.77 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.64 μs** | **343.93 μs** | **18.852 μs** |  **11.922 μs** |  **11.581 μs** |  **44.40 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 313.24 μs | 520.18 μs | 28.513 μs | 305.813 μs | 289.182 μs | 344.74 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 195.85 μs | 813.39 μs | 44.585 μs | 170.484 μs | 169.733 μs | 247.33 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.26 μs | 198.76 μs | 10.895 μs |  61.346 μs |  51.858 μs |  73.59 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 242.09 μs | 485.31 μs | 26.601 μs | 241.423 μs | 215.824 μs | 269.01 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.21 μs | 286.44 μs | 15.701 μs |   8.385 μs |   7.904 μs |  35.34 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.59 μs | 584.30 μs | 32.027 μs |  67.496 μs |  66.705 μs | 122.57 μs |  68.69 KB |
