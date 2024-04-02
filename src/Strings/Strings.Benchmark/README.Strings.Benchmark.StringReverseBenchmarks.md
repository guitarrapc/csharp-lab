```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.84 μs** | **167.05 μs** |  **9.157 μs** |   **7.644 μs** |   **7.464 μs** |  **23.41 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.57 μs | 114.33 μs |  6.267 μs |  81.212 μs |  78.817 μs |  90.67 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  42.35 μs | 346.34 μs | 18.984 μs |  38.883 μs |  25.337 μs |  62.83 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  21.44 μs | 206.60 μs | 11.325 μs |  15.108 μs |  14.697 μs |  34.51 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.50 μs | 256.77 μs | 14.074 μs |  44.713 μs |  44.042 μs |  68.75 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.62 μs | 223.62 μs | 12.258 μs |   7.594 μs |   7.493 μs |  28.77 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.00 μs | 260.08 μs | 14.256 μs |  27.883 μs |  27.652 μs |  52.46 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.67 μs** | **277.99 μs** | **15.237 μs** |   **9.067 μs** |   **8.687 μs** |  **35.27 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 328.01 μs | 361.77 μs | 19.830 μs | 321.962 μs | 311.904 μs | 350.16 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 173.91 μs |  23.70 μs |  1.299 μs | 173.465 μs | 172.883 μs | 175.37 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  67.34 μs | 249.18 μs | 13.658 μs |  69.019 μs |  52.919 μs |  80.08 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 241.40 μs | 557.32 μs | 30.548 μs | 237.606 μs | 212.920 μs | 273.66 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.03 μs | 199.71 μs | 10.947 μs |  11.472 μs |   8.106 μs |  28.52 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.22 μs | 573.85 μs | 31.455 μs |  67.636 μs |  66.494 μs | 121.54 μs |  68.69 KB |
