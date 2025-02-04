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
| **ArrayReverse**           | **10**     | **100**    |  **18.50 μs** | **251.31 μs** | **13.775 μs** |  **10.835 μs** |  **10.255 μs** |  **34.40 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  55.53 μs | 408.88 μs | 22.412 μs |  43.926 μs |  41.303 μs |  81.37 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  30.40 μs | 244.12 μs | 13.381 μs |  24.716 μs |  20.798 μs |  45.68 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  20.36 μs | 180.10 μs |  9.872 μs |  14.954 μs |  14.373 μs |  31.75 μs |   9.81 KB |
| StackReverse           | 10     | 100    |  61.87 μs | 253.69 μs | 13.906 μs |  65.942 μs |  46.377 μs |  73.28 μs |  30.91 KB |
| StringSpan             | 10     | 100    |  12.68 μs | 174.87 μs |  9.585 μs |   7.238 μs |   7.058 μs |  23.75 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  41.77 μs | 206.79 μs | 11.335 μs |  45.304 μs |  29.094 μs |  50.92 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.82 μs** | **333.43 μs** | **18.277 μs** |  **12.503 μs** |  **12.032 μs** |  **43.92 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 124.58 μs | 223.47 μs | 12.249 μs | 118.580 μs | 116.497 μs | 138.68 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 153.31 μs | 215.36 μs | 11.805 μs | 147.363 μs | 145.670 μs | 166.91 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.57 μs | 210.31 μs | 11.528 μs |  60.131 μs |  50.825 μs |  73.75 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 229.81 μs | 528.80 μs | 28.985 μs | 228.144 μs | 201.694 μs | 259.59 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  13.76 μs | 193.44 μs | 10.603 μs |   7.764 μs |   7.504 μs |  26.00 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.96 μs | 283.59 μs | 15.545 μs |  83.049 μs |  77.239 μs | 106.59 μs |  38.22 KB |
