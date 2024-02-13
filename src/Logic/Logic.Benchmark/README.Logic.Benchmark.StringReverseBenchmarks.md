```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.11 μs** | **153.62 μs** |  **8.421 μs** |  **11.291 μs** |   **7.454 μs** |  **23.57 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.46 μs | 226.62 μs | 12.422 μs |  79.433 μs |  73.552 μs |  97.40 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  33.90 μs | 324.30 μs | 17.776 μs |  23.865 μs |  23.404 μs |  54.42 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.42 μs | 148.22 μs |  8.124 μs |  14.737 μs |  10.980 μs |  26.55 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  60.01 μs | 226.59 μs | 12.420 μs |  53.520 μs |  52.177 μs |  74.33 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.42 μs | 242.77 μs | 13.307 μs |  10.049 μs |   7.505 μs |  31.72 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  50.04 μs | 370.30 μs | 20.297 μs |  39.373 μs |  37.299 μs |  73.45 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.71 μs** | **303.63 μs** | **16.643 μs** |   **9.487 μs** |   **8.716 μs** |  **37.92 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 303.31 μs | 303.66 μs | 16.645 μs | 302.892 μs | 286.873 μs | 320.15 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 186.41 μs | 127.94 μs |  7.013 μs | 185.048 μs | 180.179 μs | 194.00 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.65 μs | 219.16 μs | 12.013 μs |  61.755 μs |  51.115 μs |  75.09 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.24 μs | 518.57 μs | 28.425 μs | 234.355 μs | 208.808 μs | 265.56 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.11 μs | 216.74 μs | 11.880 μs |   8.496 μs |   8.005 μs |  28.82 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.40 μs | 593.85 μs | 32.551 μs |  68.642 μs |  68.573 μs | 124.99 μs |  68.69 KB |
