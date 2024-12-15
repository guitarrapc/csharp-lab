```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.28 μs** | **203.97 μs** | **11.180 μs** |  **10.018 μs** |   **9.628 μs** |  **29.18 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  44.61 μs |  91.61 μs |  5.021 μs |  42.870 μs |  40.696 μs |  50.27 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  31.84 μs | 276.78 μs | 15.171 μs |  24.877 μs |  21.401 μs |  49.24 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  31.07 μs | 584.57 μs | 32.042 μs |  14.578 μs |  10.630 μs |  68.00 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  59.70 μs | 225.22 μs | 12.345 μs |  60.334 μs |  47.049 μs |  71.72 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.85 μs | 191.36 μs | 10.489 μs |   8.606 μs |   7.023 μs |  25.93 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.94 μs | 158.03 μs |  8.662 μs |  33.879 μs |  28.498 μs |  45.45 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.33 μs** | **344.25 μs** | **18.870 μs** |   **8.612 μs** |   **8.251 μs** |  **41.11 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 128.31 μs | 213.89 μs | 11.724 μs | 124.163 μs | 119.225 μs | 141.55 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 175.29 μs | 545.02 μs | 29.874 μs | 191.680 μs | 140.804 μs | 193.37 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  70.36 μs | 470.10 μs | 25.768 μs |  59.907 μs |  51.461 μs |  99.71 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.77 μs | 563.50 μs | 30.888 μs | 232.066 μs | 208.501 μs | 269.74 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.80 μs | 212.66 μs | 11.657 μs |  10.530 μs |   7.714 μs |  29.16 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  75.65 μs | 292.61 μs | 16.039 μs |  67.257 μs |  65.553 μs |  94.15 μs |  38.22 KB |
