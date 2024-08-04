```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.68 μs** | **184.16 μs** | **10.095 μs** |  **11.522 μs** |  **10.209 μs** |  **28.31 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.03 μs | 200.11 μs | 10.969 μs |  78.017 μs |  71.875 μs |  93.19 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  44.52 μs | 309.01 μs | 16.938 μs |  37.651 μs |  32.090 μs |  63.81 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.56 μs | 149.08 μs |  8.171 μs |  15.043 μs |  10.945 μs |  26.70 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  56.51 μs | 247.98 μs | 13.592 μs |  48.891 μs |  48.440 μs |  72.20 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.31 μs | 159.31 μs |  8.732 μs |   7.413 μs |   7.123 μs |  22.39 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.84 μs | 312.74 μs | 17.142 μs |  40.420 μs |  37.535 μs |  68.56 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.88 μs** | **288.23 μs** | **15.799 μs** |   **9.237 μs** |   **8.295 μs** |  **36.12 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 312.50 μs | 370.76 μs | 20.322 μs | 321.331 μs | 289.261 μs | 326.92 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 154.86 μs | 110.68 μs |  6.067 μs | 151.980 μs | 150.768 μs | 161.83 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  85.46 μs | 259.80 μs | 14.240 μs |  82.855 μs |  72.696 μs | 100.82 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 257.20 μs | 797.64 μs | 43.721 μs | 253.164 μs | 215.634 μs | 302.80 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.04 μs | 182.02 μs |  9.977 μs |  10.771 μs |   7.904 μs |  26.44 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.64 μs | 565.28 μs | 30.985 μs |  68.749 μs |  66.766 μs | 121.40 μs |  68.69 KB |
