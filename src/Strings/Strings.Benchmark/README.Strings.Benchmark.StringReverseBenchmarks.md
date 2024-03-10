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
| **ArrayReverse**           | **10**     | **100**    |  **12.96 μs** | **174.82 μs** |  **9.582 μs** |   **7.564 μs** |   **7.293 μs** |  **24.02 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  77.28 μs | 240.22 μs | 13.167 μs |  71.123 μs |  68.328 μs |  92.40 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.77 μs | 360.66 μs | 19.769 μs |  28.913 μs |  25.858 μs |  61.52 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.18 μs | 172.52 μs |  9.456 μs |  14.832 μs |  10.845 μs |  28.85 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  57.31 μs | 253.74 μs | 13.908 μs |  49.312 μs |  49.242 μs |  73.37 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.31 μs | 157.79 μs |  8.649 μs |   7.458 μs |   7.178 μs |  22.30 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.27 μs | 259.82 μs | 14.241 μs |  27.111 μs |  26.990 μs |  51.72 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.40 μs** | **274.38 μs** | **15.040 μs** |   **8.787 μs** |   **8.647 μs** |  **34.77 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.35 μs | 312.59 μs | 17.134 μs | 311.182 μs | 284.853 μs | 317.01 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 176.19 μs | 115.57 μs |  6.335 μs | 173.745 μs | 171.441 μs | 183.38 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.31 μs | 199.96 μs | 10.961 μs |  62.768 μs |  52.629 μs |  74.53 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 241.91 μs | 563.49 μs | 30.887 μs | 237.525 μs | 213.449 μs | 274.75 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.34 μs | 327.23 μs | 17.937 μs |   8.275 μs |   7.704 μs |  39.05 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.75 μs | 597.55 μs | 32.754 μs |  66.910 μs |  66.760 μs | 123.57 μs |  68.69 KB |
