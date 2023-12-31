```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.46 μs** | **197.40 μs** | **10.820 μs** |  **11.732 μs** |  **10.700 μs** |  **29.94 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  77.74 μs | 272.18 μs | 14.919 μs |  75.503 μs |  64.071 μs |  93.66 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.15 μs | 348.66 μs | 19.111 μs |  26.425 μs |  25.813 μs |  59.22 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.37 μs | 141.08 μs |  7.733 μs |  14.949 μs |  11.132 μs |  26.02 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  62.13 μs | 293.01 μs | 16.061 μs |  53.851 μs |  51.897 μs |  80.64 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.10 μs | 154.81 μs |  8.486 μs |   7.234 μs |   7.173 μs |  21.90 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.54 μs | 294.29 μs | 16.131 μs |  28.694 μs |  27.762 μs |  56.16 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.44 μs** | **261.71 μs** | **14.345 μs** |   **9.557 μs** |   **8.756 μs** |  **33.99 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 308.48 μs | 340.99 μs | 18.691 μs | 318.745 μs | 286.906 μs | 319.79 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 180.98 μs |  28.97 μs |  1.588 μs | 180.078 μs | 180.049 μs | 182.81 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  64.67 μs | 258.31 μs | 14.159 μs |  62.868 μs |  51.506 μs |  79.65 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 235.82 μs | 506.59 μs | 27.768 μs | 235.654 μs | 208.142 μs | 263.68 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.45 μs | 228.06 μs | 12.501 μs |  11.862 μs |   8.716 μs |  31.77 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 100.60 μs | 642.69 μs | 35.228 μs |  81.944 μs |  78.628 μs | 141.24 μs |  68.69 KB |
