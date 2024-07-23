```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.95 μs** | **165.73 μs** |  **9.084 μs** |   **7.950 μs** |   **7.470 μs** |  **23.44 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  79.81 μs | 343.17 μs | 18.810 μs |  70.452 μs |  67.506 μs | 101.46 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.65 μs | 248.91 μs | 13.644 μs |  26.671 μs |  23.014 μs |  48.26 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  19.78 μs | 223.12 μs | 12.230 μs |  14.827 μs |  10.809 μs |  33.71 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  58.37 μs | 263.47 μs | 14.442 μs |  50.374 μs |  49.694 μs |  75.04 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  17.31 μs | 215.62 μs | 11.819 μs |  11.265 μs |   9.743 μs |  30.93 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  54.24 μs | 371.34 μs | 20.354 μs |  43.581 μs |  41.438 μs |  77.72 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.78 μs** | **276.24 μs** | **15.142 μs** |   **9.252 μs** |   **8.821 μs** |  **35.26 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.10 μs | 286.23 μs | 15.689 μs | 303.639 μs | 288.651 μs | 320.02 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 161.77 μs |  73.81 μs |  4.046 μs | 162.865 μs | 157.284 μs | 165.15 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  69.83 μs | 327.11 μs | 17.930 μs |  60.733 μs |  58.279 μs |  90.49 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 247.42 μs | 496.52 μs | 27.216 μs | 242.795 μs | 222.808 μs | 276.65 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  20.37 μs | 256.20 μs | 14.043 μs |  14.141 μs |  10.524 μs |  36.45 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  95.11 μs | 616.98 μs | 33.819 μs |  77.159 μs |  74.043 μs | 134.12 μs |  68.69 KB |
