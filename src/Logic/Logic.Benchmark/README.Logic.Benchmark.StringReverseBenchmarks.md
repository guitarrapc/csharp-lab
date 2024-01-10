```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **15.17 μs** | **126.96 μs** |  **6.959 μs** |  **11.382 μs** |  **10.931 μs** |  **23.20 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  70.08 μs | 138.68 μs |  7.601 μs |  67.857 μs |  63.839 μs |  78.55 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  41.42 μs | 328.79 μs | 18.022 μs |  37.870 μs |  25.437 μs |  60.95 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.38 μs | 143.79 μs |  7.881 μs |  14.882 μs |  11.045 μs |  26.20 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.38 μs | 341.79 μs | 18.735 μs |  53.661 μs |  47.729 μs |  82.73 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.42 μs | 185.31 μs | 10.157 μs |   7.665 μs |   7.445 μs |  25.15 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.49 μs | 264.66 μs | 14.507 μs |  27.701 μs |  26.539 μs |  52.23 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **20.47 μs** | **369.30 μs** | **20.242 μs** |   **8.786 μs** |   **8.776 μs** |  **43.84 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 310.46 μs | 357.41 μs | 19.591 μs | 317.204 μs | 288.382 μs | 325.78 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 184.93 μs | 345.82 μs | 18.955 μs | 174.585 μs | 173.392 μs | 206.80 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  66.15 μs | 257.17 μs | 14.096 μs |  69.018 μs |  50.844 μs |  78.60 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 259.32 μs | 606.04 μs | 33.219 μs | 266.356 μs | 223.146 μs | 288.46 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.74 μs | 207.96 μs | 11.399 μs |   8.325 μs |   7.995 μs |  27.90 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.54 μs | 555.45 μs | 30.446 μs |  68.006 μs |  67.916 μs | 120.69 μs |  68.69 KB |
