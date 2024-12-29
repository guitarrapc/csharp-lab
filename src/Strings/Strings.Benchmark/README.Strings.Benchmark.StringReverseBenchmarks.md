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
| **ArrayReverse**           | **10**     | **100**    |  **19.30 μs** | **222.84 μs** | **12.214 μs** |  **14.346 μs** |  **10.339 μs** |  **33.21 μs** |   **9.81 KB** |
| EnumerableReverse      | 10     | 100    |  59.58 μs | 158.14 μs |  8.668 μs |  56.349 μs |  52.983 μs |  69.39 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  32.76 μs | 283.26 μs | 15.526 μs |  25.767 μs |  21.960 μs |  50.55 μs |   33.2 KB |
| ReverseXor             | 10     | 100    |  22.82 μs | 159.39 μs |  8.737 μs |  20.258 μs |  15.649 μs |  32.55 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  64.64 μs | 311.56 μs | 17.077 μs |  70.135 μs |  45.489 μs |  78.29 μs |  30.91 KB |
| StringSpan             | 10     | 100    |  14.11 μs | 222.93 μs | 12.220 μs |   7.148 μs |   6.957 μs |  28.22 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  47.94 μs | 317.03 μs | 17.377 μs |  41.792 μs |  34.480 μs |  67.56 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.61 μs** | **320.15 μs** | **17.549 μs** |   **8.896 μs** |   **8.074 μs** |  **38.87 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 133.49 μs | 218.21 μs | 11.961 μs | 139.470 μs | 119.713 μs | 141.27 μs |  37.89 KB |
| RecursiveReverse       | 64     | 100    | 171.53 μs | 629.16 μs | 34.486 μs | 154.196 μs | 149.148 μs | 211.24 μs | 560.59 KB |
| ReverseXor             | 64     | 100    |  63.14 μs | 239.39 μs | 13.122 μs |  59.652 μs |  52.117 μs |  77.66 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.23 μs | 550.83 μs | 30.193 μs | 241.157 μs | 205.262 μs | 265.26 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.80 μs | 206.96 μs | 11.344 μs |  10.579 μs |   8.005 μs |  28.81 μs |  15.28 KB |
| StringExtensionReverse | 64     | 100    |  89.62 μs | 380.48 μs | 20.855 μs |  80.219 μs |  75.120 μs | 113.52 μs |  38.22 KB |
