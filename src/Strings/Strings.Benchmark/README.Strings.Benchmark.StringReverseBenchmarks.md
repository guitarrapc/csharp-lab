```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **15.88 μs** | **183.49 μs** | **10.058 μs** |  **10.270 μs** |   **9.879 μs** |  **27.49 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  53.58 μs | 204.40 μs | 11.204 μs |  50.660 μs |  44.117 μs |  65.95 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  35.77 μs | 399.77 μs | 21.913 μs |  25.067 μs |  21.260 μs |  60.97 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  22.81 μs | 328.14 μs | 17.986 μs |  14.609 μs |  10.380 μs |  43.43 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  57.33 μs | 231.09 μs | 12.667 μs |  50.249 μs |  49.779 μs |  71.95 μs |  30.91 KB |
| StringSpan             | 10     | 100    |  14.69 μs | 211.83 μs | 11.611 μs |   8.936 μs |   7.073 μs |  28.05 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.78 μs | 215.99 μs | 11.839 μs |  33.634 μs |  28.574 μs |  51.14 μs |  17.58 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.12 μs** | **265.57 μs** | **14.557 μs** |   **8.765 μs** |   **8.675 μs** |  **33.93 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 148.25 μs | 436.32 μs | 23.916 μs | 161.287 μs | 120.651 μs | 162.82 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 150.78 μs | 130.99 μs |  7.180 μs | 147.086 μs | 146.204 μs | 159.06 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  72.23 μs | 492.79 μs | 27.011 μs |  61.486 μs |  52.248 μs | 102.96 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 250.60 μs | 787.55 μs | 43.168 μs | 258.262 μs | 204.111 μs | 289.42 μs |  87.94 KB |
| StringSpan             | 64     | 100    |  14.51 μs | 214.38 μs | 11.751 μs |   7.784 μs |   7.674 μs |  28.08 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  78.34 μs | 226.86 μs | 12.435 μs |  72.414 μs |  69.981 μs |  92.63 μs |  38.22 KB |
