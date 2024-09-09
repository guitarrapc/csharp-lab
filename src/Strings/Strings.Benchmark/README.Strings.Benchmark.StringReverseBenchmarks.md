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
| **ArrayReverse**           | **10**     | **100**    |  **16.97 μs** | **199.05 μs** | **10.911 μs** |  **10.870 μs** |  **10.470 μs** |  **29.56 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 105.71 μs | 178.47 μs |  9.783 μs | 101.028 μs |  99.154 μs | 116.96 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  42.99 μs | 273.03 μs | 14.966 μs |  37.499 μs |  31.538 μs |  59.92 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.56 μs | 162.20 μs |  8.891 μs |  14.727 μs |  10.429 μs |  27.52 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.24 μs | 258.75 μs | 14.183 μs |  47.629 μs |  46.486 μs |  71.60 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.47 μs | 188.11 μs | 10.311 μs |   7.625 μs |   7.415 μs |  25.38 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.89 μs | 233.53 μs | 12.800 μs |  28.758 μs |  28.247 μs |  50.67 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.14 μs** | **364.82 μs** | **19.997 μs** |  **11.992 μs** |   **9.247 μs** |  **45.17 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 325.13 μs | 273.20 μs | 14.975 μs | 322.550 μs | 311.609 μs | 341.22 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 242.63 μs |  32.42 μs |  1.777 μs | 242.430 μs | 240.969 μs | 244.50 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.89 μs | 222.14 μs | 12.176 μs |  62.196 μs |  52.648 μs |  76.82 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 238.05 μs | 537.78 μs | 29.477 μs | 236.580 μs | 209.329 μs | 268.23 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.14 μs | 246.57 μs | 13.515 μs |   8.470 μs |   8.200 μs |  31.74 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.05 μs | 601.23 μs | 32.955 μs |  69.889 μs |  68.177 μs | 126.09 μs |  68.69 KB |
