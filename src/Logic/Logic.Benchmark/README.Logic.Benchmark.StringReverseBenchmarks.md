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
| **ArrayReverse**           | **10**     | **100**    |  **14.36 μs** | **210.00 μs** | **11.511 μs** |   **7.754 μs** |   **7.675 μs** |  **27.65 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.10 μs | 222.51 μs | 12.197 μs |  79.229 μs |  73.308 μs |  96.76 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  49.23 μs | 355.92 μs | 19.509 μs |  39.123 μs |  36.840 μs |  71.71 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  19.47 μs | 161.47 μs |  8.850 μs |  18.024 μs |  11.431 μs |  28.95 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  58.91 μs | 240.72 μs | 13.194 μs |  51.316 μs |  51.277 μs |  74.15 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.07 μs | 173.61 μs |  9.516 μs |   7.844 μs |   7.313 μs |  24.05 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.23 μs | 256.58 μs | 14.064 μs |  28.583 μs |  27.641 μs |  52.46 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **21.97 μs** | **237.16 μs** | **13.000 μs** |  **21.931 μs** |   **8.987 μs** |  **34.99 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 300.29 μs | 287.09 μs | 15.736 μs | 297.497 μs | 286.136 μs | 317.24 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 183.56 μs | 136.83 μs |  7.500 μs | 186.950 μs | 174.967 μs | 188.77 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  69.44 μs | 301.07 μs | 16.503 μs |  61.295 μs |  58.601 μs |  88.44 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 251.59 μs | 772.51 μs | 42.344 μs | 241.151 μs | 215.444 μs | 298.18 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.63 μs | 226.00 μs | 12.388 μs |   8.620 μs |   8.330 μs |  29.93 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  96.87 μs | 569.63 μs | 31.223 μs |  93.915 μs |  67.225 μs | 129.46 μs |  68.69 KB |
