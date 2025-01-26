```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.01 μs** | **237.94 μs** | **13.042 μs** |  **10.705 μs** |  **10.254 μs** |  **33.07 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  56.12 μs | 218.90 μs | 11.998 μs |  57.467 μs |  43.512 μs |  67.40 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  44.22 μs | 268.96 μs | 14.742 μs |  39.349 μs |  32.526 μs |  60.78 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.03 μs | 203.67 μs | 11.164 μs |  14.838 μs |  14.326 μs |  33.91 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  60.35 μs | 289.19 μs | 15.852 μs |  52.127 μs |  50.304 μs |  78.63 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.85 μs | 173.91 μs |  9.533 μs |   7.694 μs |   7.013 μs |  23.85 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  41.01 μs | 238.45 μs | 13.070 μs |  34.028 μs |  32.916 μs |  56.09 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.07 μs** | **263.29 μs** | **14.432 μs** |   **8.776 μs** |   **8.696 μs** |  **33.73 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 124.44 μs | 228.90 μs | 12.547 μs | 117.680 μs | 116.728 μs | 138.92 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 142.34 μs |  18.66 μs |  1.023 μs | 142.125 μs | 141.434 μs | 143.45 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  70.65 μs | 307.19 μs | 16.838 μs |  61.013 μs |  60.853 μs |  90.10 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 257.22 μs | 691.52 μs | 37.905 μs | 235.986 μs | 234.684 μs | 300.98 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.72 μs | 219.43 μs | 12.028 μs |   7.795 μs |   7.765 μs |  28.61 μs |  15.28 KB |
| StringExtensionReverse | 64     | 100    |  97.90 μs | 511.20 μs | 28.021 μs |  85.960 μs |  77.826 μs | 129.91 μs |  38.22 KB |
