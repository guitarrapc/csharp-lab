```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.80 μs** | **162.677 μs** |  **8.917 μs** |   **7.653 μs** |   **7.644 μs** |  **23.09 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  70.92 μs | 130.264 μs |  7.140 μs |  69.569 μs |  64.560 μs |  78.65 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  39.49 μs | 379.368 μs | 20.794 μs |  29.194 μs |  25.858 μs |  63.43 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.57 μs | 177.424 μs |  9.725 μs |  15.219 μs |  10.961 μs |  29.53 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  66.41 μs | 428.151 μs | 23.468 μs |  53.119 μs |  52.599 μs |  93.50 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.14 μs | 148.011 μs |  8.113 μs |   7.535 μs |   7.384 μs |  21.51 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.52 μs | 248.188 μs | 13.604 μs |  27.947 μs |  27.396 μs |  51.23 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **20.19 μs** | **304.581 μs** | **16.695 μs** |  **12.293 μs** |   **8.916 μs** |  **39.37 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 349.43 μs | 857.756 μs | 47.016 μs | 332.278 μs | 313.403 μs | 402.62 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 173.11 μs |   4.250 μs |  0.233 μs | 173.223 μs | 172.841 μs | 173.26 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  60.88 μs | 199.898 μs | 10.957 μs |  60.003 μs |  50.394 μs |  72.25 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 240.76 μs | 539.416 μs | 29.567 μs | 236.536 μs | 213.532 μs | 272.21 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.29 μs | 211.301 μs | 11.582 μs |  10.850 μs |   8.435 μs |  29.59 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  98.26 μs | 594.157 μs | 32.568 μs |  80.331 μs |  78.597 μs | 135.85 μs |  68.69 KB |
