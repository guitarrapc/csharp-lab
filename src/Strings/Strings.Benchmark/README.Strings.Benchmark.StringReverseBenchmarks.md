```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.84 μs** | **158.24 μs** |  **8.674 μs** |   **7.915 μs** |   **7.745 μs** |  **22.85 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  77.94 μs | 260.16 μs | 14.260 μs |  73.116 μs |  66.715 μs |  93.98 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  53.54 μs | 389.64 μs | 21.357 μs |  43.300 μs |  39.222 μs |  78.08 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  20.70 μs | 190.85 μs | 10.461 μs |  15.268 μs |  14.075 μs |  32.76 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.03 μs | 365.14 μs | 20.014 μs |  54.753 μs |  44.914 μs |  83.44 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.98 μs | 236.67 μs | 12.973 μs |   9.397 μs |   7.623 μs |  30.93 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  50.45 μs | 381.88 μs | 20.932 μs |  39.630 μs |  37.135 μs |  74.57 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.72 μs** | **314.63 μs** | **17.246 μs** |   **8.776 μs** |   **8.746 μs** |  **38.63 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 329.51 μs | 507.97 μs | 27.843 μs | 321.302 μs | 306.695 μs | 360.54 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 173.58 μs |  34.71 μs |  1.903 μs | 172.832 μs | 172.171 μs | 175.75 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  64.71 μs | 285.43 μs | 15.646 μs |  61.885 μs |  50.664 μs |  81.57 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 239.65 μs | 501.07 μs | 27.465 μs | 235.178 μs | 214.700 μs | 269.08 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.64 μs | 214.63 μs | 11.764 μs |   8.034 μs |   7.664 μs |  28.22 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  93.91 μs | 620.87 μs | 34.032 μs |  78.685 μs |  70.150 μs | 132.90 μs |  68.69 KB |
