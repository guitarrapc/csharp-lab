```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.17 μs** | **168.62 μs** |  **9.243 μs** |   **8.156 μs** |   **7.515 μs** |  **23.84 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  72.84 μs | 132.63 μs |  7.270 μs |  71.513 μs |  66.323 μs |  80.68 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  53.13 μs | 349.23 μs | 19.143 μs |  43.190 μs |  41.006 μs |  75.20 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  24.80 μs | 373.14 μs | 20.453 μs |  15.228 μs |  10.880 μs |  48.28 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  58.41 μs | 260.53 μs | 14.280 μs |  50.865 μs |  49.482 μs |  74.88 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.36 μs | 179.77 μs |  9.854 μs |   7.674 μs |   7.664 μs |  24.74 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  47.61 μs | 295.56 μs | 16.201 μs |  39.363 μs |  37.189 μs |  66.27 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.99 μs** | **380.16 μs** | **20.838 μs** |  **12.258 μs** |  **11.656 μs** |  **48.05 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 328.15 μs | 614.90 μs | 33.705 μs | 329.845 μs | 293.627 μs | 360.97 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 185.21 μs |  28.78 μs |  1.577 μs | 184.635 μs | 183.993 μs | 186.99 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.86 μs | 228.01 μs | 12.498 μs |  61.495 μs |  52.718 μs |  77.38 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 249.01 μs | 297.61 μs | 16.313 μs | 240.237 μs | 238.955 μs | 267.83 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.04 μs | 230.68 μs | 12.644 μs |  11.436 μs |   8.160 μs |  31.51 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.54 μs | 551.42 μs | 30.225 μs |  68.788 μs |  67.406 μs | 120.43 μs |  68.69 KB |
