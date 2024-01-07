```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.55 μs** | **162.56 μs** |  **8.911 μs** |  **11.221 μs** |   **7.785 μs** |  **24.65 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  72.51 μs | 125.11 μs |  6.858 μs |  70.653 μs |  66.764 μs |  80.10 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.09 μs | 369.18 μs | 20.236 μs |  25.458 μs |  25.347 μs |  60.45 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.90 μs | 165.50 μs |  9.072 μs |  14.707 μs |  10.850 μs |  28.13 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.74 μs | 223.25 μs | 12.237 μs |  47.759 μs |  47.589 μs |  68.87 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.97 μs | 182.62 μs | 10.010 μs |   7.263 μs |   7.112 μs |  24.52 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  51.24 μs | 323.90 μs | 17.754 μs |  42.154 μs |  39.870 μs |  71.70 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.08 μs** | **356.14 μs** | **19.521 μs** |  **12.092 μs** |  **11.521 μs** |  **45.62 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 306.89 μs | 221.23 μs | 12.126 μs | 302.281 μs | 297.741 μs | 320.64 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 181.23 μs | 243.49 μs | 13.347 μs | 173.910 μs | 173.138 μs | 196.63 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.17 μs | 210.73 μs | 11.551 μs |  62.067 μs |  52.208 μs |  75.23 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 253.67 μs | 322.20 μs | 17.661 μs | 247.753 μs | 239.729 μs | 273.53 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.29 μs | 219.44 μs | 12.028 μs |  10.699 μs |   8.075 μs |  30.10 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  91.15 μs | 496.20 μs | 27.198 μs |  83.035 μs |  68.939 μs | 121.49 μs |  68.69 KB |
