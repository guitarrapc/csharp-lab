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
| **ArrayReverse**           | **10**     | **100**    |  **11.80 μs** | **151.87 μs** |  **8.324 μs** |   **7.063 μs** |   **6.922 μs** |  **21.41 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  47.07 μs | 112.26 μs |  6.153 μs |  44.423 μs |  42.679 μs |  54.10 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  38.23 μs | 322.36 μs | 17.670 μs |  31.188 μs |  25.158 μs |  58.33 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  19.54 μs | 213.16 μs | 11.684 μs |  14.973 μs |  10.825 μs |  32.82 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.86 μs | 243.88 μs | 13.368 μs |  54.090 μs |  43.471 μs |  70.03 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.36 μs | 172.04 μs |  9.430 μs |   7.113 μs |   6.713 μs |  23.24 μs |   5.13 KB |
| StringExtensionReverse | 10     | 100    |  37.70 μs | 202.98 μs | 11.126 μs |  33.523 μs |  29.274 μs |  50.31 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.31 μs** | **254.51 μs** | **13.951 μs** |  **10.475 μs** |   **8.091 μs** |  **33.36 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 141.26 μs | 252.21 μs | 13.824 μs | 146.775 μs | 125.535 μs | 151.48 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 147.59 μs |  31.05 μs |  1.702 μs | 147.265 μs | 146.072 μs | 149.43 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.75 μs | 206.90 μs | 11.341 μs |  60.523 μs |  51.075 μs |  73.66 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 232.88 μs | 615.56 μs | 33.741 μs | 224.470 μs | 204.133 μs | 270.02 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  13.67 μs | 199.87 μs | 10.956 μs |   7.383 μs |   7.304 μs |  26.32 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  77.40 μs | 241.57 μs | 13.241 μs |  70.782 μs |  68.769 μs |  92.64 μs |  38.22 KB |
