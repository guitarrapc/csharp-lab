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
| **ArrayReverse**           | **10**     | **100**    |  **16.07 μs** | **146.95 μs** |  **8.055 μs** |  **11.652 μs** |  **11.192 μs** |  **25.37 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.26 μs | 211.26 μs | 11.580 μs |  78.879 μs |  74.510 μs |  96.39 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.02 μs | 341.87 μs | 18.739 μs |  26.691 μs |  25.718 μs |  58.65 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.21 μs | 141.17 μs |  7.738 μs |  14.749 μs |  11.002 μs |  25.88 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.68 μs | 260.44 μs | 14.275 μs |  46.843 μs |  46.041 μs |  71.16 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.25 μs | 219.82 μs | 12.049 μs |   7.393 μs |   7.193 μs |  28.16 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  50.37 μs | 263.76 μs | 14.457 μs |  45.221 μs |  39.199 μs |  66.70 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.41 μs** | **268.37 μs** | **14.711 μs** |   **9.117 μs** |   **8.717 μs** |  **34.39 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 318.28 μs | 804.44 μs | 44.094 μs | 301.293 μs | 285.202 μs | 368.34 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 183.60 μs |  19.01 μs |  1.042 μs | 183.396 μs | 182.674 μs | 184.73 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.96 μs | 267.88 μs | 14.683 μs |  60.624 μs |  51.227 μs |  80.02 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 238.48 μs | 476.30 μs | 26.107 μs | 246.023 μs | 209.435 μs | 259.99 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  19.42 μs | 276.58 μs | 15.160 μs |  10.926 μs |  10.415 μs |  36.92 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.73 μs | 567.81 μs | 31.124 μs |  68.209 μs |  67.307 μs | 121.66 μs |  68.69 KB |
