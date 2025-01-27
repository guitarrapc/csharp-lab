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
| **ArrayReverse**           | **10**     | **100**    |  **22.40 μs** | **191.89 μs** | **10.518 μs** |  **28.073 μs** |  **10.268 μs** |  **28.87 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  45.95 μs |  93.13 μs |  5.105 μs |  43.718 μs |  42.344 μs |  51.79 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  43.72 μs | 358.58 μs | 19.655 μs |  33.394 μs |  31.379 μs |  66.39 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  25.47 μs | 199.23 μs | 10.921 μs |  20.163 μs |  18.209 μs |  38.03 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  59.32 μs | 257.62 μs | 14.121 μs |  52.307 μs |  50.075 μs |  75.57 μs |  30.86 KB |
| StringSpan             | 10     | 100    |  16.40 μs | 208.03 μs | 11.403 μs |  11.131 μs |   8.587 μs |  29.49 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  38.51 μs | 180.92 μs |  9.917 μs |  35.788 μs |  30.238 μs |  49.50 μs |  17.58 KB |
| **ArrayReverse**           | **64**     | **100**    |  **28.62 μs** | **563.06 μs** | **30.863 μs** |  **12.875 μs** |   **8.807 μs** |  **64.18 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 135.04 μs | 374.99 μs | 20.554 μs | 129.452 μs | 117.850 μs | 157.81 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 164.63 μs | 330.51 μs | 18.116 μs | 154.891 μs | 153.458 μs | 185.53 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  68.27 μs | 413.64 μs | 22.673 μs |  60.904 μs |  50.203 μs |  93.72 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 257.56 μs | 667.30 μs | 36.577 μs | 243.105 μs | 230.412 μs | 299.15 μs |  87.94 KB |
| StringSpan             | 64     | 100    |  15.07 μs | 217.58 μs | 11.927 μs |   8.396 μs |   7.966 μs |  28.84 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  94.55 μs | 437.80 μs | 23.997 μs | 103.829 μs |  67.302 μs | 112.53 μs |  38.22 KB |
