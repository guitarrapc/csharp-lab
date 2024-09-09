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
| **ArrayReverse**           | **10**     | **100**    |  **13.28 μs** | **180.79 μs** |  **9.909 μs** |   **7.694 μs** |   **7.415 μs** |  **24.72 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.67 μs | 283.61 μs | 15.546 μs |  80.480 μs |  69.960 μs | 100.56 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  43.40 μs | 411.00 μs | 22.528 μs |  35.016 μs |  26.268 μs |  68.92 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.45 μs | 156.63 μs |  8.586 μs |  16.796 μs |  10.804 μs |  27.74 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.64 μs | 284.06 μs | 15.570 μs |  43.881 μs |  43.430 μs |  70.62 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.88 μs | 170.35 μs |  9.338 μs |   7.694 μs |   7.293 μs |  23.66 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.72 μs | 242.02 μs | 13.266 μs |  28.302 μs |  27.821 μs |  51.03 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.80 μs** | **260.01 μs** | **14.252 μs** |  **12.403 μs** |   **8.876 μs** |  **35.13 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 309.41 μs | 312.79 μs | 17.145 μs | 317.303 μs | 289.741 μs | 321.19 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 160.26 μs |  28.90 μs |  1.584 μs | 159.933 μs | 158.872 μs | 161.99 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.49 μs | 223.92 μs | 12.274 μs |  60.724 μs |  51.196 μs |  75.55 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 239.05 μs | 559.53 μs | 30.670 μs | 236.371 μs | 209.812 μs | 270.98 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.04 μs | 253.80 μs | 13.912 μs |   8.335 μs |   7.685 μs |  32.10 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.89 μs | 579.99 μs | 31.791 μs |  67.796 μs |  67.276 μs | 122.60 μs |  68.69 KB |
