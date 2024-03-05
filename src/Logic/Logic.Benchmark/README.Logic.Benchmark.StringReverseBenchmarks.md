```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.01 μs** |   **147.39 μs** |  **8.079 μs** |  **11.242 μs** |   **7.685 μs** |  **23.11 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  73.67 μs |   137.98 μs |  7.563 μs |  71.584 μs |  67.376 μs |  82.06 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.94 μs |   353.34 μs | 19.368 μs |  25.979 μs |  25.538 μs |  59.30 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.47 μs |   154.05 μs |  8.444 μs |  14.506 μs |  10.900 μs |  26.99 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.84 μs |   240.74 μs | 13.196 μs |  46.456 μs |  45.996 μs |  69.08 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.62 μs |   195.03 μs | 10.690 μs |   7.729 μs |   7.178 μs |  25.96 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.62 μs |   263.93 μs | 14.467 μs |  28.853 μs |  27.691 μs |  53.31 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.04 μs** |   **325.87 μs** | **17.862 μs** |   **9.037 μs** |   **8.426 μs** |  **39.66 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 300.51 μs |   270.53 μs | 14.828 μs | 300.368 μs | 285.750 μs | 315.41 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 183.74 μs |    24.06 μs |  1.319 μs | 183.358 μs | 182.648 μs | 185.20 μs | 710.88 KB |
| ReverseXor             | 64     | 100    | 101.01 μs | 1,407.26 μs | 77.137 μs |  61.655 μs |  51.486 μs | 189.88 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 244.56 μs |   573.12 μs | 31.415 μs | 257.062 μs | 208.821 μs | 267.80 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.85 μs |   242.56 μs | 13.295 μs |   8.256 μs |   8.086 μs |  31.20 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.43 μs |   600.63 μs | 32.923 μs |  67.907 μs |  66.946 μs | 124.44 μs |  68.69 KB |
