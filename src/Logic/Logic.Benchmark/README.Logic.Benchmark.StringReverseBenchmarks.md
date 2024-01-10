```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.80 μs** | **170.63 μs** |  **9.353 μs** |   **7.465 μs** |   **7.345 μs** |  **23.60 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  80.36 μs | 257.70 μs | 14.125 μs |  73.077 μs |  71.363 μs |  96.64 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  49.19 μs | 388.46 μs | 21.293 μs |  38.502 μs |  35.356 μs |  73.71 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.25 μs | 173.06 μs |  9.486 μs |  14.957 μs |  10.850 μs |  28.94 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.14 μs | 226.29 μs | 12.404 μs |  47.218 μs |  46.737 μs |  68.46 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.56 μs | 158.82 μs |  8.705 μs |   7.574 μs |   7.494 μs |  22.61 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.55 μs | 250.63 μs | 13.738 μs |  28.323 μs |  26.940 μs |  51.40 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.71 μs** | **336.01 μs** | **18.418 μs** |  **12.387 μs** |  **11.777 μs** |  **43.98 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 310.27 μs | 504.59 μs | 27.658 μs | 300.702 μs | 288.660 μs | 341.44 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 185.54 μs |  66.74 μs |  3.658 μs | 184.225 μs | 182.721 μs | 189.67 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.28 μs | 215.41 μs | 11.807 μs |  61.650 μs |  52.372 μs |  75.82 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 242.18 μs | 510.10 μs | 27.961 μs | 246.892 μs | 212.167 μs | 267.49 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.80 μs | 203.36 μs | 11.147 μs |   8.626 μs |   8.116 μs |  27.67 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.02 μs | 527.07 μs | 28.891 μs |  70.192 μs |  68.499 μs | 119.36 μs |  68.69 KB |
