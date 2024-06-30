```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **20.24 μs** | **221.59 μs** | **12.146 μs** |  **15.568 μs** |  **11.130 μs** |  **34.03 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 104.86 μs | 180.82 μs |  9.912 μs | 102.239 μs |  96.519 μs | 115.82 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.02 μs | 256.38 μs | 14.053 μs |  25.828 μs |  22.131 μs |  48.11 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.06 μs | 166.34 μs |  9.118 μs |  14.878 μs |  10.961 μs |  28.34 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.44 μs | 400.20 μs | 21.936 μs |  54.252 μs |  44.002 μs |  86.07 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.56 μs | 184.74 μs | 10.126 μs |  10.090 μs |   7.435 μs |  26.15 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  52.11 μs | 316.94 μs | 17.372 μs |  43.191 μs |  41.017 μs |  72.14 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.06 μs** | **290.70 μs** | **15.934 μs** |   **9.107 μs** |   **8.615 μs** |  **36.46 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 303.85 μs | 268.38 μs | 14.711 μs | 302.213 μs | 290.020 μs | 319.31 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 160.06 μs |  19.51 μs |  1.070 μs | 159.448 μs | 159.427 μs | 161.29 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  64.12 μs | 280.86 μs | 15.395 μs |  60.763 μs |  50.686 μs |  80.92 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 239.59 μs | 552.50 μs | 30.284 μs | 237.171 μs | 210.592 μs | 271.01 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.69 μs | 270.79 μs | 14.843 μs |   8.255 μs |   7.995 μs |  33.83 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.53 μs | 574.05 μs | 31.465 μs |  69.629 μs |  67.135 μs | 122.84 μs |  68.69 KB |
