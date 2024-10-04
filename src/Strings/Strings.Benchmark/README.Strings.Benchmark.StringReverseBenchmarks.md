```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.68 μs** | **144.238 μs** |  **7.906 μs** |  **16.110 μs** |  **10.670 μs** |  **26.25 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 107.12 μs | 267.986 μs | 14.689 μs | 104.847 μs |  93.696 μs | 122.81 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  33.66 μs | 254.886 μs | 13.971 μs |  27.867 μs |  23.520 μs |  49.60 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  19.25 μs | 198.473 μs | 10.879 μs |  15.170 μs |  11.002 μs |  31.58 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  67.74 μs | 221.340 μs | 12.132 μs |  61.584 μs |  59.912 μs |  81.71 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.57 μs | 158.566 μs |  8.692 μs |   7.638 μs |   7.470 μs |  22.61 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.00 μs | 259.424 μs | 14.220 μs |  28.163 μs |  27.432 μs |  52.42 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.43 μs** | **227.950 μs** | **12.495 μs** |  **25.107 μs** |   **8.816 μs** |  **33.37 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 328.36 μs | 311.001 μs | 17.047 μs | 328.394 μs | 311.302 μs | 345.40 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 153.36 μs |   9.093 μs |  0.498 μs | 153.302 μs | 152.891 μs | 153.88 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  77.48 μs | 530.301 μs | 29.068 μs |  62.346 μs |  59.111 μs | 111.00 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.10 μs | 517.800 μs | 28.382 μs | 230.932 μs | 210.654 μs | 266.71 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.68 μs | 195.060 μs | 10.692 μs |   8.726 μs |   8.286 μs |  27.02 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.62 μs | 588.173 μs | 32.240 μs |  68.127 μs |  67.896 μs | 123.85 μs |  68.69 KB |
