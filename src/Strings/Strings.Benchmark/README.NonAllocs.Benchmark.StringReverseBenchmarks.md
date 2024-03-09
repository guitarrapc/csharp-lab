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
| **ArrayReverse**           | **10**     | **100**    |  **16.84 μs** | **202.10 μs** | **11.078 μs** |  **10.610 μs** |  **10.289 μs** |  **29.64 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  84.49 μs | 229.79 μs | 12.595 μs |  79.437 μs |  75.199 μs |  98.82 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.46 μs | 381.68 μs | 20.921 μs |  25.673 μs |  25.083 μs |  61.61 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  23.86 μs | 187.83 μs | 10.296 μs |  22.422 μs |  14.367 μs |  34.81 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.72 μs | 274.23 μs | 15.032 μs |  51.415 μs |  43.310 μs |  72.43 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.64 μs | 172.70 μs |  9.466 μs |   7.504 μs |   6.853 μs |  23.57 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  49.72 μs | 323.01 μs | 17.705 μs |  39.825 μs |  39.173 μs |  70.16 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.61 μs** | **285.30 μs** | **15.638 μs** |   **8.656 μs** |   **8.507 μs** |  **35.67 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 300.78 μs | 293.29 μs | 16.076 μs | 297.674 μs | 286.484 μs | 318.18 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 211.80 μs | 978.19 μs | 53.618 μs | 184.492 μs | 177.339 μs | 273.58 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  64.92 μs | 264.02 μs | 14.472 μs |  62.355 μs |  51.897 μs |  80.50 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 262.58 μs | 862.95 μs | 47.301 μs | 269.150 μs | 212.334 μs | 306.25 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.93 μs | 210.63 μs | 11.545 μs |   8.317 μs |   8.216 μs |  28.26 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.86 μs | 633.27 μs | 34.712 μs |  70.812 μs |  66.896 μs | 128.88 μs |  68.69 KB |
