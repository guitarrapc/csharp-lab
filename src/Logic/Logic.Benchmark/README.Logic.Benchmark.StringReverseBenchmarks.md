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
| **ArrayReverse**           | **10**     | **100**    |  **14.70 μs** | **161.82 μs** |  **8.870 μs** |  **11.611 μs** |   **7.794 μs** |  **24.71 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  74.98 μs | 136.30 μs |  7.471 μs |  74.500 μs |  67.766 μs |  82.69 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.53 μs | 344.61 μs | 18.889 μs |  27.986 μs |  27.267 μs |  60.34 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.46 μs | 147.50 μs |  8.085 μs |  15.109 μs |  10.811 μs |  26.46 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.83 μs | 224.84 μs | 12.324 μs |  48.129 μs |  47.298 μs |  69.05 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.79 μs | 160.46 μs |  8.795 μs |   7.775 μs |   7.644 μs |  22.94 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.66 μs | 304.91 μs | 16.713 μs |  39.823 μs |  38.221 μs |  67.94 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.31 μs** | **268.21 μs** | **14.702 μs** |   **9.027 μs** |   **8.616 μs** |  **34.28 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 314.08 μs | 372.44 μs | 20.415 μs | 309.456 μs | 296.381 μs | 336.42 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 182.76 μs |  71.27 μs |  3.907 μs | 183.211 μs | 178.653 μs | 186.43 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  74.30 μs | 295.11 μs | 16.176 μs |  69.594 μs |  60.999 μs |  92.31 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 251.02 μs | 622.55 μs | 34.124 μs | 251.178 μs | 216.824 μs | 285.07 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.71 μs | 204.01 μs | 11.182 μs |   8.435 μs |   8.075 μs |  27.62 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  92.91 μs | 587.08 μs | 32.180 μs |  81.281 μs |  68.166 μs | 129.29 μs |  68.69 KB |
