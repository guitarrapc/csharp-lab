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
| **ArrayReverse**           | **10**     | **100**    |  **14.32 μs** | **150.18 μs** |  **8.232 μs** |  **11.853 μs** |   **7.605 μs** |  **23.50 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.58 μs | 140.03 μs |  7.676 μs |  74.334 μs |  68.603 μs |  83.80 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  39.57 μs | 385.45 μs | 21.128 μs |  27.571 μs |  27.181 μs |  63.97 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  24.88 μs | 176.68 μs |  9.684 μs |  25.066 μs |  15.098 μs |  34.46 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  62.77 μs | 318.47 μs | 17.456 μs |  53.459 μs |  51.936 μs |  82.90 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.93 μs | 226.54 μs | 12.417 μs |   9.938 μs |   9.587 μs |  31.27 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.75 μs | 266.41 μs | 14.603 μs |  29.737 μs |  28.904 μs |  54.60 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.55 μs** | **276.96 μs** | **15.181 μs** |   **8.867 μs** |   **8.697 μs** |  **35.08 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 306.73 μs | 377.79 μs | 20.708 μs | 301.353 μs | 289.240 μs | 329.60 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 206.62 μs | 221.97 μs | 12.167 μs | 201.317 μs | 198.010 μs | 220.54 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  69.92 μs | 302.32 μs | 16.571 μs |  61.035 μs |  59.681 μs |  89.04 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 284.81 μs | 547.24 μs | 29.996 μs | 286.915 μs | 253.823 μs | 313.70 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.59 μs | 222.89 μs | 12.217 μs |   8.625 μs |   8.446 μs |  29.70 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.81 μs | 585.40 μs | 32.088 μs |  71.644 μs |  68.950 μs | 125.83 μs |  68.69 KB |
